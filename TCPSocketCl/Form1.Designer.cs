﻿namespace TCPSocketCl
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.임시ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listbox1 = new System.Windows.Forms.ListBox();
            this.btn_textClear = new System.Windows.Forms.Button();
            this.listBox_quick = new System.Windows.Forms.ListBox();
            this.btn_quick = new System.Windows.Forms.Button();
            this.textbox_Aoutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button_AIRequest = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_AOSetting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Ainput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_IP1
            // 
            this.textBox_IP1.Location = new System.Drawing.Point(86, 40);
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
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PORT :";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(85, 89);
            this.textBox_Port.MaxLength = 5;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(123, 21);
            this.textBox_Port.TabIndex = 4;
            this.textBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Port_KeyPress);
            // 
            // textBox_IP2
            // 
            this.textBox_IP2.Location = new System.Drawing.Point(118, 40);
            this.textBox_IP2.MaxLength = 3;
            this.textBox_IP2.Name = "textBox_IP2";
            this.textBox_IP2.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP2.TabIndex = 1;
            this.textBox_IP2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP2_KeyPress);
            // 
            // textBox_IP3
            // 
            this.textBox_IP3.Location = new System.Drawing.Point(150, 40);
            this.textBox_IP3.MaxLength = 3;
            this.textBox_IP3.Name = "textBox_IP3";
            this.textBox_IP3.Size = new System.Drawing.Size(26, 21);
            this.textBox_IP3.TabIndex = 2;
            this.textBox_IP3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IP3_KeyPress);
            // 
            // textBox_IP4
            // 
            this.textBox_IP4.Location = new System.Drawing.Point(182, 40);
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
            this.label3.Location = new System.Drawing.Point(112, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(144, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(176, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(9, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_connect.Location = new System.Drawing.Point(28, 128);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(180, 26);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_disconnect.Location = new System.Drawing.Point(28, 160);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(180, 26);
            this.btn_disconnect.TabIndex = 14;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.임시ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.ShortcutKeyDisplayString = "F4";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 임시ToolStripMenuItem
            // 
            this.임시ToolStripMenuItem.Name = "임시ToolStripMenuItem";
            this.임시ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.임시ToolStripMenuItem.Text = "퀵 메뉴 추가";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // listbox1
            // 
            this.listbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox1.FormattingEnabled = true;
            this.listbox1.HorizontalScrollbar = true;
            this.listbox1.ItemHeight = 12;
            this.listbox1.Location = new System.Drawing.Point(12, 191);
            this.listbox1.Name = "listbox1";
            this.listbox1.Size = new System.Drawing.Size(960, 340);
            this.listbox1.TabIndex = 17;
            // 
            // btn_textClear
            // 
            this.btn_textClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_textClear.Location = new System.Drawing.Point(888, 162);
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
            this.listBox_quick.Location = new System.Drawing.Point(527, 37);
            this.listBox_quick.Name = "listBox_quick";
            this.listBox_quick.Size = new System.Drawing.Size(200, 112);
            this.listBox_quick.TabIndex = 19;
            this.listBox_quick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_quick_MouseClick);
            // 
            // btn_quick
            // 
            this.btn_quick.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_quick.Location = new System.Drawing.Point(527, 159);
            this.btn_quick.Name = "btn_quick";
            this.btn_quick.Size = new System.Drawing.Size(200, 26);
            this.btn_quick.TabIndex = 20;
            this.btn_quick.Text = "Select IP/PORT";
            this.btn_quick.UseVisualStyleBackColor = true;
            this.btn_quick.Click += new System.EventHandler(this.btn_quick_Click);
            // 
            // textbox_Aoutput
            // 
            this.textbox_Aoutput.Location = new System.Drawing.Point(365, 38);
            this.textbox_Aoutput.MaxLength = 5;
            this.textbox_Aoutput.Name = "textbox_Aoutput";
            this.textbox_Aoutput.Size = new System.Drawing.Size(20, 21);
            this.textbox_Aoutput.TabIndex = 21;
            this.textbox_Aoutput.Text = "4";
            this.textbox_Aoutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Aoutput_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(423, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 26);
            this.button1.TabIndex = 22;
            this.button1.Text = "ch 0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(285, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "전류출력 :";
            // 
            // button_AIRequest
            // 
            this.button_AIRequest.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AIRequest.Location = new System.Drawing.Point(389, 107);
            this.button_AIRequest.Name = "button_AIRequest";
            this.button_AIRequest.Size = new System.Drawing.Size(129, 26);
            this.button_AIRequest.TabIndex = 26;
            this.button_AIRequest.Text = "전류 입력 값 요청";
            this.button_AIRequest.UseVisualStyleBackColor = true;
            this.button_AIRequest.Click += new System.EventHandler(this.Button_AIRequest_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(386, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "mA";
            // 
            // button_AOSetting
            // 
            this.button_AOSetting.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AOSetting.Location = new System.Drawing.Point(305, 65);
            this.button_AOSetting.Name = "button_AOSetting";
            this.button_AOSetting.Size = new System.Drawing.Size(197, 26);
            this.button_AOSetting.TabIndex = 29;
            this.button_AOSetting.Text = "전류 출력 설정";
            this.button_AOSetting.UseVisualStyleBackColor = true;
            this.button_AOSetting.Click += new System.EventHandler(this.ButtonOSetting_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(474, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "ch 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(285, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = "ch 0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(336, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 26);
            this.button4.TabIndex = 32;
            this.button4.Text = "ch 1";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(285, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "전류입력 :";
            // 
            // textBox_Ainput
            // 
            this.textBox_Ainput.Location = new System.Drawing.Point(365, 135);
            this.textBox_Ainput.MaxLength = 5;
            this.textBox_Ainput.Name = "textBox_Ainput";
            this.textBox_Ainput.Size = new System.Drawing.Size(20, 21);
            this.textBox_Ainput.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(386, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "mA";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(423, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 26);
            this.button5.TabIndex = 36;
            this.button5.Text = "ch 0";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(474, 136);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 26);
            this.button6.TabIndex = 37;
            this.button6.Text = "ch 1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Ainput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_AOSetting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_AIRequest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textbox_Aoutput);
            this.Controls.Add(this.btn_quick);
            this.Controls.Add(this.listBox_quick);
            this.Controls.Add(this.btn_textClear);
            this.Controls.Add(this.listbox1);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.textBox_IP4);
            this.Controls.Add(this.textBox_IP3);
            this.Controls.Add(this.textBox_IP2);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_IP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SocketClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 임시ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ListBox listbox1;
        private System.Windows.Forms.Button btn_textClear;
        private System.Windows.Forms.ListBox listBox_quick;
        private System.Windows.Forms.Button btn_quick;
        private System.Windows.Forms.TextBox textbox_Aoutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_AIRequest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_AOSetting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Ainput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}