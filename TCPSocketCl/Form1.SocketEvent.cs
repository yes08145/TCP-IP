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
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.ReceiveTimeout = 30000;
                sock.Connect(ep);
                conn = true;
            }
            catch
            {
                MessageBox.Show("유효한 IP or PORT가 아닙니다.");
                Log("Not Vaild IP or PORT");
                return;
            }
            Log("========= IP: " + IP + ", PORT: " + PORT + " Connect 완료 =========");
            TboxClear();
        }
        private void ThreadStart(SocketDelegate socketDelegate)
        {
            ts = new ThreadStart(socketDelegate);
            thread = new Thread(ts);
            thread.Start();
        }
        public void Send()
        {
            try
            {
                byte[] sendBuff = MakeMsg();
                sock.Send(sendBuff);
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
            catch(Exception e)
            {
                throw e;
            }
        }
        public void Recv()
        {
            byte[] receiverBuff = new byte[1024];
            try
            {
                while (conn)
                {
                    RTUP rttt = new RTUP();
                    int n = sock.Receive(receiverBuff);
                    //int resize = BitConverter.ToInt32(receiverBuff, 0);
                    recvHex = BitConverter.ToString(receiverBuff);
                    string strHexSplit = string.Empty;
                    string log_result = string.Empty;
                    int p_length = Convert.ToInt32(recvHex.Split('-')[2], 16);
                    //strHexSplit = strHex.Substring(0, (p_length * 2) + (p_length - 1));

                    if (recvHex.Split('-')[p_length - 1] == "03")
                    {
                        strHexSplit = recvHex.Substring(0, (p_length * 2) + (p_length - 1));
                    }
                    else
                    {
                        continue;
                    }
                    log_result = JudgeAction(strHexSplit);
                    if (!InvokeRequired)
                    {
                        Log(logMsg[sensorID + 1]);
                        Log(strHexSplit);
                        ListboxFocus();
                    }
                    else
                    {
                        this.Invoke(new LogDelegate(Log), logMsg[sensorID + 1]);
                        this.Invoke(new LogDelegate(Log), strHexSplit);
                        this.Invoke(new FocusDelegate(ListboxFocus));
                    }
                    Thread.Sleep(1000);
                }
            }
            catch (Exception e)
            {
                btn_disconnect.PerformClick();
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
        public string JudgeAction(string txt)
        {
            RTUP rtup = new RTUP();
            string log = string.Empty;
            rtup.length = Convert.ToByte(txt.Split('-')[2]);
            rtup.sensor_ID = Convert.ToByte(txt.Split('-')[3]);

            string ck_sum = string.Empty;

            ck_sum = txt.Split('-')[0] + txt.Split('-')[1] + txt.Split('-')[2] + txt.Split('-')[3] + txt.Split('-')[4];
            if (txt.Split('-')[4] == "00")
            {

            }
            if (rtup.sensor_ID == 01) // 전류 출력
            {
                ck_sum = txt.Split('-')[0] + txt.Split('-')[1] + txt.Split('-')[2] + txt.Split('-')[3] + txt.Split('-')[4];
                rtup.check_sum = Encoding.UTF8.GetBytes(ck_sum);
                log = Aoutput(txt, rtup.check_sum);
            }
            else if (rtup.sensor_ID == 02) //전류 입력{
            {
                ck_sum = txt.Split('-')[0] + txt.Split('-')[1] + txt.Split('-')[2] + txt.Split('-')[3] + txt.Split('-')[4] + txt.Split('-')[5];
                rtup.check_sum = Encoding.UTF8.GetBytes(ck_sum);
                Ainput(txt);
            }
            return log;
        }

        public string Aoutput(string txt, byte[] ck_sum)
        {
            string ch_name = string.Empty;
            string log = string.Empty;
            if (txt.Split('-')[4] == "00")
            {

                ch_name = "00";
            }
            else ch_name = "01";

            return ch_name;
        }
        public void Ainput(string txt)
        {

        }
    }
}
