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
        public static bool clickFlag = false;
        public static int ip1 = 192;
        public static int ip2 = 168;
        public static int ip3 = 0;
        public static int ip4 = 180;
        public static int port = 5000;
        public static SocketClass socketClass = null;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btn_connect_Click(object sender, EventArgs e)
        {
            SocketClass socketClass = new SocketClass(flag, ip1, ip2, ip3, ip4, port);
            socketClass.ThreadStart();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            socketClass.DisConnect();
        }

        private void Tboxvalue()
        {
            ip1 = Convert.ToInt32(textBox_IP1.Text);
            ip2 = Convert.ToInt32(textBox_IP2.Text);
            ip3 = Convert.ToInt32(textBox_IP3.Text);
            ip4 = Convert.ToInt32(textBox_IP4.Text);
            port = Convert.ToInt32(textBox_Port.Text);

        }
    }
}
