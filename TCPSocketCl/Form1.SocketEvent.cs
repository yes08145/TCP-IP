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
        private static string reconnIP = string.Empty;
        private static int reconnPORT = 5000;
        private static bool reconn = false;
        private static Mutex mutex = new Mutex();
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
                try
                {
                    Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    sock.ReceiveTimeout = 300000;
                    sock.Connect(ep);
                    socketInfo.Add(new SocketInfo(sock,IP,PORT,true));
                    Log2(IP+":"+PORT);
                    Log("========= IP: " + IP + ", PORT: " + PORT + " Connect 완료 =========");
                }
                catch
                {
                    Log("======Connect Fail======");
                    MessageBox.Show("서버에 연결할 수 없습니다.");
                }
                
            }
            catch(Exception e)
            {
                if (e.Message == "이미 연결되어있음")
                {
                    MessageBox.Show(e.Message);
                }
                return;
            }
        }
        private void SocketDisconnect()
        {
            try
            {
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.IP + ":" + usedSockInfo.PORT == listBox_quick.SelectedItem.ToString())
                    {
                        SocketDisconnect(usedSockInfo);
                        return;
                    }
                }
                MessageBox.Show("Connect중인 서버가 없습니다.");
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Disconnect할 서버를 선택해주십시오.");
            }
        }
        private void SocketDisconnect(object obj)
        {
            try
            {
                if (obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Send(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    SocketInfo throwSockInfo = (SocketInfo)obj;
                    if (throwSockInfo.conn)
                    {
                        int i = 0;
                        foreach(SocketInfo removeSockInfo in socketInfo)
                        {
                            if(removeSockInfo.IP == throwSockInfo.IP && removeSockInfo.PORT == throwSockInfo.PORT)
                            {
                                break;
                            }
                            i++;
                        }
                        throwSockInfo.conn = false;
                        throwSockInfo.sock.Shutdown(SocketShutdown.Both);
                        throwSockInfo.sock.Close();
                        listBox_quick.Items.Remove(throwSockInfo.IP + ":" + throwSockInfo.PORT);
                        socketInfo.RemoveAt(i);
                        this.Text = "SocketClient===State===(Disconnected)";
                        Log("======= Connect 종료 =======");
                        ListboxFocus();
                    }
                }
            }
            catch(Exception e)
            {

            }
        }
        private void StartThread(SocketInfo socketInfo, SocketDelegate socketDelegate)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(socketDelegate));
            thread.Start(socketInfo);
        }
        public void Send(object obj)
        {
            try
            {
                if(obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Send(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    byte[] sendBuff = MakeMsg((SocketInfo)obj);
                    SocketInfo socketInfo = (SocketInfo)obj;
                    socketInfo.sock.Send(sendBuff);
                    strHex = BitConverter.ToString(sendBuff);
                    //# D I/O 추가에 따라 기존 log 텍스트 불러오는 공식이 깨짐
                    //# 이를 해결하기 위한 배열 위치조정
                    //# 이로인한 sensorID 손상 인지요망
                    if(sensorID == 4)
                    {
                        sensorID = 3;
                    }
                    //#
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
        public void Recv(object obj)
        {
            try
            {
                if (obj.GetType() != typeof(SocketInfo))
                {
                    throw new Exception("Recv(object obj): obj 타입이 SocketInfo가 아님");
                }
                else
                {
                    SocketInfo socketInfo = (SocketInfo)obj;
                    while (socketInfo.conn)
                    {
                        byte[] receiverBuff = new byte[16];
                        int n = socketInfo.sock.Receive(receiverBuff);
                        int dec_cksum = 0;
                        string strHexSplit = string.Empty;
                        string log_result = string.Empty;
                        r_strHex = BitConverter.ToString(receiverBuff);
                        int p_length = Convert.ToInt32(r_strHex.Split('-')[2], 16);
                        if (r_strHex.Split('-')[3] == "1")
                        {
                            dec_cksum = receiverBuff[0] + receiverBuff[1] + receiverBuff[2] + receiverBuff[3] + receiverBuff[4];
                        }
                        else // (r_strHex.Split('-')[3] == "2"
                        {
                            dec_cksum = receiverBuff[0] + receiverBuff[1] + receiverBuff[2] + receiverBuff[3] + receiverBuff[4] + receiverBuff[5];
                        }
                        String hex_cksum = String.Format("{0:x2}", dec_cksum).ToUpper();

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
                            //Log(strHexSplit);
                            ListboxFocus();
                        }
                        else
                        {
                            this.Invoke(new LogDelegate(Log), log_result);
                            //this.Invoke(new LogDelegate(Log), strHexSplit);
                            this.Invoke(new FocusDelegate(ListboxFocus));
                        }
                        Thread.Sleep(1000);
                    }
                }
                
            }
            catch (Exception e)
            {
                if (e.Message == "Recv(object obj): obj 타입이 SocketInfo가 아님")
                {
                    
                }
                else if (e.GetType().Name == "SocketException")
                {
                    SocketInfo disconnectedSocketInfo = (SocketInfo)obj;
                    //뮤텍스: 공유자원 reconnIP-재접속할 IP, reconnPORT-재접속할 PORT
                    //Lock
                    mutex.WaitOne();
                    reconnIP = disconnectedSocketInfo.IP;
                    reconnPORT = disconnectedSocketInfo.PORT;
                    if (disconnectedSocketInfo.conn)
                    {
                        this.Invoke(new SocketDelegate(SocketDisconnect), disconnectedSocketInfo);
                        this.Invoke(new Action(() =>
                        {
                            if (MessageBox.Show(this, "서버와의 연결이 끊겼습니다.\n다시 접속하시겠습니까?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                reconn = true;
                            }
                            else
                            {
                                reconn = false;
                            }
                        }
                        ));
                    }
                    //Unlock
                    mutex.ReleaseMutex();
                    
                }
               
            }
        }

        public byte[] MakeMsg(SocketInfo sendSocketInfo)
        {
            byte[] msg;
            RTUP rtup = new RTUP();
            rtup.usys_device_ID = 0x74;
            rtup.sensor_ID = (byte)sensorID;
            if (true)
            {

            }
            
            try
            {
                if (sensorID == 1)
                {
                    // 4~20mA
                    rtup.ch_setting = (byte)aout_ch;
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
                    rtup.ch_setting = (byte)ain_ch;
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
                else if(sensorID == 3)
                {
                    byte[] recvBuff = sendSocketInfo.r_Buff;
                    msg = recvBuff;
                }
                else if(sensorID == 4)
                {
                    // digit 0/1
                    rtup.ch_setting = (byte)dout_ch;
                    if(data != 0 && data != 1)
                    {
                        throw new FormatException("보내고자하는 Digital Output\t"+data+"은 잘못된 값입니다.");
                    }
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
            rtup.data = Convert.ToByte(Convert.ToInt32(txt.Split('-')[5],16));
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
            if (start_cksum == txt.Split('-')[rtup.length-3] && last_cksum == txt.Split('-')[rtup.length-2])
            {
                if(rtup.sensor_ID == 1)
                {
                    log = "Device" + device_judge[74 - rtup.usys_device_ID] + "의 " + rtup.response_channel + "채널에서 " + logMsg[rtup.sensor_ID + 2];
                }
                else
                {
                    log = "Device" + device_judge[74 - rtup.usys_device_ID] + "의 " + rtup.response_channel + "채널에서 '" + rtup.data+"mA'의 "+logMsg[rtup.sensor_ID + 2];
                }         
            }
            //로그를 띄워주자 (체크섬 오류)
            else log = "CheckSum 오류";

            return log;
        }

    }
}
