using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        bool conn = false;
        public static bool clickFlag = false;
        private static int IP1 = 0;
        private static int IP2 = 0;
        private static int IP3 = 0;
        private static int IP4 = 0;
        private static int PORT = 5000;
        private static int data = 0;
        private static int ch = 0;
        private static int sensorID = 0;
        private static string IP = string.Empty;
        private static string q_ip1 = string.Empty;
        private static string q_ip2 = string.Empty;
        private static string q_ip3 = string.Empty;
        private static string q_ip4 = string.Empty;
        private static string q_port = string.Empty;
        private static string strHex = string.Empty;
        private static string r_strHex = string.Empty;
        private static string[] device_judge = new string[2];
        private static string[] logMsg = new string[4] { "전류 출력 설정", "전류 입력 값 요청", "전류 출력 응답", "전류 입력 값 응답" };
        private static string filePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
        private static string DirPath = Directory.GetCurrentDirectory() + @"\Logs";
        // (1) 소켓 객체 생성
        private static SocketInfo[] socketInfo = null;
        public delegate void FocusDelegate();
        public delegate void SocketDelegate(object obj);
        public delegate void LogDelegate(string msg);
        //public static SocketClass socketClass = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Log("Socket Client Program Start");
            Log2("192.168.0.180:5000");
            Log2("192.168.0.244:5000");
            Log2("192.168.0.31:4265");
            device_judge[0] = "RTU";
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
            SocketConnect();
            ThreadStart(Recv);
        }
        
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (!conn)
            {
                MessageBox.Show("Connect된 서버가 없습니다.");
                return;
            }
            conn = false;
            sock.Shutdown(SocketShutdown.Both);
            sock.Close();
            Log("======= Connect 종료 =======");
            ListboxFocus();
        }
        private void ListboxFocus()
        {
            listbox1.SelectedIndex = listbox1.Items.Count - 1;
        }

        public void Log(string msg)
        {
            //SocketClass sc = new SocketClass();
            string return_msg = string.Format("[{0}] {1}", DateTime.Now.ToString(), msg);
            listbox1.Items.Add(return_msg);
            //......
            //sc.LogFile(return_msg);       
            DirectoryInfo di = new DirectoryInfo(DirPath);
            FileInfo fi = new FileInfo(filePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);
                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(filePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
            }
            catch
            {
            }

        }

        public void Log2(string msg)
        {
            listBox_quick.Items.Add(string.Format(

            "{0}", msg

            ));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ch = 0;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ch = 1;
        }
        private void ButtonOSetting_Click(object sender, EventArgs e)
        {
            sensorID = 1;
            data = Convert.ToInt32(textbox_Aoutput.Text);
            foreach(SocketInfo usedSockInfo in socketInfo)
            {
                if(usedSockInfo.IP == listBox_quick.SelectedItem.ToString())
                {
                    if (usedSockInfo.conn)
                    {
                        StartThread(usedSockInfo.sock,Send);
                    }
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ch = 0;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            ch = 1;
        }
        private void Button_AIRequest_Click(object sender, EventArgs e)
        {
            sensorID = 2;
            
            if (conn)
            {
                ThreadStart(Send);
            }
        }

    }
}
