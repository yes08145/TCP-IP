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
            this.listBox_quick = new System.Windows.Forms.ListBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
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
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(18, 128);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(180, 26);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_disconnect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_disconnect.Location = new System.Drawing.Point(10, 128);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(133, 26);
            this.btn_disconnect.TabIndex = 14;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // listbox1
            // 
            this.listbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.HorizontalScrollbar = true;
            this.listbox1.ItemHeight = 15;
            this.listbox1.Location = new System.Drawing.Point(12, 191);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(1060, 634);
            this.listbox1.TabIndex = 17;
            // 
            // btn_textClear
            // 
            this.btn_textClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_textClear.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_textClear.Location = new System.Drawing.Point(988, 162);
            this.btn_textClear.Name = "btn_textClear";
            this.btn_textClear.Size = new System.Drawing.Size(84, 23);
            this.btn_textClear.TabIndex = 18;
            this.btn_textClear.Text = "Text Clear";
            this.btn_textClear.UseVisualStyleBackColor = true;
            this.btn_textClear.Click += new System.EventHandler(this.btn_textClear_Click);
            // 
            // listBox_quick
            // 
            this.listBox_quick.DisplayMember = "dd";
            this.listBox_quick.FormattingEnabled = true;
            this.listBox_quick.ItemHeight = 12;
            this.listBox_quick.Location = new System.Drawing.Point(10, 20);
            this.listBox_quick.Name = "listBox_quick";
            this.listBox_quick.Size = new System.Drawing.Size(133, 100);
            this.listBox_quick.TabIndex = 19;
            this.listBox_quick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_quick_MouseClick);
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
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(385, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(417, 174);
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
            this.tabPage1.Size = new System.Drawing.Size(409, 148);
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
            this.groupBox2.Location = new System.Drawing.Point(214, 18);
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
            this.groupBox1.Location = new System.Drawing.Point(6, 18);
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
            this.tabPage2.Size = new System.Drawing.Size(409, 148);
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
            this.groupBox3.Location = new System.Drawing.Point(16, 18);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(409, 148);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RS232";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.listBox_quick);
            this.groupBox4.Controls.Add(this.btn_disconnect);
            this.groupBox4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(227, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 160);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Connected";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn_textClear);
            this.Controls.Add(this.listbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(920, 600);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ListBox listBox_quick;
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
        private System.Windows.Forms.TabPage tabPage3;
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
    }
}