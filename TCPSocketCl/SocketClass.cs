using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCPSocketCl
{
    partial class SocketClass
    {
        public bool flag = true;
        private static int IP1 = 192;
        private static int IP2 = 168;
        private static int IP3 = 0;
        private static int IP4 = 1;
        private static string IP = IP1 + "." + IP2 + "." + IP3 + "." + IP4;
        private static int S_PORT = 0;
        public string strHex = string.Empty;
        public static Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        
        //ThreadStart ts = null;
        //Thread thread = null;
        private Thread receiveThread;
        

        public delegate void TextDelegate();


        //public void socketClass(bool flag, int ip1, int ip2, int ip3, int ip4, int port)
        //{
        //    this.flag = flag;
        //    IP1 = ip1;
        //    IP2 = ip2;
        //    IP3 = ip3;
        //    IP4 = ip4;
        //    S_PORT = port;
        //}
        //public void ThreadStart()
        //{
        //    // (1) 소켓 객체 생성
        //    // (2) 서버 연결
        //    IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), S_PORT);
        //    Form1.Log("Connect 시도중");
        //    sock.Connect(ep);
        //    Form1.Log("Connect 완료");
        //    //ts = new ThreadStart(Connect);
        //    //thread = new Thread(ts);
        //    //thread.Start();
        //    receiveThread = new Thread(new ThreadStart(Connect));
        //    receiveThread.IsBackground = true;
        //    receiveThread.Start();
        //}
        public void Connect()
        {
            byte[] receiverBuff = new byte[1024];
            while (flag)
            {
                int n = sock.Receive(receiverBuff);
                strHex = BitConverter.ToString(receiverBuff);
                //if (InvokeRequired)
                //    this.Invoke(new TextDelegate(ReceiveText));
                //else
                    //ReceiveText();
                //Thread.Sleep(100);
            }
            sock.Close();
            flag = true;
        }
        public void DisConnect()
        {
            flag = false;
        }

    }
}
