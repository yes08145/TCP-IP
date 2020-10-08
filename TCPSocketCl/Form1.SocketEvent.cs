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
                thread.Interrupt();
                //sock.Shutdown(SocketShutdown.Both);
                //sock.Close();
                //Log("======= Connect 종료 =======");
            }
            catch
            {

            }
            finally
            {
                sock.Shutdown(SocketShutdown.Both);
                sock.Close();
                this.Invoke(new LogDelegate(Log), "======= Connect 종료 =======");
                this.Invoke(new FocusDelegate(ListboxFocus));
                flag = true;
                conn = false;
            }
        }
    }
}
