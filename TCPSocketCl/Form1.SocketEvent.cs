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
                sock.Connect(ep);
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
        private void ThreadStart()
        {
            ts = new ThreadStart(Connect);
            thread = new Thread(ts);
            thread.Start();
        }

        public void Connect()
        {
            byte[] receiverBuff = new byte[10];
            
            conn = true;
            try
            {
                while (true)
                {
                    if (!flag)
                    {
                        int logN = 0;
                        if(sensorID == 1)
                        {
                            logN = sensorID;
                        }
                        else if(sensorID == 2)
                        {
                            logN = sensorID+1;
                        }
                        else
                        {
                            throw new Exception("잘못된 요청명령");
                        }
                        byte[] sendBuff = MakeMsg();
                        sock.Send(sendBuff);
                        strHex = BitConverter.ToString(sendBuff);
                        if (!InvokeRequired)
                        {
                            Log(logMsg[sensorID-1]);
                            Log(strHex);
                            ListboxFocus();
                        }
                        else
                        {
                            this.Invoke(new LogDelegate(Log), logMsg[sensorID - 1]);
                            this.Invoke(new LogDelegate(Log), strHex);
                            this.Invoke(new FocusDelegate(ListboxFocus));
                        }
                        int n = sock.Receive(receiverBuff);

                        //int resize = BitConverter.ToInt32(receiverBuff, 0);
                        strHex = BitConverter.ToString(receiverBuff);
                        if (!InvokeRequired)
                        {
                            Log(logMsg[sensorID]);
                            Log(strHex);
                            ListboxFocus();
                        }
                        else
                        {
                            this.Invoke(new LogDelegate(Log), logMsg[sensorID]);
                            this.Invoke(new LogDelegate(Log), strHex);
                            this.Invoke(new FocusDelegate(ListboxFocus));
                        }

                        flag = true;
                    }
                }
                //sock.Shutdown(SocketShutdown.Both);
                //sock.Close();
                //Log("======= Connect 종료 =======");
            }
            catch(Exception e)
            {
                throw e;
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
    }
}
