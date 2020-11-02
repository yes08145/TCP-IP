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
            this.textBox_IP1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_IP2 = new System.Windows.Forms.TextBox();
            this.textBox_IP3 = new System.Windows.Forms.TextBox();
            this.textBox_IP4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.btn_textClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_AIRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_AOSetting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_DOSetting = new System.Windows.Forms.Button();
            this.button_Off = new System.Windows.Forms.Button();
            this.button_On = new System.Windows.Forms.Button();
            this.button_DO0 = new System.Windows.Forms.Button();
            this.button_DO1 = new System.Windows.Forms.Button();
            this.button_DO2 = new System.Windows.Forms.Button();
            this.button_DO3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.check_splitbuf = new System.Windows.Forms.CheckBox();
            this.check_realbuf = new System.Windows.Forms.CheckBox();
            this.check_rtext = new System.Windows.Forms.CheckBox();
            this.check_sendbuf = new System.Windows.Forms.CheckBox();
            this.check_stext = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(76, 33);
            this.textBox_IP1.MaxLength = 3;
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP1.TabIndex = 0;
            this.textBox_IP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(15, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT :";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(76, 69);
            this.textBox_Port.MaxLength = 5;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(122, 21);
            this.textBox_Port.TabIndex = 4;
            this.textBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Port_KeyPress);
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(108, 33);
            this.textBox_IP2.MaxLength = 3;
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP2.TabIndex = 1;
            this.textBox_IP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP2_KeyPress);
            // 
            // textBox_IP3
            // 
            this.textBox_IP3.Location = new System.Drawing.Point(140, 33);
            this.textBox_IP3.MaxLength = 3;
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP3.TabIndex = 2;
            this.textBox_IP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP3_KeyPress);
            // 
            // textBox_IP4
            // 
            this.textBox_IP4.Location = new System.Drawing.Point(172, 33);
            this.textBox_IP4.MaxLength = 3;
            this.textBox_IP4.Name = "textBox_IP4";
            this.textBox_IP4.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP4.TabIndex = 3;
            this.textBox_IP4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP4_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(102, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(134, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(166, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(129)))), ((int)(((byte)(219)))));
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(129)))), ((int)(((byte)(219)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.ForeColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(18, 128);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(180, 26);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(129)))), ((int)(((byte)(219)))));
            this.btn_disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(129)))), ((int)(((byte)(219)))));
            this.btn_disconnect.FlatAppearance.BorderSize = 0;
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_disconnect.Location = new System.Drawing.Point(10, 128);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(133, 26);
            this.btn_disconnect.TabIndex = 14;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // listbox1
            // 
            this.listbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox1.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold);
            this.listbox1.FormattingEnabled = true;
            this.listbox1.HorizontalScrollbar = true;
            this.listbox1.ItemHeight = 15;
            this.listbox1.Location = new System.Drawing.Point(12, 230);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(810, 619);
            this.listbox1.TabIndex = 17;
            // 
            // btn_textClear
            // 
            this.btn_textClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_textClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_textClear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_textClear.Location = new System.Drawing.Point(696, 202);
            this.btn_textClear.Name = "btn_textClear";
            this.btn_textClear.Size = new System.Drawing.Size(126, 23);
            this.btn_textClear.TabIndex = 18;
            this.btn_textClear.Text = "Text Clear";
            this.btn_textClear.UseVisualStyleBackColor = true;
            this.btn_textClear.Click += new System.EventHandler(this.btn_textClear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(85, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 21;
            this.button1.TabStop = false;
            this.button1.Text = "ch 0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button_AIRequest
            // 
            this.button_AIRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AIRequest.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AIRequest.Location = new System.Drawing.Point(27, 61);
            this.button_AIRequest.Name = "button_AIRequest";
            this.button_AIRequest.Size = new System.Drawing.Size(128, 26);
            this.button_AIRequest.TabIndex = 37;
            this.button_AIRequest.Text = "전류 입력 값 요청";
            this.button_AIRequest.UseVisualStyleBackColor = true;
            this.button_AIRequest.Click += new System.EventHandler(this.Button_AIRequest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(48, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "mA";
            // 
            // button_AOSetting
            // 
            this.button_AOSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AOSetting.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AOSetting.Location = new System.Drawing.Point(35, 61);
            this.button_AOSetting.Name = "button_AOSetting";
            this.button_AOSetting.Size = new System.Drawing.Size(128, 26);
            this.button_AOSetting.TabIndex = 0;
            this.button_AOSetting.Text = "전류 출력 설정";
            this.button_AOSetting.UseVisualStyleBackColor = true;
            this.button_AOSetting.Click += new System.EventHandler(this.ButtonOSetting_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(136, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 26);
            this.button2.TabIndex = 21;
            this.button2.TabStop = false;
            this.button2.Text = "ch 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(41, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 26);
            this.button3.TabIndex = 36;
            this.button3.Text = "ch 0";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(94, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 26);
            this.button4.TabIndex = 36;
            this.button4.Text = "ch 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(385, 11);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(442, 174);
            this.tabControl.TabIndex = 39;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Analog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_AIRequest);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(230, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 109);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "전류입력";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button_AOSetting);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 109);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "전류출력";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Digital";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button_DOSetting);
            this.groupBox3.Controls.Add(this.button_Off);
            this.groupBox3.Controls.Add(this.button_On);
            this.groupBox3.Controls.Add(this.button_DO0);
            this.groupBox3.Controls.Add(this.button_DO1);
            this.groupBox3.Controls.Add(this.button_DO2);
            this.groupBox3.Controls.Add(this.button_DO3);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(96, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 117);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "신호출력";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(11, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 14);
            this.label6.TabIndex = 40;
            this.label6.Text = "SIGNAL :";
            // 
            // button_DOSetting
            // 
            this.button_DOSetting.BackColor = System.Drawing.Color.Transparent;
            this.button_DOSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DOSetting.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_DOSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DOSetting.Location = new System.Drawing.Point(52, 77);
            this.button_DOSetting.Name = "button_DOSetting";
            this.button_DOSetting.Size = new System.Drawing.Size(128, 26);
            this.button_DOSetting.TabIndex = 26;
            this.button_DOSetting.TabStop = false;
            this.button_DOSetting.Text = "디지털 출력 설정";
            this.button_DOSetting.UseVisualStyleBackColor = false;
            this.button_DOSetting.Click += new System.EventHandler(this.Button_DOSetting_Click);
            // 
            // button_Off
            // 
            this.button_Off.BackColor = System.Drawing.Color.Transparent;
            this.button_Off.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Off.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Off.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Off.Location = new System.Drawing.Point(92, 45);
            this.button_Off.Name = "button_Off";
            this.button_Off.Size = new System.Drawing.Size(47, 26);
            this.button_Off.TabIndex = 25;
            this.button_Off.TabStop = false;
            this.button_Off.Text = "Off";
            this.button_Off.UseVisualStyleBackColor = false;
            this.button_Off.Click += new System.EventHandler(this.Button_Off_Click);
            // 
            // button_On
            // 
            this.button_On.BackColor = System.Drawing.Color.Transparent;
            this.button_On.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_On.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_On.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_On.Location = new System.Drawing.Point(145, 45);
            this.button_On.Name = "button_On";
            this.button_On.Size = new System.Drawing.Size(47, 26);
            this.button_On.TabIndex = 24;
            this.button_On.TabStop = false;
            this.button_On.Text = "On";
            this.button_On.UseVisualStyleBackColor = false;
            this.button_On.Click += new System.EventHandler(this.Button_On_Click);
            // 
            // button_DO0
            // 
            this.button_DO0.BackColor = System.Drawing.Color.Transparent;
            this.button_DO0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DO0.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_DO0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DO0.Location = new System.Drawing.Point(11, 16);
            this.button_DO0.Name = "button_DO0";
            this.button_DO0.Size = new System.Drawing.Size(47, 26);
            this.button_DO0.TabIndex = 23;
            this.button_DO0.TabStop = false;
            this.button_DO0.Text = "ch 0";
            this.button_DO0.UseVisualStyleBackColor = false;
            this.button_DO0.Click += new System.EventHandler(this.Button_DO0_Click);
            // 
            // button_DO1
            // 
            this.button_DO1.BackColor = System.Drawing.Color.Transparent;
            this.button_DO1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DO1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_DO1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DO1.Location = new System.Drawing.Point(64, 16);
            this.button_DO1.Name = "button_DO1";
            this.button_DO1.Size = new System.Drawing.Size(47, 26);
            this.button_DO1.TabIndex = 22;
            this.button_DO1.TabStop = false;
            this.button_DO1.Text = "ch 1";
            this.button_DO1.UseVisualStyleBackColor = false;
            this.button_DO1.Click += new System.EventHandler(this.Button_DO1_Click);
            // 
            // button_DO2
            // 
            this.button_DO2.BackColor = System.Drawing.Color.Transparent;
            this.button_DO2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DO2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_DO2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_DO2.Location = new System.Drawing.Point(117, 16);
            this.button_DO2.Name = "button_DO2";
            this.button_DO2.Size = new System.Drawing.Size(47, 26);
            this.button_DO2.TabIndex = 21;
            this.button_DO2.TabStop = false;
            this.button_DO2.Text = "ch 2";
            this.button_DO2.UseVisualStyleBackColor = false;
            this.button_DO2.Click += new System.EventHandler(this.Button_DO2_Click);
            // 
            // button_DO3
            // 
            this.button_DO3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DO3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_DO3.Location = new System.Drawing.Point(170, 16);
            this.button_DO3.Name = "button_DO3";
            this.button_DO3.Size = new System.Drawing.Size(47, 26);
            this.button_DO3.TabIndex = 21;
            this.button_DO3.TabStop = false;
            this.button_DO3.Text = "ch 3";
            this.button_DO3.UseVisualStyleBackColor = true;
            this.button_DO3.Click += new System.EventHandler(this.Button_DO3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btn_disconnect);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(227, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 160);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connected";
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("굴림", 2.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(23, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 100);
            this.label8.TabIndex = 42;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(10, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 12;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(133, 100);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvRowHeaderPaint);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.textBox_IP1);
            this.groupBox5.Controls.Add(this.textBox_IP2);
            this.groupBox5.Controls.Add(this.textBox_IP3);
            this.groupBox5.Controls.Add(this.textBox_IP4);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btn_connect);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.textBox_Port);
            this.groupBox5.Location = new System.Drawing.Point(12, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 160);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Network Setting";
            // 
            // check_splitbuf
            // 
            this.check_splitbuf.AutoSize = true;
            this.check_splitbuf.Checked = true;
            this.check_splitbuf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_splitbuf.Location = new System.Drawing.Point(144, 16);
            this.check_splitbuf.Name = "check_splitbuf";
            this.check_splitbuf.Size = new System.Drawing.Size(98, 16);
            this.check_splitbuf.TabIndex = 2;
            this.check_splitbuf.Text = "Hexadecimal";
            this.check_splitbuf.UseVisualStyleBackColor = true;
            this.check_splitbuf.CheckedChanged += new System.EventHandler(this.check_splitbuf_CheckedChanged);
            // 
            // check_realbuf
            // 
            this.check_realbuf.AutoSize = true;
            this.check_realbuf.Checked = true;
            this.check_realbuf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_realbuf.Location = new System.Drawing.Point(248, 16);
            this.check_realbuf.Name = "check_realbuf";
            this.check_realbuf.Size = new System.Drawing.Size(82, 16);
            this.check_realbuf.TabIndex = 1;
            this.check_realbuf.Text = "Real Hexa";
            this.check_realbuf.UseVisualStyleBackColor = true;
            this.check_realbuf.CheckedChanged += new System.EventHandler(this.check_realbuf_CheckedChanged);
            // 
            // check_rtext
            // 
            this.check_rtext.AutoSize = true;
            this.check_rtext.Checked = true;
            this.check_rtext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_rtext.Location = new System.Drawing.Point(86, 16);
            this.check_rtext.Name = "check_rtext";
            this.check_rtext.Size = new System.Drawing.Size(52, 16);
            this.check_rtext.TabIndex = 0;
            this.check_rtext.Text = "State";
            this.check_rtext.UseVisualStyleBackColor = true;
            this.check_rtext.CheckedChanged += new System.EventHandler(this.check_text_CheckedChanged);
            // 
            // check_sendbuf
            // 
            this.check_sendbuf.AutoSize = true;
            this.check_sendbuf.Checked = true;
            this.check_sendbuf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_sendbuf.Location = new System.Drawing.Point(144, 16);
            this.check_sendbuf.Name = "check_sendbuf";
            this.check_sendbuf.Size = new System.Drawing.Size(98, 16);
            this.check_sendbuf.TabIndex = 1;
            this.check_sendbuf.Text = "Hexadecimal";
            this.check_sendbuf.UseVisualStyleBackColor = true;
            this.check_sendbuf.CheckedChanged += new System.EventHandler(this.check_sendbuf_CheckedChanged);
            // 
            // check_stext
            // 
            this.check_stext.AutoSize = true;
            this.check_stext.Checked = true;
            this.check_stext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_stext.Location = new System.Drawing.Point(86, 16);
            this.check_stext.Name = "check_stext";
            this.check_stext.Size = new System.Drawing.Size(52, 16);
            this.check_stext.TabIndex = 0;
            this.check_stext.Text = "State";
            this.check_stext.UseVisualStyleBackColor = true;
            this.check_stext.CheckedChanged += new System.EventHandler(this.check_stext_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.check_splitbuf);
            this.panel1.Controls.Add(this.check_rtext);
            this.panel1.Controls.Add(this.check_realbuf);
            this.panel1.Location = new System.Drawing.Point(34, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 40);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(3, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "수신 문자열 :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.check_sendbuf);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.check_stext);
            this.panel2.Location = new System.Drawing.Point(385, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 40);
            this.panel2.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "송신 문자열 :";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(271, 315);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(395, 181);
            this.metroTabControl1.TabIndex = 44;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(402, 182);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Analog";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButton3);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroButton2);
            this.metroTabPage2.Controls.Add(this.metroButton1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(387, 139);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Digital";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(10, 16);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "ch0";
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(76, 57);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "ch0";
            this.metroButton2.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "SIGNAL :";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(138, 102);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "ch0";
            this.metroButton3.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(120, 263);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox1.TabIndex = 43;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 861);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn_textClear);
            this.Controls.Add(this.listbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Socket Client Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_IP1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_IP2;
        private System.Windows.Forms.TextBox textBox_IP3;
        private System.Windows.Forms.TextBox textBox_IP4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button btn_textClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_AIRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_AOSetting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_DO0;
        private System.Windows.Forms.Button button_DO1;
        private System.Windows.Forms.Button button_DO2;
        private System.Windows.Forms.Button button_DO3;
        private System.Windows.Forms.Button button_Off;
        private System.Windows.Forms.Button button_On;
        private System.Windows.Forms.Button button_DOSetting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox check_realbuf;
        private System.Windows.Forms.CheckBox check_rtext;
        private System.Windows.Forms.CheckBox check_splitbuf;
        private System.Windows.Forms.CheckBox check_sendbuf;
        private System.Windows.Forms.CheckBox check_stext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}