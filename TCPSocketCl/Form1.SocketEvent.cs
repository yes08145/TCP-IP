using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPSocketCl
{
    public partial class Form1 : Form
    {
        private void SocketConnect()
        {
            // (2) 서버 연결
            IP = IP1 + "." + IP2 + "." + IP3 + "." + IP4; // 192.168.0.180
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            Log("Connect 시도중");
            try
            {
                foreach(SocketInfo usedSockInfo in socketInfo)
                {
                    if(usedSockInfo.IP == IP && usedSockInfo.conn)
                    {
                        throw new Exception("이미 연결되어있음");
                    }
                }
                sockN++;
                socketInfo[sockN].sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketInfo[sockN].sock.ReceiveTimeout = 30000;
                socketInfo[sockN].sock.Connect(ep);
                socketInfo[sockN].conn = true;
            }
            catch(Exception e)
            {
                if (e.Message == "이미 연결되어있음")
                {
                    MessageBox.Show(e.Message);
                }
                else
                {
                    MessageBox.Show("유효한 IP or PORT가 아닙니다.");
                }
                Log("Not Vaild IP or PORT");
                return;
            }
            Log2(IP);
            Log("========= IP: " + IP + ", PORT: " + PORT + " Connect 완료 =========");
            TboxClear();
        }
        private void StartThread(Socket sock, SocketDelegate socketDelegate)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(socketDelegate));
            thread.Start(sock);
        }
        public void Send(object obj)
        {
            try
            {
                if(obj.GetType() != typeof(Socket))
                {
                    throw new Exception("Send(object obj): obj 타입이 Socket이 아님");
                }
                else
                {
                    byte[] sendBuff = MakeMsg();
                    ((Socket)obj).Send(sendBuff);
                    strHex = BitConverter.ToString(sendBuff);
                    if (!InvokeRequired)
                    {
                        Log(logMsg[sensorID - 1]);
                        Log(strHex);
                        ListboxFocus();
                    }
                    else
                    {
                        this.Invoke(new LogDelegate(Log), logMsg[sensorID - 1]);
                        this.Invoke(new LogDelegate(Log), strHex);
                        this.Invoke(new FocusDelegate(ListboxFocus));
                    }

                }
                
            }
            catch(Exception e)
            {

            }
        }
        public void Recv()
        {
            byte[] receiverBuff = new byte[1024];
            try
            {
                while (conn)
                {
                    int n = sock.Receive(receiverBuff);
                    int dec_cksum = receiverBuff[0] + receiverBuff[1] + receiverBuff[2] + receiverBuff[3] + receiverBuff[4];
                    String hex_cksum = String.Format("{0:x2}", dec_cksum);
                    //int resize = BitConverter.ToInt32(receiverBuff, 0);
                    r_strHex = BitConverter.ToString(receiverBuff);
                    string strHexSplit = string.Empty;
                    string log_result = string.Empty;
                    int p_length = Convert.ToInt32(r_strHex.Split('-')[2], 16);
                    //strHexSplit = r_strHex.Substring(0, (p_length * 2) + (p_length - 1));

                    if (r_strHex.Split('-')[0] == "02" && r_strHex.Split('-')[p_length - 1] == "03")
                    {
                        strHexSplit = r_strHex.Substring(0, (p_length * 2) + (p_length - 1));
                    }
                    else
                    {
                        //StartFrame or EndFrame error
                        continue;
                    }

                    // 들어온 값을 검증
                    log_result = JudgeAction(strHexSplit, hex_cksum);

                    if (!InvokeRequired)
                    {
                        Log(log_result);
                        Log(strHexSplit);
                        ListboxFocus();
                    }
                    else
                    {
                        this.Invoke(new LogDelegate(Log), log_result);
                        this.Invoke(new LogDelegate(Log), strHexSplit);
                        this.Invoke(new FocusDelegate(ListboxFocus));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                if(conn)
                    this.Invoke(new SocketDelegate(btn_disconnect.PerformClick));
            }
        }

        public byte[] MakeMsg()
        {
            byte[] msg;
            RTUP rtup = new RTUP();
            rtup.usys_device_ID = 0x74;
            rtup.sensor_ID = (byte)sensorID;
            //0 or 1 장비 선택
            rtup.ch_setting = (byte)ch;
            try
            {
                if (sensorID == 1)
                {
                    // 4~20mA
                    rtup.data = (byte)data;
                    rtup.length = 0x09;
                    //checksum
                    int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting + rtup.data;
                    if (checkSum > 255)
                    {
                        rtup.check_sum[0] = (byte)(checkSum - 255);
                        rtup.check_sum[1] = 0xFF;
                    }
                    else
                    {
                        rtup.check_sum[0] = 0x00;
                        rtup.check_sum[1] = (byte)checkSum;
                    }

                    msg = new byte[9];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = rtup.sensor_ID;
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.data;
                    msg[6] = rtup.check_sum[0];
                    msg[7] = rtup.check_sum[1];
                    msg[8] = rtup.eof;
                }
                else if (sensorID == 2)
                {
                    rtup.length = 0x08;
                    int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting;
                    if (checkSum > 255)
                    {
                        rtup.check_sum[0] = (byte)(checkSum - 255);
                        rtup.check_sum[1] = 0xFF;
                    }
                    else
                    {
                        rtup.check_sum[0] = 0x00;
                        rtup.check_sum[1] = (byte)checkSum;
                    }

                    msg = new byte[8];
                    msg[0] = rtup.sof;
                    msg[1] = rtup.usys_device_ID;
                    msg[2] = rtup.length;
                    msg[3] = rtup.sensor_ID;
                    msg[4] = rtup.ch_setting;
                    msg[5] = rtup.check_sum[0];
                    msg[6] = rtup.check_sum[1];
                    msg[7] = rtup.eof;
                }
                else
                {
                    throw new Exception("잘못된 요청명령");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return msg;
        }

        public string JudgeAction(string txt, string hex_cksum)
        {
            RTUP rtup = new RTUP();
            string log = string.Empty;
            rtup.usys_device_ID = Convert.ToByte(txt.Split('-')[1]);
            rtup.length = Convert.ToByte(txt.Split('-')[2]);
            rtup.sensor_ID = Convert.ToByte(txt.Split('-')[3]);
            rtup.response_channel = Convert.ToByte(txt.Split('-')[4]);
            string start_cksum = string.Empty;
            string last_cksum = string.Empty;
            if (hex_cksum.Length >= 3)
            {
                start_cksum = hex_cksum.Substring(0, hex_cksum.Length - 2);
                last_cksum = hex_cksum.Substring(hex_cksum.Length - 2);
                if (start_cksum.Length == 1)
                {
                    start_cksum = "0" + start_cksum;
                }
            }
            else
            {
                start_cksum = "00";
                last_cksum = hex_cksum;
                if (last_cksum.Length == 1)
                {
                    last_cksum = "0" + last_cksum;
                }
            }
            if (start_cksum.ToUpper() == txt.Split('-')[rtup.length-3] && last_cksum.ToUpper() == txt.Split('-')[rtup.length-2])
            {
                log = "Device"+device_judge[74-rtup.usys_device_ID] + "의 " + rtup.response_channel + "채널에서 "+logMsg[rtup.sensor_ID];
                
            }
            //로그를 띄워주자 (체크섬 오류)
            else log = "CheckSum 오류";

            return log;
        }

    }
}
