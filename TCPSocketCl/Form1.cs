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
        private static int elecout_ch = 0;
        private static int elecin_ch = 0;
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
            device_judge[1] = "SmartPoE";
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn)
                {
                    MessageBox.Show("이미 연결중입니다. Disconnect을 실행해주세요.");
                    return;
                }
                TboxValue();
            }
            catch
            {
                MessageBox.Show("IP 또는 PORT 번호를 입력해주세요.");
                return;
            }
            SocketConnect();
            ThreadStart(Recv);
            this.Text = "SocketClient===State===(Connected)";
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
            this.Text = "SocketClient===State===(Disconnected)";
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
            elecout_ch = 0;
            Button_State(button1,1);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            elecout_ch = 1;
            Button_State(button2,1);
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
            elecout_ch = 0;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            elecout_ch = 1;
        }
        private void Button_AIRequest_Click(object sender, EventArgs e)
        {
            sensorID = 2;
            
            if (conn)
            {
                ThreadStart(Send);
            }
        }
        private void Button_State(System.Windows.Forms.Button button, int state)
        {
            if(state == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button1.BackColor = SystemColors.Control;
                button2.BackColor = SystemColors.Control;
                this.ActiveControl = button_AOSetting;
            }
            else//state ==2
            {
                button5.Enabled = true;
                button6.Enabled = true;
                button5.BackColor = SystemColors.Control;
                button6.BackColor = SystemColors.Control;
                this.ActiveControl = button_AIRequest;
            }
            button.Enabled = false;
            button.BackColor = Color.AliceBlue;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elecin_ch = 0;
            Button_State(button5,2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            elecin_ch = 1;
            Button_State(button6,2);
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fntTab;
            Brush bshBack;
            Brush bshFore;
            if (e.Index == tabControl.SelectedIndex)
            {
                fntTab = new Font(e.Font, FontStyle.Bold);
                bshBack = new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, SystemColors.Control, SystemColors.Control, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal);
                bshFore = Brushes.Black;
            }
            else
            {
                fntTab = e.Font;
                bshBack = new SolidBrush(SystemColors.Control);
                bshFore = new SolidBrush(Color.Black);
            }
            string tabName = this.tabControl.TabPages[e.Index].Text;
            StringFormat sftTab = new StringFormat(StringFormatFlags.NoClip);        
            sftTab.Alignment = StringAlignment.Center;
            sftTab.LineAlignment = StringAlignment.Center;
            e.Graphics.FillRectangle(bshBack, e.Bounds);
            Rectangle recTab = e.Bounds;
            recTab = new Rectangle(recTab.X, recTab.Y + 4, recTab.Width, recTab.Height - 4);
            e.Graphics.DrawString(tabName, fntTab, bshFore, recTab, sftTab);
        }
    }
}
