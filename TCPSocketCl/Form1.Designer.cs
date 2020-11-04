namespace TCPSocketCl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label8 = new System.Windows.Forms.Label();
            this.btn_disconnect = new MetroFramework.Controls.MetroButton();
            this.textBox_Port = new MetroFramework.Controls.MetroTextBox();
            this.textBox_IP4 = new MetroFramework.Controls.MetroTextBox();
            this.textBox_IP3 = new MetroFramework.Controls.MetroTextBox();
            this.textBox_IP2 = new MetroFramework.Controls.MetroTextBox();
            this.textBox_IP1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btn_connect = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.check_stext = new MetroFramework.Controls.MetroCheckBox();
            this.check_sendbuf = new MetroFramework.Controls.MetroCheckBox();
            this.check_rtext = new MetroFramework.Controls.MetroCheckBox();
            this.check_splitbuf = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgv_constate = new MetroFramework.Controls.MetroGrid();
            this.metroTabControl_d = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_d = new System.Windows.Forms.TabPage();
            this.btn_send_d = new MetroFramework.Controls.MetroButton();
            this.toggle_ch3_d = new MetroFramework.Controls.MetroToggle();
            this.btn_ch3_d = new MetroFramework.Controls.MetroButton();
            this.toggle_ch2_d = new MetroFramework.Controls.MetroToggle();
            this.btn_ch2_d = new MetroFramework.Controls.MetroButton();
            this.toggle_ch1_d = new MetroFramework.Controls.MetroToggle();
            this.btn_ch1_d = new MetroFramework.Controls.MetroButton();
            this.toggle_ch0_d = new MetroFramework.Controls.MetroToggle();
            this.btn_ch0_d = new MetroFramework.Controls.MetroButton();
            this.label_ch3_d = new MetroFramework.Controls.MetroLabel();
            this.labal_ch2_d = new MetroFramework.Controls.MetroLabel();
            this.label_ch1_d = new MetroFramework.Controls.MetroLabel();
            this.label_ch0_d = new MetroFramework.Controls.MetroLabel();
            this.led_ch3_d = new MetroFramework.Controls.MetroButton();
            this.led_ch2_d = new MetroFramework.Controls.MetroButton();
            this.led_ch1_d = new MetroFramework.Controls.MetroButton();
            this.led_ch0_d = new MetroFramework.Controls.MetroButton();
            this.label_input_d = new MetroFramework.Controls.MetroLabel();
            this.label_output_d = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_constate)).BeginInit();
            this.metroTabControl_d.SuspendLayout();
            this.tabPage_d.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("굴림", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 86);
            this.label8.TabIndex = 50;
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(3, 106);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(133, 23);
            this.btn_disconnect.TabIndex = 48;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseSelectable = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // textBox_Port
            // 
            // 
            // 
            // 
            this.textBox_Port.CustomButton.Image = null;
            this.textBox_Port.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.textBox_Port.CustomButton.Name = "";
            this.textBox_Port.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_Port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_Port.CustomButton.TabIndex = 1;
            this.textBox_Port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_Port.CustomButton.UseSelectable = true;
            this.textBox_Port.CustomButton.Visible = false;
            this.textBox_Port.Lines = new string[0];
            this.textBox_Port.Location = new System.Drawing.Point(61, 48);
            this.textBox_Port.MaxLength = 5;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.PasswordChar = '\0';
            this.textBox_Port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_Port.SelectedText = "";
            this.textBox_Port.SelectionLength = 0;
            this.textBox_Port.SelectionStart = 0;
            this.textBox_Port.ShortcutsEnabled = true;
            this.textBox_Port.Size = new System.Drawing.Size(122, 23);
            this.textBox_Port.TabIndex = 5;
            this.textBox_Port.UseSelectable = true;
            this.textBox_Port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_Port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Port_KeyPress);
            // 
            // textBox_IP4
            // 
            // 
            // 
            // 
            this.textBox_IP4.CustomButton.Image = null;
            this.textBox_IP4.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.textBox_IP4.CustomButton.Name = "";
            this.textBox_IP4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_IP4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_IP4.CustomButton.TabIndex = 1;
            this.textBox_IP4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_IP4.CustomButton.UseSelectable = true;
            this.textBox_IP4.CustomButton.Visible = false;
            this.textBox_IP4.Lines = new string[0];
            this.textBox_IP4.Location = new System.Drawing.Point(157, 12);
            this.textBox_IP4.MaxLength = 3;
            this.textBox_IP4.Name = "textBox_IP4";
            this.textBox_IP4.PasswordChar = '\0';
            this.textBox_IP4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_IP4.SelectedText = "";
            this.textBox_IP4.SelectionLength = 0;
            this.textBox_IP4.SelectionStart = 0;
            this.textBox_IP4.ShortcutsEnabled = true;
            this.textBox_IP4.Size = new System.Drawing.Size(26, 23);
            this.textBox_IP4.TabIndex = 4;
            this.textBox_IP4.UseSelectable = true;
            this.textBox_IP4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_IP4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_IP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP4_KeyPress);
            // 
            // textBox_IP3
            // 
            // 
            // 
            // 
            this.textBox_IP3.CustomButton.Image = null;
            this.textBox_IP3.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.textBox_IP3.CustomButton.Name = "";
            this.textBox_IP3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_IP3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_IP3.CustomButton.TabIndex = 1;
            this.textBox_IP3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_IP3.CustomButton.UseSelectable = true;
            this.textBox_IP3.CustomButton.Visible = false;
            this.textBox_IP3.Lines = new string[0];
            this.textBox_IP3.Location = new System.Drawing.Point(125, 12);
            this.textBox_IP3.MaxLength = 3;
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.PasswordChar = '\0';
            this.textBox_IP3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_IP3.SelectedText = "";
            this.textBox_IP3.SelectionLength = 0;
            this.textBox_IP3.SelectionStart = 0;
            this.textBox_IP3.ShortcutsEnabled = true;
            this.textBox_IP3.Size = new System.Drawing.Size(26, 23);
            this.textBox_IP3.TabIndex = 3;
            this.textBox_IP3.UseSelectable = true;
            this.textBox_IP3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_IP3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_IP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP3_KeyPress);
            // 
            // textBox_IP2
            // 
            // 
            // 
            // 
            this.textBox_IP2.CustomButton.Image = null;
            this.textBox_IP2.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.textBox_IP2.CustomButton.Name = "";
            this.textBox_IP2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_IP2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_IP2.CustomButton.TabIndex = 1;
            this.textBox_IP2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_IP2.CustomButton.UseSelectable = true;
            this.textBox_IP2.CustomButton.Visible = false;
            this.textBox_IP2.Lines = new string[0];
            this.textBox_IP2.Location = new System.Drawing.Point(93, 12);
            this.textBox_IP2.MaxLength = 3;
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.PasswordChar = '\0';
            this.textBox_IP2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_IP2.SelectedText = "";
            this.textBox_IP2.SelectionLength = 0;
            this.textBox_IP2.SelectionStart = 0;
            this.textBox_IP2.ShortcutsEnabled = true;
            this.textBox_IP2.Size = new System.Drawing.Size(26, 23);
            this.textBox_IP2.TabIndex = 2;
            this.textBox_IP2.UseSelectable = true;
            this.textBox_IP2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_IP2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_IP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP2_KeyPress);
            // 
            // textBox_IP1
            // 
            // 
            // 
            // 
            this.textBox_IP1.CustomButton.Image = null;
            this.textBox_IP1.CustomButton.Location = new System.Drawing.Point(4, 1);
            this.textBox_IP1.CustomButton.Name = "";
            this.textBox_IP1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox_IP1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox_IP1.CustomButton.TabIndex = 1;
            this.textBox_IP1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox_IP1.CustomButton.UseSelectable = true;
            this.textBox_IP1.CustomButton.Visible = false;
            this.textBox_IP1.Lines = new string[0];
            this.textBox_IP1.Location = new System.Drawing.Point(61, 12);
            this.textBox_IP1.MaxLength = 3;
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.PasswordChar = '\0';
            this.textBox_IP1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_IP1.SelectedText = "";
            this.textBox_IP1.SelectionLength = 0;
            this.textBox_IP1.SelectionStart = 0;
            this.textBox_IP1.ShortcutsEnabled = true;
            this.textBox_IP1.Size = new System.Drawing.Size(26, 23);
            this.textBox_IP1.TabIndex = 0;
            this.textBox_IP1.UseSelectable = true;
            this.textBox_IP1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_IP1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_IP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP1_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(3, 48);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "PORT :";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.White;
            this.btn_connect.ForeColor = System.Drawing.Color.Black;
            this.btn_connect.Location = new System.Drawing.Point(3, 106);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(180, 23);
            this.btn_connect.TabIndex = 48;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseSelectable = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(3, 12);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "IP      :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(148, 17);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.TabIndex = 53;
            this.metroLabel7.Text = ".";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(116, 17);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(12, 19);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = ".";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(84, 16);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(12, 19);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = ".";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroLabel1.TabIndex = 47;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 207);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "수신 문자열 표시 :";
            // 
            // check_stext
            // 
            this.check_stext.AutoSize = true;
            this.check_stext.Checked = true;
            this.check_stext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_stext.Location = new System.Drawing.Point(152, 210);
            this.check_stext.Name = "check_stext";
            this.check_stext.Size = new System.Drawing.Size(62, 15);
            this.check_stext.TabIndex = 43;
            this.check_stext.Text = "Parsing";
            this.check_stext.UseSelectable = true;
            this.check_stext.CheckedChanged += new System.EventHandler(this.check_stext_CheckedChanged);
            // 
            // check_sendbuf
            // 
            this.check_sendbuf.AutoSize = true;
            this.check_sendbuf.Location = new System.Drawing.Point(237, 210);
            this.check_sendbuf.Name = "check_sendbuf";
            this.check_sendbuf.Size = new System.Drawing.Size(44, 15);
            this.check_sendbuf.TabIndex = 44;
            this.check_sendbuf.Text = "Hex";
            this.check_sendbuf.UseSelectable = true;
            this.check_sendbuf.CheckedChanged += new System.EventHandler(this.check_sendbuf_CheckedChanged);
            // 
            // check_rtext
            // 
            this.check_rtext.AutoSize = true;
            this.check_rtext.Checked = true;
            this.check_rtext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rtext.Location = new System.Drawing.Point(522, 210);
            this.check_rtext.Name = "check_rtext";
            this.check_rtext.Size = new System.Drawing.Size(62, 15);
            this.check_rtext.TabIndex = 45;
            this.check_rtext.Text = "Parsing";
            this.check_rtext.UseSelectable = true;
            this.check_rtext.CheckedChanged += new System.EventHandler(this.check_text_CheckedChanged);
            // 
            // check_splitbuf
            // 
            this.check_splitbuf.AutoSize = true;
            this.check_splitbuf.Location = new System.Drawing.Point(603, 210);
            this.check_splitbuf.Name = "check_splitbuf";
            this.check_splitbuf.Size = new System.Drawing.Size(44, 15);
            this.check_splitbuf.TabIndex = 46;
            this.check_splitbuf.Text = "Hex";
            this.check_splitbuf.UseSelectable = true;
            this.check_splitbuf.CheckedChanged += new System.EventHandler(this.check_splitbuf_CheckedChanged);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 207);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(122, 19);
            this.metroLabel8.TabIndex = 48;
            this.metroLabel8.Text = "송신 문자열 표시 :";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(17, 10);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(204, 185);
            this.metroTabControl1.TabIndex = 50;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.textBox_Port);
            this.metroTabPage1.Controls.Add(this.textBox_IP4);
            this.metroTabPage1.Controls.Add(this.textBox_IP3);
            this.metroTabPage1.Controls.Add(this.textBox_IP2);
            this.metroTabPage1.Controls.Add(this.textBox_IP1);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.btn_connect);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(196, 143);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Network Setting";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Location = new System.Drawing.Point(227, 10);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(152, 185);
            this.metroTabControl2.TabIndex = 51;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.label8);
            this.metroTabPage2.Controls.Add(this.btn_disconnect);
            this.metroTabPage2.Controls.Add(this.dgv_constate);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(144, 143);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.Text = "Connected";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgv_constate
            // 
            this.dgv_constate.AllowUserToAddRows = false;
            this.dgv_constate.AllowUserToResizeRows = false;
            this.dgv_constate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_constate.BackgroundColor = System.Drawing.Color.White;
            this.dgv_constate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_constate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_constate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_constate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_constate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_constate.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_constate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_constate.EnableHeadersVisualStyles = false;
            this.dgv_constate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_constate.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_constate.Location = new System.Drawing.Point(3, 12);
            this.dgv_constate.MultiSelect = false;
            this.dgv_constate.Name = "dgv_constate";
            this.dgv_constate.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_constate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_constate.RowHeadersWidth = 12;
            this.dgv_constate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_constate.RowTemplate.Height = 23;
            this.dgv_constate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_constate.Size = new System.Drawing.Size(133, 86);
            this.dgv_constate.TabIndex = 52;
            this.dgv_constate.UseCustomForeColor = true;
            this.dgv_constate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_constate_CellDoubleClick);
            this.dgv_constate.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_constate_RowPostPaint);
            // 
            // metroTabControl_d
            // 
            this.metroTabControl_d.Controls.Add(this.tabPage_d);
            this.metroTabControl_d.Location = new System.Drawing.Point(37, 580);
            this.metroTabControl_d.Name = "metroTabControl_d";
            this.metroTabControl_d.SelectedIndex = 0;
            this.metroTabControl_d.Size = new System.Drawing.Size(700, 250);
            this.metroTabControl_d.TabIndex = 52;
            this.metroTabControl_d.UseSelectable = true;
            // 
            // tabPage_d
            // 
            this.tabPage_d.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage_d.Controls.Add(this.btn_send_d);
            this.tabPage_d.Controls.Add(this.toggle_ch3_d);
            this.tabPage_d.Controls.Add(this.btn_ch3_d);
            this.tabPage_d.Controls.Add(this.toggle_ch2_d);
            this.tabPage_d.Controls.Add(this.btn_ch2_d);
            this.tabPage_d.Controls.Add(this.toggle_ch1_d);
            this.tabPage_d.Controls.Add(this.btn_ch1_d);
            this.tabPage_d.Controls.Add(this.toggle_ch0_d);
            this.tabPage_d.Controls.Add(this.btn_ch0_d);
            this.tabPage_d.Controls.Add(this.label_ch3_d);
            this.tabPage_d.Controls.Add(this.labal_ch2_d);
            this.tabPage_d.Controls.Add(this.label_ch1_d);
            this.tabPage_d.Controls.Add(this.label_ch0_d);
            this.tabPage_d.Controls.Add(this.led_ch3_d);
            this.tabPage_d.Controls.Add(this.led_ch2_d);
            this.tabPage_d.Controls.Add(this.led_ch1_d);
            this.tabPage_d.Controls.Add(this.led_ch0_d);
            this.tabPage_d.Controls.Add(this.label_input_d);
            this.tabPage_d.Controls.Add(this.label_output_d);
            this.tabPage_d.Controls.Add(this.metroTile1);
            this.tabPage_d.Location = new System.Drawing.Point(4, 38);
            this.tabPage_d.Name = "tabPage_d";
            this.tabPage_d.Size = new System.Drawing.Size(692, 208);
            this.tabPage_d.TabIndex = 0;
            this.tabPage_d.Text = "Digital";
            // 
            // btn_send_d
            // 
            this.btn_send_d.Location = new System.Drawing.Point(293, 171);
            this.btn_send_d.Name = "btn_send_d";
            this.btn_send_d.Size = new System.Drawing.Size(115, 26);
            this.btn_send_d.TabIndex = 19;
            this.btn_send_d.Text = "Send";
            this.btn_send_d.UseSelectable = true;
            this.btn_send_d.Click += new System.EventHandler(this.Button_DOSetting_Click);
            // 
            // toggle_ch3_d
            // 
            this.toggle_ch3_d.AutoSize = true;
            this.toggle_ch3_d.Location = new System.Drawing.Point(429, 141);
            this.toggle_ch3_d.Name = "toggle_ch3_d";
            this.toggle_ch3_d.Size = new System.Drawing.Size(80, 16);
            this.toggle_ch3_d.TabIndex = 18;
            this.toggle_ch3_d.Text = "Off";
            this.toggle_ch3_d.UseSelectable = true;
            // 
            // btn_ch3_d
            // 
            this.btn_ch3_d.Location = new System.Drawing.Point(470, 100);
            this.btn_ch3_d.Name = "btn_ch3_d";
            this.btn_ch3_d.Size = new System.Drawing.Size(33, 26);
            this.btn_ch3_d.TabIndex = 17;
            this.btn_ch3_d.UseCustomBackColor = true;
            this.btn_ch3_d.UseSelectable = true;
            this.btn_ch3_d.Click += new System.EventHandler(this.Btn_ch3_d_Click);
            // 
            // toggle_ch2_d
            // 
            this.toggle_ch2_d.AutoSize = true;
            this.toggle_ch2_d.Location = new System.Drawing.Point(339, 141);
            this.toggle_ch2_d.Name = "toggle_ch2_d";
            this.toggle_ch2_d.Size = new System.Drawing.Size(80, 16);
            this.toggle_ch2_d.TabIndex = 16;
            this.toggle_ch2_d.Text = "Off";
            this.toggle_ch2_d.UseSelectable = true;
            // 
            // btn_ch2_d
            // 
            this.btn_ch2_d.Location = new System.Drawing.Point(380, 100);
            this.btn_ch2_d.Name = "btn_ch2_d";
            this.btn_ch2_d.Size = new System.Drawing.Size(33, 26);
            this.btn_ch2_d.TabIndex = 15;
            this.btn_ch2_d.UseCustomBackColor = true;
            this.btn_ch2_d.UseSelectable = true;
            this.btn_ch2_d.Click += new System.EventHandler(this.Btn_ch2_d_Click);
            // 
            // toggle_ch1_d
            // 
            this.toggle_ch1_d.AutoSize = true;
            this.toggle_ch1_d.Location = new System.Drawing.Point(249, 141);
            this.toggle_ch1_d.Name = "toggle_ch1_d";
            this.toggle_ch1_d.Size = new System.Drawing.Size(80, 16);
            this.toggle_ch1_d.TabIndex = 14;
            this.toggle_ch1_d.Text = "Off";
            this.toggle_ch1_d.UseSelectable = true;
            // 
            // btn_ch1_d
            // 
            this.btn_ch1_d.Location = new System.Drawing.Point(290, 100);
            this.btn_ch1_d.Name = "btn_ch1_d";
            this.btn_ch1_d.Size = new System.Drawing.Size(33, 26);
            this.btn_ch1_d.TabIndex = 13;
            this.btn_ch1_d.UseCustomBackColor = true;
            this.btn_ch1_d.UseSelectable = true;
            this.btn_ch1_d.Click += new System.EventHandler(this.Btn_ch1_d_Click);
            // 
            // toggle_ch0_d
            // 
            this.toggle_ch0_d.AutoSize = true;
            this.toggle_ch0_d.Location = new System.Drawing.Point(159, 141);
            this.toggle_ch0_d.Name = "toggle_ch0_d";
            this.toggle_ch0_d.Size = new System.Drawing.Size(80, 16);
            this.toggle_ch0_d.TabIndex = 12;
            this.toggle_ch0_d.Text = "Off";
            this.toggle_ch0_d.UseSelectable = true;
            // 
            // btn_ch0_d
            // 
            this.btn_ch0_d.Location = new System.Drawing.Point(200, 100);
            this.btn_ch0_d.Name = "btn_ch0_d";
            this.btn_ch0_d.Size = new System.Drawing.Size(33, 26);
            this.btn_ch0_d.TabIndex = 11;
            this.btn_ch0_d.UseCustomBackColor = true;
            this.btn_ch0_d.UseSelectable = true;
            this.btn_ch0_d.Click += new System.EventHandler(this.Btn_ch0_d_Click);
            // 
            // label_ch3_d
            // 
            this.label_ch3_d.AutoSize = true;
            this.label_ch3_d.Location = new System.Drawing.Point(470, 50);
            this.label_ch3_d.Name = "label_ch3_d";
            this.label_ch3_d.Size = new System.Drawing.Size(33, 19);
            this.label_ch3_d.TabIndex = 10;
            this.label_ch3_d.Text = "ch 3";
            // 
            // labal_ch2_d
            // 
            this.labal_ch2_d.AutoSize = true;
            this.labal_ch2_d.Location = new System.Drawing.Point(380, 50);
            this.labal_ch2_d.Name = "labal_ch2_d";
            this.labal_ch2_d.Size = new System.Drawing.Size(33, 19);
            this.labal_ch2_d.TabIndex = 9;
            this.labal_ch2_d.Text = "ch 2";
            // 
            // label_ch1_d
            // 
            this.label_ch1_d.AutoSize = true;
            this.label_ch1_d.Location = new System.Drawing.Point(290, 50);
            this.label_ch1_d.Name = "label_ch1_d";
            this.label_ch1_d.Size = new System.Drawing.Size(31, 19);
            this.label_ch1_d.TabIndex = 8;
            this.label_ch1_d.Text = "ch 1";
            // 
            // label_ch0_d
            // 
            this.label_ch0_d.AutoSize = true;
            this.label_ch0_d.Location = new System.Drawing.Point(200, 50);
            this.label_ch0_d.Name = "label_ch0_d";
            this.label_ch0_d.Size = new System.Drawing.Size(33, 19);
            this.label_ch0_d.TabIndex = 7;
            this.label_ch0_d.Text = "ch 0";
            // 
            // led_ch3_d
            // 
            this.led_ch3_d.BackColor = System.Drawing.Color.Transparent;
            this.led_ch3_d.Location = new System.Drawing.Point(460, 33);
            this.led_ch3_d.Name = "led_ch3_d";
            this.led_ch3_d.Size = new System.Drawing.Size(53, 8);
            this.led_ch3_d.TabIndex = 6;
            this.led_ch3_d.UseCustomBackColor = true;
            this.led_ch3_d.UseSelectable = true;
            // 
            // led_ch2_d
            // 
            this.led_ch2_d.BackColor = System.Drawing.Color.Transparent;
            this.led_ch2_d.Location = new System.Drawing.Point(370, 33);
            this.led_ch2_d.Name = "led_ch2_d";
            this.led_ch2_d.Size = new System.Drawing.Size(53, 8);
            this.led_ch2_d.TabIndex = 5;
            this.led_ch2_d.UseCustomBackColor = true;
            this.led_ch2_d.UseSelectable = true;
            // 
            // led_ch1_d
            // 
            this.led_ch1_d.BackColor = System.Drawing.Color.Transparent;
            this.led_ch1_d.Location = new System.Drawing.Point(280, 33);
            this.led_ch1_d.Name = "led_ch1_d";
            this.led_ch1_d.Size = new System.Drawing.Size(53, 8);
            this.led_ch1_d.TabIndex = 4;
            this.led_ch1_d.UseCustomBackColor = true;
            this.led_ch1_d.UseSelectable = true;
            // 
            // led_ch0_d
            // 
            this.led_ch0_d.BackColor = System.Drawing.Color.Transparent;
            this.led_ch0_d.Location = new System.Drawing.Point(190, 33);
            this.led_ch0_d.Name = "led_ch0_d";
            this.led_ch0_d.Size = new System.Drawing.Size(53, 8);
            this.led_ch0_d.TabIndex = 3;
            this.led_ch0_d.UseCustomBackColor = true;
            this.led_ch0_d.UseSelectable = true;
            // 
            // label_input_d
            // 
            this.label_input_d.AutoSize = true;
            this.label_input_d.Location = new System.Drawing.Point(14, 96);
            this.label_input_d.Name = "label_input_d";
            this.label_input_d.Size = new System.Drawing.Size(37, 19);
            this.label_input_d.TabIndex = 2;
            this.label_input_d.Text = "입력";
            // 
            // label_output_d
            // 
            this.label_output_d.AutoSize = true;
            this.label_output_d.Location = new System.Drawing.Point(14, 11);
            this.label_output_d.Name = "label_output_d";
            this.label_output_d.Size = new System.Drawing.Size(37, 19);
            this.label_output_d.TabIndex = 1;
            this.label_output_d.Text = "출력";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.metroTile1.Location = new System.Drawing.Point(19, 76);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(651, 2);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.metroTabControl_d);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.check_splitbuf);
            this.Controls.Add(this.check_rtext);
            this.Controls.Add(this.check_sendbuf);
            this.Controls.Add(this.check_stext);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socket Client Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_constate)).EndInit();
            this.metroTabControl_d.ResumeLayout(false);
            this.tabPage_d.ResumeLayout(false);
            this.tabPage_d.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox check_stext;
        private MetroFramework.Controls.MetroCheckBox check_sendbuf;
        private MetroFramework.Controls.MetroCheckBox check_rtext;
        private MetroFramework.Controls.MetroCheckBox check_splitbuf;
        private MetroFramework.Controls.MetroButton btn_disconnect;
        private MetroFramework.Controls.MetroButton btn_connect;
        private MetroFramework.Controls.MetroTextBox textBox_IP4;
        private MetroFramework.Controls.MetroTextBox textBox_IP3;
        private MetroFramework.Controls.MetroTextBox textBox_IP2;
        private MetroFramework.Controls.MetroTextBox textBox_IP1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBox_Port;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid dgv_constate;
        private MetroFramework.Controls.MetroTabControl metroTabControl_d;
        private System.Windows.Forms.TabPage tabPage_d;
        private MetroFramework.Controls.MetroButton btn_send_d;
        private MetroFramework.Controls.MetroToggle toggle_ch3_d;
        private MetroFramework.Controls.MetroButton btn_ch3_d;
        private MetroFramework.Controls.MetroToggle toggle_ch2_d;
        private MetroFramework.Controls.MetroButton btn_ch2_d;
        private MetroFramework.Controls.MetroToggle toggle_ch1_d;
        private MetroFramework.Controls.MetroButton btn_ch1_d;
        private MetroFramework.Controls.MetroToggle toggle_ch0_d;
        private MetroFramework.Controls.MetroButton btn_ch0_d;
        private MetroFramework.Controls.MetroLabel label_ch3_d;
        private MetroFramework.Controls.MetroLabel labal_ch2_d;
        private MetroFramework.Controls.MetroLabel label_ch1_d;
        private MetroFramework.Controls.MetroLabel label_ch0_d;
        private MetroFramework.Controls.MetroButton led_ch3_d;
        private MetroFramework.Controls.MetroButton led_ch2_d;
        private MetroFramework.Controls.MetroButton led_ch1_d;
        private MetroFramework.Controls.MetroButton led_ch0_d;
        private MetroFramework.Controls.MetroLabel label_input_d;
        private MetroFramework.Controls.MetroLabel label_output_d;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}