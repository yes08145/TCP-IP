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
using MetroFramework.Forms;
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
        private static int mAdata = 0;
        private static string IP = string.Empty;
        private static string q_ip1 = string.Empty;
        private static string q_ip2 = string.Empty;
        private static string q_ip3 = string.Empty;
        private static string q_ip4 = string.Empty;
        private static string q_port = string.Empty;
        private static string strHex = string.Empty;
        private static bool led0 = false;
        private static bool led1 = false;
        private static bool led2 = false;
        private static bool led3 = false;
        private static bool r_log_text = true;
        private static bool r_log_realBuff = false;
        private static bool r_log_splitBuff = false;
        private static bool s_log_text = true;
        private static bool s_log_sendBuff = false;
        private static Color customedBlue = Color.FromArgb(0, 174, 219);
        //private static string strHexSplit = string.Empty;
        //private static string hex_cksum = string.Empty;
        private static string[] device_judge = new string[3];
        private static string[] logMsg = new string[6] { "전류 출력 설정", "전류 입력 값 요청", "디지털 출력 설정", "전류 출력 응답", "전류 입력 값 응답","디지털 입력 수신" };
        private static string DirPath = Directory.GetCurrentDirectory() + @"\Logs";
        //private static string filePath = Directory.GetCurrentDirectory() + @"\Logs\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
        private static string filePath = DirPath+ @"\" + DateTime.Today.ToString("yyyyMMdd") + ".log";
        // (1) 소켓 객체 생성
        private static List<SocketInfo> socketInfo = new List<SocketInfo>();
        public delegate void FocusDelegate();
        public delegate void SocketDelegate(object obj);
        public delegate void LogDelegate(string msg);
        //public static SocketClass socketClass = null;
        private static List<string> ipList = new List<string>();
        private static System.Windows.Forms.Timer timer0 = new System.Windows.Forms.Timer();
        private static System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
        private static System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        private static System.Windows.Forms.Timer timer3 = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            device_judge[0] = "Device 오류";
            device_judge[1] = "RTU";
            device_judge[2] = "SmartPoE";

            timer0.Tick += new EventHandler(Timer0_Tick);
            timer0.Interval = 500;

            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 500;

            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Interval = 500;

            timer3.Tick += new EventHandler(Timer3_Tick);
            timer3.Interval = 500;

            this.ActiveControl = textBox_IP1;
        }

        private void Btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                TboxValue();
            }
            catch(FormatException)
            {
                MessageBox.Show("IP, PORT를 입력해주세요");
                return;
            }
            int socketCount = socketInfo.Count;
            IP = IP1 + "." + IP2 + "." + IP3 + "." + IP4;
            SocketConnect(IP,PORT);
            TboxClear();
            String resultIP = "IP:"+IP+", PORT:"+PORT;
            if (socketCount < socketInfo.Count)
            {
                StartThread(socketInfo[socketInfo.Count-1], Recv, "recv");
            }
            
        }

        private void Btn_disconnect_Click(object sender, EventArgs e)
        {
            SocketDisconnect();
        }
        //private void ListboxFocus()
        //{
        //    listbox1.SelectedIndex = listbox1.Items.Count - 1;
        //}

        //public void Log(string msg)
        //{
        //    //SocketClass sc = new SocketClass();
        //    string return_msg = string.Format("[{0}] {1}", DateTime.Now.ToString(), msg);
        //    listbox1.Items.Add(return_msg);
        //    //......
        //    //sc.LogFile(return_msg);       
        //    //DirectoryInfo di = new DirectoryInfo(DirPath);
        //    //FileInfo fi = new FileInfo(filePath);

        //    //try
        //    //{
        //    //    if (di.Exists != true) Directory.CreateDirectory(DirPath);
        //    //    if (fi.Exists != true)
        //    //    {
        //    //        using (StreamWriter sw = new StreamWriter(filePath))
        //    //        {
        //    //            sw.WriteLine(return_msg);
        //    //            sw.Close();
        //    //        }
        //    //    }
        //    //    else
        //    //    {
        //    //        using (StreamWriter sw = File.AppendText(filePath))
        //    //        {
        //    //            sw.WriteLine(return_msg);
        //    //            sw.Close();
        //    //        }
        //    //    }
        //    //}
        //    //catch(Exception e)
        //    //{
                
        //    //}

        //}

        public void Log2(string msg)
        {
            //listBox_quick.Items.Add(string.Format(

            //"{0}", msg

            //));
            ipList.Add(msg);
            dgv_constate.DataSource = ipList.Select(ip => new { Value = ip }).ToList();
        }

        //private void Button_AIRequest_Click(object sender, EventArgs e)
        //{
        //    sensorID = 2;
        //    if (button3.BackColor == Color.LightBlue) ain_ch = 0;
        //    else if (button4.BackColor == Color.LightBlue) ain_ch = 1;
        //    //else ain_ch = 404;
        //    else sensorID = 100;
        //    try
        //    {
        //        foreach (SocketInfo usedSockInfo in socketInfo)
        //        {
        //            if (usedSockInfo.index == dgv_constate.SelectedRows[0].Index)
        //            {
        //                if (usedSockInfo.conn)
        //                {
        //                    StartThread(usedSockInfo, Send, "send");
        //                }
        //            }
        //        }
        //    }
        //    catch(NullReferenceException ex)
        //    {
        //        MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
        //    }
        //    catch (ArgumentOutOfRangeException ex)
        //    {
        //        MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
        //    }

        //}
        //private void Button_DOSetting_Click(object sender, EventArgs e)
        //{
        //    sensorID = 4;
        //    if (button_DO0.BackColor == Color.LightBlue) dout_ch = 0;
        //    else if (button_DO1.BackColor == Color.LightBlue) dout_ch = 1;
        //    else if (button_DO2.BackColor == Color.LightBlue) dout_ch = 2;
        //    else if (button_DO3.BackColor == Color.LightBlue) dout_ch = 3;
        //    //else dout_ch = 404;
        //    else sensorID = 100;

        //}
        private void Button_DOSetting_Click(object sender, EventArgs e)
        {
            sensorID = 4;
            if (btn_ch0_d.BackColor == customedBlue)
            {
                dout_ch = 0;
                if (toggle_ch0_d.Checked)
                {
                    data = 1;
                }
                else
                {
                    data = 0;
                }
            }
            else if (btn_ch1_d.BackColor == customedBlue)
            {
                dout_ch = 1;
                if (toggle_ch1_d.Checked)
                {
                    data = 1;
                }
                else
                {
                    data = 0;
                }
            }
            else if (btn_ch2_d.BackColor == customedBlue)
            {
                dout_ch = 2;
                if (toggle_ch2_d.Checked)
                {
                    data = 1;
                }
                else
                {
                    data = 0;
                }
            }
            else if (btn_ch3_d.BackColor == customedBlue)
            {
                dout_ch = 3;
                if (toggle_ch3_d.Checked)
                {
                    data = 1;
                }
                else
                {
                    data = 0;
                }
            }
            //else dout_ch = 404;
            else
            {
                sensorID = 100;
            }

            try
            {
                foreach (SocketInfo usedSockInfo in socketInfo)
                {
                    if (usedSockInfo.index == dgv_constate.SelectedRows[0].Index)
                    {
                        if (usedSockInfo.conn)
                        {
                            StartThread(usedSockInfo, Send, "send");
                        }
                    }
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("설정 값을 보낼 서버를 선택해주십시오.");
            }
        }
        private void Button_State(System.Windows.Forms.Button button, int state)
        {
            int btn_color = 1;
            if (button.BackColor == customedBlue)
            {
                btn_color = 0;
            }
            if (state == 1)
            {
                //button1.BackColor = System.Drawing.Color.Transparent;
                //button2.BackColor = System.Drawing.Color.Transparent;
                //this.ActiveControl = button_AOSetting;
            }
            else if (state == 2)
            {
                //button3.BackColor = System.Drawing.Color.Transparent;
                //button4.BackColor = System.Drawing.Color.Transparent;
                //this.ActiveControl = button_AIRequest;
            }
            else if (state == 3)
            {
                btn_ch0_d.BackColor = System.Drawing.Color.White;
                btn_ch1_d.BackColor = System.Drawing.Color.White;
                btn_ch2_d.BackColor = System.Drawing.Color.White;
                btn_ch3_d.BackColor = System.Drawing.Color.White;
                metroTabControl_d.Focus();
            }
            if(btn_color == 1)
            {
                button.BackColor = customedBlue;
            }
            
        }

       
        private void Btn_ch0_d_Click(object sender, EventArgs e)
        {
            Button_State(btn_ch0_d, 3);
        }
        private void Btn_ch1_d_Click(object sender, EventArgs e)
        {
            Button_State(btn_ch1_d, 3);
        }
        private void Btn_ch2_d_Click(object sender, EventArgs e)
        {
            Button_State(btn_ch2_d, 3);
        }
        private void Btn_ch3_d_Click(object sender, EventArgs e)
        {
            Button_State(btn_ch3_d, 3);
        }

        private void Dgv_constate_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgv_constate.RowHeadersDefaultCellStyle.ForeColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Near
                };
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 1, e.RowBounds.Location.Y + 3, sf);
            }
        }

        private void Dgv_constate_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgv_constate.Rows[e.RowIndex].Selected = !(this.dgv_constate.Rows[e.RowIndex].Selected);
        }

        private void Btn_output_a_Enter(object sender, EventArgs e)
        {
            // 단추를 누를 때
            //MessageBox.Show("enter");
        }

        private void Btn_output_a_MouseEnter(object sender, EventArgs e)
        {
            //버튼 위로 마우스를 가져올 때
        }

        private void Btn_output_a_MouseUp(object sender, MouseEventArgs e)
        {
            //단추를 누르고 뗄 때
            //MessageBox.Show("mup");
        }
    }
}
