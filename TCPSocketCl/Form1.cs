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
        //bool conn = false;
        public static bool clickFlag = false;
        private static int IP1 = 0;
        private static int IP2 = 0;
        private static int IP3 = 0;
        private static int IP4 = 0;
        private static int PORT = 5000;
        private static int data = 0;
        private static int aout_ch = 0;
        private static int ain_ch = 0;
        private static int dout_ch = 0;
        private static int sensorID = 0;
        private static string IP = string.Empty;
        private static string q_ip1 = string.Empty;
        private static string q_ip2 = string.Empty;
        private static string q_ip3 = string.Empty;
        private static string q_ip4 = string.Empty;
        private static string q_port = string.Empty;
        private static string strHex = string.Empty;
        //private static string strHexSplit = string.Empty;
        //private static string hex_cksum = string.Empty;
        private static string[] device_judge = new string[2];
        private static string[] logMsg = new string[6] { "전류 출력 설정", "전류 입력 값 요청", "디지털 출력 설정", "전류 출력 응답", "전류 입력 값 응답","디지털 입력 수신" };
        private static string filePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
        private static string DirPath = Directory.GetCurrentDirectory() + @"\Logs";
        // (1) 소켓 객체 생성
        private static List<SocketInfo> socketInfo = new List<SocketInfo>();
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
            //Log2("192.168.0.180:5000");
            //Log2("192.168.0.244:5000");
            //Log2("192.168.0.31:4265");
            device_judge[0] = "RTU";
            device_judge[1] = "SmartPoE";
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            comboBox1.SelectedIndex = 0;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                TboxValue();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("IP, PORT를 입력해주세요");
                return;
            }
            
            int socketCount = socketInfo.Count;
            IP = IP1 + "." + IP2 + "." + IP3 + "." + IP4;
            SocketConnect(IP,PORT);
            ListboxFocus();
            TboxClear();
            String resultIP = "IP:"+IP+", PORT:"+PORT;
            if (socketCount < socketInfo.Count)
            {
                StartThread(socketInfo[socketInfo.Count-1], Recv);
            }
            this.Text = "SocketClient===State==="+resultIP+"(Connected)";
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            SocketDisconnect();
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
                        sw.WriteLine(return_msg);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filePath))
                    {
                        sw.WriteLine(return_msg);
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
            aout_ch = 0;
            Button_State(button1,1);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            aout_ch = 1;
            Button_State(button2,1);
        }
        private void ButtonOSetting_Click(object sender, EventArgs e)
        {
            sensorID = 1;
            try
            {
                data = Convert.ToInt32(comboBox1.Text);
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.index == Convert.ToInt32(listBox_quick.SelectedItem.ToString().Split(')')[0])-1)
                    {
                        if (usedSockInfo.conn)
                        {
                            StartThread(usedSockInfo, Send);
                        }
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
            }
           
        }
        private void Button_AIRequest_Click(object sender, EventArgs e)
        {
            sensorID = 2;
            try
            {
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.index == Convert.ToInt32(listBox_quick.SelectedItem.ToString().Split(')')[0]) - 1)
                    {
                        if (usedSockInfo.conn)
                        {
                            StartThread(usedSockInfo, Send);
                        }
                    }
                }
            }
            catch(NullReferenceException ex)
            {
                MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
            }
            
        }
        private void Button_DOSetting_Click(object sender, EventArgs e)
        {
            sensorID = 4;
            try
            {
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.index == Convert.ToInt32(listBox_quick.SelectedItem.ToString().Split(')')[0]) - 1)
                    {
                        if (usedSockInfo.conn)
                        {
                            StartThread(usedSockInfo, Send);
                        }
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
            }
        }
        private void Button_State(System.Windows.Forms.Button button, int state)
        {
            if(state == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button1.BackColor = System.Drawing.Color.Transparent;
                button2.BackColor = System.Drawing.Color.Transparent;
                this.ActiveControl = button_AOSetting;
            }
            else if(state == 2)
            {
                button3.Enabled = true;
                button4.Enabled = true;
                button3.BackColor = System.Drawing.Color.Transparent;
                button4.BackColor = System.Drawing.Color.Transparent;
                this.ActiveControl = button_AIRequest;
            }
            else if(state == 3)
            {
                button_DO0.Enabled = true;
                button_DO1.Enabled = true;
                button_DO2.Enabled = true;
                button_DO3.Enabled = true;
                button_DO0.BackColor = System.Drawing.Color.Transparent;
                button_DO1.BackColor = System.Drawing.Color.Transparent;
                button_DO2.BackColor = System.Drawing.Color.Transparent;
                button_DO3.BackColor = System.Drawing.Color.Transparent;
            }
            else if(state == 4)
            {
                button_On.Enabled = true;
                button_Off.Enabled = true;
                button_On.BackColor = System.Drawing.Color.Transparent;
                button_Off.BackColor = System.Drawing.Color.Transparent;
            }
            button.Enabled = false;
            button.BackColor = Color.AliceBlue;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ain_ch = 0;
            Button_State(button3,2);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ain_ch = 1;
            Button_State(button4,2);
        }
        private void Button_DO0_Click(object sender, EventArgs e)
        {
            dout_ch = 0;
            Button_State(button_DO0, 3);
        }
        private void Button_DO1_Click(object sender, EventArgs e)
        {
            dout_ch = 1;
            Button_State(button_DO1, 3);
        }
        private void Button_DO2_Click(object sender, EventArgs e)
        {
            dout_ch = 2;
            Button_State(button_DO2, 3);
        }
        private void Button_DO3_Click(object sender, EventArgs e)
        {
            dout_ch = 3;
            Button_State(button_DO3, 3);
        }
        private void Button_On_Click(object sender, EventArgs e)
        {
            data = 1;
            Button_State(button_On, 4);
        }
        private void Button_Off_Click(object sender, EventArgs e)
        {
            data = 0;
            Button_State(button_Off, 4);
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
