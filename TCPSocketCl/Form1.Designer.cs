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
            this.listbox1 = new System.Windows.Forms.ListBox();
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
            this.btn_disconnect = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
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
            this.check_splitbuf = new System.Windows.Forms.CheckBox();
            this.check_realbuf = new System.Windows.Forms.CheckBox();
            this.check_rtext = new System.Windows.Forms.CheckBox();
            this.check_sendbuf = new System.Windows.Forms.CheckBox();
            this.check_stext = new System.Windows.Forms.CheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.btn_textClear = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbox1
            // 
            this.listbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox1.BackColor = System.Drawing.SystemColors.Window;
            this.listbox1.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.HorizontalScrollbar = true;
            this.listbox1.ItemHeight = 15;
            this.listbox1.Location = new System.Drawing.Point(12, 236);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(1060, 589);
            this.listbox1.TabIndex = 17;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.btn_disconnect);
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
            this.label8.TabIndex = 50;
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
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(10, 128);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(133, 23);
            this.btn_disconnect.TabIndex = 48;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseSelectable = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.textBox_Port);
            this.groupBox5.Controls.Add(this.textBox_IP4);
            this.groupBox5.Controls.Add(this.textBox_IP3);
            this.groupBox5.Controls.Add(this.textBox_IP2);
            this.groupBox5.Controls.Add(this.textBox_IP1);
            this.groupBox5.Controls.Add(this.metroLabel4);
            this.groupBox5.Controls.Add(this.btn_connect);
            this.groupBox5.Controls.Add(this.metroLabel3);
            this.groupBox5.Controls.Add(this.metroLabel7);
            this.groupBox5.Controls.Add(this.metroLabel5);
            this.groupBox5.Controls.Add(this.metroLabel6);
            this.groupBox5.Font = new System.Drawing.Font("돋움체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox5.Location = new System.Drawing.Point(12, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 160);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Network Setting";
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
            this.textBox_Port.Location = new System.Drawing.Point(76, 71);
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
            this.textBox_IP4.Location = new System.Drawing.Point(172, 35);
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
            this.textBox_IP3.Location = new System.Drawing.Point(140, 35);
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
            this.textBox_IP2.Location = new System.Drawing.Point(108, 35);
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
            this.textBox_IP1.Location = new System.Drawing.Point(76, 35);
            this.textBox_IP1.MaxLength = 3;
            this.textBox_IP1.Name = "textBox_IP1";
            this.textBox_IP1.PasswordChar = '\0';
            this.textBox_IP1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_IP1.SelectedText = "";
            this.textBox_IP1.SelectionLength = 0;
            this.textBox_IP1.SelectionStart = 0;
            this.textBox_IP1.ShortcutsEnabled = true;
            this.textBox_IP1.Size = new System.Drawing.Size(26, 23);
            this.textBox_IP1.TabIndex = 1;
            this.textBox_IP1.UseSelectable = true;
            this.textBox_IP1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox_IP1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textBox_IP1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP1_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 71);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 19);
            this.metroLabel4.TabIndex = 48;
            this.metroLabel4.Text = "PORT :";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(18, 128);
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
            this.metroLabel3.Location = new System.Drawing.Point(18, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "IP      :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(163, 40);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(12, 19);
            this.metroLabel7.TabIndex = 53;
            this.metroLabel7.Text = ".";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(131, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(12, 19);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = ".";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(99, 39);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(12, 19);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = ".";
            // 
            // check_splitbuf
            // 
            this.check_splitbuf.AutoSize = true;
            this.check_splitbuf.Checked = true;
            this.check_splitbuf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_splitbuf.Location = new System.Drawing.Point(3, 61);
            this.check_splitbuf.Name = "check_splitbuf";
            this.check_splitbuf.Size = new System.Drawing.Size(98, 16);
            this.check_splitbuf.TabIndex = 2;
            this.check_splitbuf.Text = "Divided Hexa";
            this.check_splitbuf.UseVisualStyleBackColor = true;
            this.check_splitbuf.CheckedChanged += new System.EventHandler(this.check_splitbuf_CheckedChanged);
            // 
            // check_realbuf
            // 
            this.check_realbuf.AutoSize = true;
            this.check_realbuf.Location = new System.Drawing.Point(3, 39);
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
            this.check_rtext.Location = new System.Drawing.Point(3, 17);
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
            this.check_sendbuf.Location = new System.Drawing.Point(3, 39);
            this.check_sendbuf.Name = "check_sendbuf";
            this.check_sendbuf.Size = new System.Drawing.Size(53, 16);
            this.check_sendbuf.TabIndex = 1;
            this.check_sendbuf.Text = "Hexa";
            this.check_sendbuf.UseVisualStyleBackColor = true;
            this.check_sendbuf.CheckedChanged += new System.EventHandler(this.check_sendbuf_CheckedChanged);
            // 
            // check_stext
            // 
            this.check_stext.AutoSize = true;
            this.check_stext.Checked = true;
            this.check_stext.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_stext.Location = new System.Drawing.Point(3, 17);
            this.check_stext.Name = "check_stext";
            this.check_stext.Size = new System.Drawing.Size(52, 16);
            this.check_stext.TabIndex = 0;
            this.check_stext.Text = "State";
            this.check_stext.UseVisualStyleBackColor = true;
            this.check_stext.CheckedChanged += new System.EventHandler(this.check_stext_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 200);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(122, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "송신 문자열 표시 :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(385, 200);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 19);
            this.metroLabel2.TabIndex = 42;
            this.metroLabel2.Text = "수신 문자열 표시 :";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(152, 203);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(62, 15);
            this.metroCheckBox1.TabIndex = 43;
            this.metroCheckBox1.Text = "Parsing";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(237, 203);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(44, 15);
            this.metroCheckBox2.TabIndex = 44;
            this.metroCheckBox2.Text = "Hex";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(522, 203);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(62, 15);
            this.metroCheckBox3.TabIndex = 45;
            this.metroCheckBox3.Text = "Parsing";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(603, 203);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(44, 15);
            this.metroCheckBox4.TabIndex = 46;
            this.metroCheckBox4.Text = "Hex";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // btn_textClear
            // 
            this.btn_textClear.Location = new System.Drawing.Point(956, 203);
            this.btn_textClear.Name = "btn_textClear";
            this.btn_textClear.Size = new System.Drawing.Size(116, 23);
            this.btn_textClear.TabIndex = 43;
            this.btn_textClear.Text = "Text Clear";
            this.btn_textClear.UseSelectable = true;
            this.btn_textClear.Click += new System.EventHandler(this.btn_textClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1100, 861);
            this.Controls.Add(this.btn_textClear);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.listbox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listbox1;
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
        private System.Windows.Forms.CheckBox check_realbuf;
        private System.Windows.Forms.CheckBox check_rtext;
        private System.Windows.Forms.CheckBox check_splitbuf;
        private System.Windows.Forms.CheckBox check_sendbuf;
        private System.Windows.Forms.CheckBox check_stext;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroButton btn_textClear;
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
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}