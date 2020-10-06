using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public static bool flag = true;
        public static int ip1 = 0;
        public static int ip2 = 0;
        public static int ip3 = 0;
        public static int ip4 = 0;
        public static int PORT = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn_connect_Click(object sender, EventArgs e)
        {
            // (1) 소켓 객체 생성
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Tboxvalue();
            // (2) 서버 연결
            string IP = string.Empty;
            IP = ip1 + "." + ip2 + "." + ip3 + "." + ip4;
            
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IP), PORT);
            sock.Connect(ep);
            string cmd = string.Empty;
            byte[] receiverBuff = new byte[1024];
            StringBuilder sb = new StringBuilder();
            while (flag)
            {
                int n = sock.Receive(receiverBuff);
                string strHex = BitConverter.ToString(receiverBuff);
                richTextBox1.Text = "00";
                break;
            }
            sock.Close();
            flag = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void Tboxvalue()
        {
            ip1 = Convert.ToInt32(textBox_IP1.Text);
            ip2 = Convert.ToInt32(textBox_IP2.Text);
            ip3 = Convert.ToInt32(textBox_IP3.Text);
            ip4 = Convert.ToInt32(textBox_IP4.Text);
            PORT = Convert.ToInt32(textBox_Port.Text);

        }


        //숫자키만 입력가능
        private void textBox_IP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_IP4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }

        private void textBox_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Delete)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
