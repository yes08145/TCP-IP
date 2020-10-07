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
        bool flag = true;
        bool conn = false;
        public static bool clickFlag = false;
        private static int IP1 = 0;
        private static int IP2 = 0;
        private static int IP3 = 0;
        private static int IP4 = 0;
        private static int PORT = 5000;
        private static string IP = string.Empty;
        private static string q_ip1 = string.Empty;
        private static string q_ip2 = string.Empty;
        private static string q_ip3 = string.Empty;
        private static string q_ip4 = string.Empty;
        private static string q_port = string.Empty;
        private static string strHex = string.Empty;
        ThreadStart ts = null;
        Thread thread = null;
        //private static string filePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
        //private static string DirPath = Directory.GetCurrentDirectory() + @"\Logs";
        // (1) 소켓 객체 생성
        private static Socket sock = null;
        public delegate void TextDelegate();
        public delegate void LogDelegate(string msg);
        //public static SocketClass socketClass = null;


        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                TboxValue();
            }
            catch
            {
                MessageBox.Show("IP 또는 PORT 번호를 입력해주세요.");
                return;
            }
            ThreadStart();
            //socketClass.Connect();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Program Start");
            Log2("192.168.0.180:5000");
        }
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
            Log("========= IP: "+IP+", PORT: "+PORT+" Connect 완료 =========");
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
                    if (!InvokeRequired) {
                         ReceiveText();
                         ListboxFocus();}
                    else
                    {
                        this.Invoke(new TextDelegate(ReceiveText));
                        this.Invoke(new TextDelegate(ListboxFocus));
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
                this.Invoke(new TextDelegate(ListboxFocus)); 
                flag = true;
                conn = false;
            }
        }
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (conn == false)
            {
                MessageBox.Show("Connect된 서버가 없습니다.");
                return;
            }
            flag = false;
        }
        //public void DisConnect()
        //{
        //    flag = false;
        //}
        private void ListboxFocus()
        {
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
        public void Log(string msg)
        {
            SocketClass sc = new SocketClass();
            string return_msg = string.Format("[{0}] {1}", DateTime.Now.ToString(), msg);
            listBox1.Items.Add(return_msg);
            sc.LogFile(return_msg);
            
        }
        public void Log2(string msg)
        {
            listBox_quick.Items.Add(string.Format(

            "{0}", msg

            ));
        }

        private void TboxValue()
        {
            IP1 = Convert.ToInt32(textBox_IP1.Text);
            IP2 = Convert.ToInt32(textBox_IP2.Text);
            IP3 = Convert.ToInt32(textBox_IP3.Text);
            IP4 = Convert.ToInt32(textBox_IP4.Text);
            PORT = Convert.ToInt32(textBox_Port.Text);
        }
        private void TboxClear()
        {
            textBox_IP1.Clear();
            textBox_IP2.Clear();
            textBox_IP3.Clear();
            textBox_IP4.Clear();
            textBox_Port.Clear();
        }
        private void ReceiveText()
        {
            Log(strHex);
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
        //text Clear
        private void btn_textClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox_quick_MouseClick(object sender, MouseEventArgs e)
        {
            if(listBox_quick.SelectedItem != null)
            {
                q_ip1 = listBox_quick.SelectedItem.ToString().Split('.')[0];
                q_ip2 = listBox_quick.SelectedItem.ToString().Split('.')[1];
                q_ip3 = listBox_quick.SelectedItem.ToString().Split('.')[2];
                q_ip4 = listBox_quick.SelectedItem.ToString().Split('.')[3].Split(':')[0];
                q_port = listBox_quick.SelectedItem.ToString().Split(':')[1];
            }
        }

        private void btn_quick_Click(object sender, EventArgs e)
        {
            if (listBox_quick.SelectedItem != null)
            {
                textBox_IP1.Text = q_ip1;
                textBox_IP2.Text = q_ip2;
                textBox_IP3.Text = q_ip3;
                textBox_IP4.Text = q_ip4;
                textBox_Port.Text = q_port;
                listBox_quick.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("선택된 IP가 없습니다.");
                //MessageBox.Show(filePath);
            }
        }
    }
}
