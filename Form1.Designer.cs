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
            textBox6 = new TextBox();
            button3 = new Button();
            label7 = new Label();
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
            groupBox2 = new GroupBox();
            button4 = new Button();
            label12 = new Label();
            label11 = new Label();
            textBox8 = new TextBox();
            checkBox4 = new CheckBox();
            groupBox1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog2 = new OpenFileDialog();
            openFileDialog3 = new OpenFileDialog();
            linkLabel1 = new LinkLabel();
            tabControl1.SuspendLayout();
            info.SuspendLayout();
            option.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(430, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\GarrysMod\\";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 1;
            label1.Text = "Garry's Mod folder:";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(648, 409);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
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
            tabControl1.Location = new Point(0, 38);
            tabControl1.MinimumSize = new Size(0, 300);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 365);
            tabControl1.TabIndex = 3;
            // 
            // info
            // 
            info.AutoScroll = true;
            info.Controls.Add(textBox6);
            info.Controls.Add(button3);
            info.Controls.Add(label7);
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
            info.Location = new Point(4, 29);
            info.Name = "info";
            info.Padding = new Padding(3);
            info.Size = new Size(780, 332);
            info.TabIndex = 0;
            info.Text = "Addon Info";
            info.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(103, 207);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(244, 27);
            textBox6.TabIndex = 15;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(353, 207);
            button3.Name = "button3";
            button3.Size = new Size(93, 29);
            button3.TabIndex = 14;
            button3.Text = "Browse..";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 211);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "Addon Icon:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(128, 173);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 27);
            textBox5.TabIndex = 12;
            textBox5.Text = "N/A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 176);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 11;
            label6.Text = "Addon Website:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 134);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 27);
            textBox4.TabIndex = 10;
            textBox4.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 137);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 9;
            label5.Text = "Addon Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(120, 90);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 27);
            textBox3.TabIndex = 8;
            textBox3.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 93);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 7;
            label4.Text = "Addon Author:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PVP", "PVE", "RP", "OTHER" });
            comboBox1.Location = new Point(128, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 51);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Addon Category:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(176, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "myaddon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 2;
            label2.Text = "Addon Title (Required):";
            // 
            // option
            // 
            option.Controls.Add(groupBox2);
            option.Controls.Add(checkBox4);
            option.Controls.Add(groupBox1);
            option.Controls.Add(checkBox3);
            option.Controls.Add(checkBox2);
            option.Controls.Add(checkBox1);
            option.Location = new Point(4, 29);
            option.Name = "option";
            option.Padding = new Padding(3);
            option.Size = new Size(780, 332);
            option.TabIndex = 1;
            option.Text = "Addon Options";
            option.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Location = new Point(499, 158);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 125);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Map Options";
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(184, 26);
            button4.Name = "button4";
            button4.Size = new Size(85, 29);
            button4.TabIndex = 7;
            button4.Text = "Browse..";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 68);
            label12.Name = "label12";
            label12.Size = new Size(218, 40);
            label12.TabIndex = 2;
            label12.Text = "Leave this box empty to use the\r\nexample map";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(8, 29);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 1;
            label11.Text = "Map:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(56, 26);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(125, 27);
            textBox8.TabIndex = 0;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 105);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(126, 24);
            checkBox4.TabIndex = 5;
            checkBox4.Text = "Tool Template";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(499, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 137);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gamemode Options";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 64);
            label10.Name = "label10";
            label10.Size = new Size(189, 20);
            label10.TabIndex = 17;
            label10.Text = "Ex: \"gm_\" = \"gm_construct\"";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(8, 91);
            label9.Name = "label9";
            label9.Size = new Size(251, 40);
            label9.TabIndex = 16;
            label9.Text = "Use \"*\" if the maps are not unique to\r\nthe gamemode";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(93, 30);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(103, 27);
            textBox7.TabIndex = 15;
            textBox7.Text = "gatc_";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 30);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 14;
            label8.Text = "Map Filter:";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(8, 75);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(175, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Gamemode Template";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(8, 45);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(127, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Map Template";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "SWEP Template";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(580, 12);
            button2.Name = "button2";
            button2.Size = new Size(93, 29);
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
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            openFileDialog2.Filter = "Image files (*.png)|*.png|All files (*.*)|*.*\"";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            openFileDialog3.Filter = "Source Map Files (*.bsp)|*.bsp";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(729, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(50, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "About";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "GMOD Addon Template Creator";
            tabControl1.ResumeLayout(false);
            info.ResumeLayout(false);
            info.PerformLayout();
            option.ResumeLayout(false);
            option.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox textBox6;
        private Button button3;
        private Label label7;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox textBox7;
        private OpenFileDialog openFileDialog2;
        private CheckBox checkBox4;
        private Label label10;
        private Label label9;
        private GroupBox groupBox2;
        private Label label12;
        private Label label11;
        private TextBox textBox8;
        private Button button4;
        private OpenFileDialog openFileDialog3;
        private LinkLabel linkLabel1;
    }
}