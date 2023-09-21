namespace GmodAddonCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            info = new TabPage();
            groupBox3 = new GroupBox();
            comboBox2 = new ComboBox();
            label19 = new Label();
            label15 = new Label();
            label17 = new Label();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            label18 = new Label();
            checkBox6 = new CheckBox();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            option = new TabPage();
            checkBox5 = new CheckBox();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label12 = new Label();
            label11 = new Label();
            textBox8 = new TextBox();
            checkBox4 = new CheckBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            label16 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label14 = new Label();
            label13 = new Label();
            button6 = new Button();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog3 = new OpenFileDialog();
            button5 = new Button();
            openFileDialog4 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            info.SuspendLayout();
            groupBox3.SuspendLayout();
            option.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(377, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\GarrysMod";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 11);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 1;
            label1.Text = "Garry's Mod folder:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(746, 334);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 22);
            button1.TabIndex = 2;
            button1.Text = "Create Template";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(info);
            tabControl1.Controls.Add(option);
            tabControl1.Location = new Point(0, 28);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.MinimumSize = new Size(0, 225);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(870, 301);
            tabControl1.TabIndex = 3;
            // 
            // info
            // 
            info.AutoScroll = true;
            info.Controls.Add(groupBox3);
            info.Controls.Add(label18);
            info.Controls.Add(checkBox6);
            info.Controls.Add(textBox5);
            info.Controls.Add(label6);
            info.Controls.Add(textBox4);
            info.Controls.Add(label5);
            info.Controls.Add(textBox3);
            info.Controls.Add(label4);
            info.Controls.Add(comboBox1);
            info.Controls.Add(label3);
            info.Controls.Add(textBox2);
            info.Controls.Add(label2);
            info.Location = new Point(4, 24);
            info.Margin = new Padding(3, 2, 3, 2);
            info.Name = "info";
            info.Padding = new Padding(3, 2, 3, 2);
            info.Size = new Size(862, 273);
            info.TabIndex = 0;
            info.Text = "Addon Info";
            info.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(comboBox4);
            groupBox3.Controls.Add(comboBox3);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(407, 8);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(371, 92);
            groupBox3.TabIndex = 32;
            groupBox3.TabStop = false;
            groupBox3.Text = "JSON Settings";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ServerContent", "gamemode", "map", "weapon", "vehicle", "npc", "tool", "effects", "model", "entity" });
            comboBox2.Location = new Point(157, 16);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 26;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Silver;
            label19.Location = new Point(172, 72);
            label19.Name = "label19";
            label19.Size = new Size(177, 15);
            label19.TabIndex = 31;
            label19.Text = "(Use null to not use another tag)";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 19);
            label15.Name = "label15";
            label15.Size = new Size(131, 15);
            label15.TabIndex = 25;
            label15.Text = "Addon Type (Required):";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 49);
            label17.Name = "label17";
            label17.Size = new Size(130, 15);
            label17.TabIndex = 27;
            label17.Text = "Addon Tags (Required):";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "null", "fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build" });
            comboBox4.Location = new Point(266, 47);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(96, 23);
            comboBox4.TabIndex = 29;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build" });
            comboBox3.Location = new Point(155, 47);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(96, 23);
            comboBox3.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(254, 212);
            label18.Name = "label18";
            label18.Size = new Size(10, 15);
            label18.TabIndex = 30;
            label18.Text = ",";
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 155);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 19);
            checkBox6.TabIndex = 24;
            checkBox6.Text = "Make .json";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(111, 126);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 23);
            textBox5.TabIndex = 12;
            textBox5.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 128);
            label6.Name = "label6";
            label6.Size = new Size(91, 15);
            label6.TabIndex = 11;
            label6.Text = "Addon Website:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(93, 96);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 10;
            textBox4.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 99);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 9;
            label5.Text = "Addon Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(104, 64);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 8;
            textBox3.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 7;
            label4.Text = "Addon Author:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PVP", "PVE", "RP", "OTHER" });
            comboBox1.Location = new Point(112, 36);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 38);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 5;
            label3.Text = "Addon Category:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 8);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "My Addon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 10);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 2;
            label2.Text = "Addon Title (Required):";
            // 
            // option
            // 
            option.AutoScroll = true;
            option.Controls.Add(checkBox5);
            option.Controls.Add(groupBox2);
            option.Controls.Add(checkBox4);
            option.Controls.Add(groupBox1);
            option.Controls.Add(checkBox3);
            option.Controls.Add(checkBox2);
            option.Controls.Add(checkBox1);
            option.Location = new Point(4, 24);
            option.Margin = new Padding(3, 2, 3, 2);
            option.Name = "option";
            option.Padding = new Padding(3, 2, 3, 2);
            option.Size = new Size(862, 273);
            option.TabIndex = 1;
            option.Text = "Templates and Options";
            option.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(5, 101);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(112, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "Derma Template";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(293, 4);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(234, 96);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Map Options";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(161, 20);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(67, 22);
            button4.TabIndex = 7;
            button4.Text = "Browse..";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 51);
            label12.Name = "label12";
            label12.Size = new Size(174, 30);
            label12.TabIndex = 2;
            label12.Text = "Leave this box empty to use the\r\nexample map";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 22);
            label11.Name = "label11";
            label11.Size = new Size(34, 15);
            label11.TabIndex = 1;
            label11.Text = "Map:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(49, 20);
            textBox8.Margin = new Padding(3, 2, 3, 2);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(110, 23);
            textBox8.TabIndex = 0;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(5, 79);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(99, 19);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Tool Template";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(533, 4);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(238, 334);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gamemode Options";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(5, 305);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(150, 22);
            button3.TabIndex = 23;
            button3.Text = "Browse..";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(9, 284);
            label16.Name = "label16";
            label16.Size = new Size(93, 15);
            label16.TabIndex = 22;
            label16.Text = "Max size: 32x32";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 269);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 21;
            label7.Text = "Small Icon";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.ErrorImage = null;
            pictureBox2.InitialImage = null;
            pictureBox2.Location = new Point(161, 269);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(72, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(63, 217);
            label14.Name = "label14";
            label14.Size = new Size(110, 15);
            label14.TabIndex = 19;
            label14.Text = "Max size: 128x1024";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(7, 110);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 18;
            label13.Text = "Gamemode Title Icon";
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(5, 234);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(228, 22);
            button6.TabIndex = 5;
            button6.Text = "Browse..";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 48);
            label10.Name = "label10";
            label10.Size = new Size(155, 15);
            label10.TabIndex = 17;
            label10.Text = "Ex: \"gm_\" = \"gm_construct\"";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.ErrorImage = null;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(5, 127);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(7, 68);
            label9.Name = "label9";
            label9.Size = new Size(200, 30);
            label9.TabIndex = 16;
            label9.Text = "Use \"*\" if the maps are not unique to\r\nthe gamemode";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(81, 22);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(91, 23);
            textBox7.TabIndex = 15;
            textBox7.Text = "gatc_";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 22);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 14;
            label8.Text = "Map Filter:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(7, 56);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(139, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gamemode Template";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(7, 34);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Map Template";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(7, 11);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "SWEP Template";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(508, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(81, 22);
            button2.TabIndex = 4;
            button2.Text = "Browse..";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*\"";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.Filter = "Source Map Files (*.bsp)|*.bsp";
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(4, 334);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(73, 22);
            button5.TabIndex = 5;
            button5.Text = "About";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            openFileDialog4.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 371);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(897, 410);
            Name = "Form1";
            Text = "GMOD Addon Template Creator";
            tabControl1.ResumeLayout(false);
            info.ResumeLayout(false);
            info.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            option.ResumeLayout(false);
            option.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TabControl tabControl1;
        private TabPage info;
        private TabPage option;
        private Label label2;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox textBox7;
        private CheckBox checkBox4;
        private Label label10;
        private Label label9;
        private GroupBox groupBox2;
        private Label label12;
        private Label label11;
        private TextBox textBox8;
        private Button button4;
        private OpenFileDialog openFileDialog3;
        private Button button5;
        private OpenFileDialog openFileDialog4;
        private Button button6;
        private PictureBox pictureBox1;
        private Label label14;
        private Label label13;
        private Button button3;
        private Label label16;
        private Label label7;
        private PictureBox pictureBox2;
        private CheckBox checkBox5;
        private Label label19;
        private Label label18;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Label label17;
        private ComboBox comboBox2;
        private Label label15;
        private CheckBox checkBox6;
        private GroupBox groupBox3;
    }
}