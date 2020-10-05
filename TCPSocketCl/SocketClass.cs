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
    public partial class SocketClass : Form1
    {
        public bool flag = true;
        public int ip1 = 192;
        public int ip2 = 168;
        public int ip3 = 0;
        public int ip4 = 1;
        public int port = 8080;
        public string strHex = string.Empty;
        ThreadStart ts = null;
        Thread thread = null;
        public delegate void TextDelegate();
        public SocketClass(bool flag, int ip1, int ip2, int ip3, int ip4, int port)
        {
            this.flag = flag;
            this.ip1 = ip1;
            this.ip2 = ip2;
            this.ip3 = ip3;
            this.ip4 = ip4;
            this.port = port;
        }
        public void ThreadStart()
        {
            ts = new ThreadStart(Connect);
            thread = new Thread(ts);
            thread.Start();
        }
        public void Connect()
        {
            // (1) 소켓 객체 생성
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // (2) 서버 연결
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ip1 + "." + ip2 + "." + ip3 + "." + ip4), port);
            sock.Connect(ep);
            byte[] receiverBuff = new byte[1024];
            while (flag)
            {
                int n = sock.Receive(receiverBuff);
                strHex = BitConverter.ToString(receiverBuff);
                if (InvokeRequired)
                    this.Invoke(new TextDelegate(ReceiveText));
                else
                    ReceiveText();
                Thread.Sleep(100);
            }
            sock.Close();
            flag = true;
        }
        public void DisConnect()
        {
            flag = false;
        }
        public void ReceiveText()
        {
            richTextBox1.Text = strHex;
            Form1 fo = new Form1();
            fo.Refresh();
        }
    }
}
