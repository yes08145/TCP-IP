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
        private void ThreadStart()
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
            ts = new ThreadStart(Connect);
            thread = new Thread(ts);
            thread.Start();
        }

        public void Connect()
        {
            byte[] receiverBuff = new byte[16];
            conn = true;
            try
            {
                while (flag)
                {
                    sock.Send()
                    int n = sock.Receive(receiverBuff);
                    //int resize = BitConverter.ToInt32(receiverBuff, 0);
                    strHex = BitConverter.ToString(receiverBuff);
                    if (!InvokeRequired)
                    {
                        Log(strHex);
                        ListboxFocus();
                    }
                    else
                    {
                        this.Invoke(new LogDelegate(Log), strHex);
                        this.Invoke(new FocusDelegate(ListboxFocus));
                    }
                    Thread.Sleep(10);
                }
                thread.Abort();
                //sock.Shutdown(SocketShutdown.Both);
                //sock.Close();
                //Log("======= Connect 종료 =======");
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                sock.Shutdown(SocketShutdown.Both);
                sock.Close();
                Log("======= Connect 종료 =======");
                ListboxFocus();
                flag = true;
                conn = false;
            }
        }

        public void Send()
        {
            RTUP rtup = new RTUP();
            rtup.usys_device_ID = 0x74;
            rtup.length = 0x09;
            rtup.sensor_ID = 0x01;
            //0 or 1 장비 선택
            rtup.ch_setting = 0x00;
            // 4~20mA
            rtup.data = 0x04;
            //checksum
            int checkSum = rtup.sof + rtup.usys_device_ID + rtup.length + rtup.sensor_ID + rtup.ch_setting + rtup.data;
            rtup.check_sum = (byte)checkSum;
            byte[] msg = new byte[9];
            msg[0] = rtup.sof;
            msg[1] = rtup.usys_device_ID;
            msg[2] = rtup.length;
            msg[3] = rtup.sensor_ID;
            msg[4] = rtup.ch_setting;
            msg[5] = rtup.data;
            msg[6] = rtup.check_sum;
            msg[7] = rtup.eof;
        }
    }
}
