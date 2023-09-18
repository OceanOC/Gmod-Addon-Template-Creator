using System.Diagnostics;
using System.Drawing.Text;

namespace GmodAddonCreator
{
    public partial class Form1 : Form
    {
        private string gmfolder;
        private string appdat = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private string catgory = "";
        private string mapfilter;
        private string mapfile;

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(appdat + @"\GMOD Template Creator"))
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\swep_weapon"))
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gmod_tool"))
            {
                Form2 form = new Form2();
                form.ShowDialog();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                gmfolder = textBox1.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Debug.Print(folderBrowserDialog1.SelectedPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text + @"\garrysmod\addons\" + textBox2.Text.ToLower()))
            {
                MessageBox.Show("Please delete the previous template folder before creating a new one.", "GATC ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string addonfolder = textBox1.Text + @"\garrysmod\addons\" + textBox2.Text.ToLower();
                if (comboBox1 == null)
                {
                    comboBox1.SelectedText = "OTHER";
                }
                else
                {
                    catgory = comboBox1.SelectedText.ToLower();
                }
                if (checkBox3.Checked)
                {
                    mapfilter = textBox7.Text.ToLower();
                }
                if (checkBox2.Checked)
                {
                    mapfile = textBox8.Text;
                }
                Debug.Print(addonfolder);
                Directory.CreateDirectory(addonfolder);
                Directory.CreateDirectory(addonfolder + @"\gamemodes");
                Directory.CreateDirectory(addonfolder + @"\lua");
                if (checkBox2.Checked)
                {
                    Directory.CreateDirectory(addonfolder + @"\maps");
                    if (textBox8.Text == "")
                    {
                        File.Copy(appdat + @"\GMOD Template Creator\maps\gatc_example.bsp", addonfolder + @"\maps\gatc_example.bsp");
                    }
                    else
                    {
                        File.Copy(textBox8.Text, addonfolder + @"\maps");
                    }
                }
                if (checkBox1.Checked)
                {
                    Directory.CreateDirectory(addonfolder + @"\lua\weapons");
                    Directory.CreateDirectory(addonfolder + @"\lua\weapons\swep_weapon");
                    Directory.CreateDirectory(addonfolder + @"\lua\autorun");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua", addonfolder + @"\lua\weapons\swep_weapon\cl_init.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\shared.lua", addonfolder + @"\lua\weapons\swep_weapon\shared.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\init.lua", addonfolder + @"\lua\weapons\swep_weapon\init.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\autorun\sh_loader.lua", addonfolder + @"\lua\autorun\sh_loader.lua");
                }
                if (checkBox4.Checked)
                {
                    Directory.CreateDirectory(addonfolder + @"\lua\weapons");
                    Directory.CreateDirectory(addonfolder + @"\lua\weapons\gmod_tool");
                    Directory.CreateDirectory(addonfolder + @"\lua\weapons\gmod_tool\stools");
                    File.Copy(appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua", addonfolder + @"\lua\weapons\gmod_tool\stools\stool.lua");
                }
                if (checkBox3.Checked)
                {
                    if (textBox7.Text == "*")
                    {
                        mapfilter = "";
                    }
                    Directory.CreateDirectory(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", ""));
                    Directory.CreateDirectory(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\gamemode");
                    File.Create(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\" + textBox2.Text.ToLower().Replace(" ", "") + ".txt").Dispose();
                    using (StreamWriter sw = new StreamWriter(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + "\\" + textBox2.Text.ToLower().Replace(" ", "") + ".txt"))
                    {
                        sw.WriteLine("\"" + textBox2.Text.ToLower().Replace(" ", "") + "\" \n");
                        sw.WriteLine("{");
                        sw.WriteLine("  \"base\"    \"base\"");
                        sw.WriteLine("  \"title\"   \"" + textBox2.Text + "\"");
                        sw.WriteLine("  \"maps\"   \"^" + mapfilter + "\"");
                        sw.WriteLine("  \"category\"   \"" + catgory + "\"");
                        sw.WriteLine("  \"menusystem\"   \"1\"\n");
                        sw.WriteLine("}");
                        sw.Dispose();
                    }
                    File.Copy(appdat + @"\GMOD Template Creator\gamemode\init.lua", addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\gamemode\init.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\gamemode\cl_init.lua", addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\gamemode\cl_init.lua");
                    File.Create(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\gamemode\shared.lua").Dispose();
                    using (StreamWriter sw = new StreamWriter(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\gamemode\shared.lua"))
                    {
                        sw.WriteLine("GM.Name = \"" + textBox2.Text + "\"");
                        sw.WriteLine("GM.Author = \"" + textBox3.Text + "\"");
                        sw.WriteLine("GM.Email = \"" + textBox4.Text + "\"");
                        sw.WriteLine("GM.Website = \"" + textBox5.Text + "\" \n");
                        sw.WriteLine("function GM:Initialize()");
                        sw.WriteLine("  --Do stuff");
                        sw.WriteLine("end");
                    }
                }
                if (checkBox5.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        Directory.CreateDirectory(addonfolder + @"\lua\derma");
                        File.Copy(appdat + "\\GMOD Template Creator\\derma\\advanced.lua", addonfolder + @"\lua\derma\advanced.lua");
                    }
                    if (radioButton2.Checked)
                    {
                        Directory.CreateDirectory(addonfolder + @"\lua\derma");
                        File.Copy(appdat + "\\GMOD Template Creator\\derma\\basic.lua", addonfolder + @"\lua\derma\basic.lua");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = openFileDialog3.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox1.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (openFileDialog4.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog4.FileName);
                int maxwidth = 1024;
                int maxheight = 128;
                if (img.Size.Width >= maxwidth && img.Size.Height >= maxheight)
                {
                    MessageBox.Show("Icon too big. Max size: 128x1024", "GATC ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image = img;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                int maxwidth = 32;
                int maxheight = 32;
                if (img.Size.Width >= maxwidth && img.Size.Height >= maxheight)
                {
                    MessageBox.Show("Icon too big. Max size: 32x32", "GATC ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pictureBox1.Image = img;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
        }
    }
}