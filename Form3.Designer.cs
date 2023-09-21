namespace GmodAddonCreator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 32);
            label1.TabIndex = 0;
            label1.Text = "GMOD Addon Template Tool";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(369, 310);
            button1.Name = "button1";
            button1.Size = new Size(90, 37);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(201, 73);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credits";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(99, 45);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 15);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "NoSharp";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(57, 19);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(66, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "TomDotBat";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 45);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 1;
            label3.Text = "Autorun Script:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "Scripts:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Location = new Point(219, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 186);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Copyright: GPL License v3";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(228, 158);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(299, 41);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 5;
            label4.Text = "1.0.0";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 359);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(490, 398);
            MinimizeBox = false;
            MinimumSize = new Size(490, 398);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About GMOD Addon Template Tool";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}