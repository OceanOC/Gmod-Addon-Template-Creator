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
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            option = new TabPage();
            tabControl1.SuspendLayout();
            info.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\GarrysMod\\";
            textBox1.Size = new Size(430, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 1;
            label1.Text = "Garry's Mod folder:";
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
            textBox2.Location = new Point(191, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 2;
            label2.Text = "Addon Name (Required) :";
            // 
            // option
            // 
            option.Location = new Point(4, 29);
            option.Name = "option";
            option.Padding = new Padding(3);
            option.Size = new Size(780, 332);
            option.TabIndex = 1;
            option.Text = "Addon Options";
            option.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}