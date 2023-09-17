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


        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox6.Text = openFileDialog1.FileName;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Debug.Print(folderBrowserDialog1.SelectedPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("No addon name.", "GATC ERROR",
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
                    Directory.CreateDirectory(addonfolder + @"\lua\swep_weapon");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua", addonfolder + @"lua\swep_weapon\cl_init.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\shared.lua", addonfolder + @"lua\swep_weapon\shared.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\swep_weapon\init.lua", addonfolder + @"lua\swep_weapon\init.lua");
                }
                if (checkBox4.Checked)
                {
                    Directory.CreateDirectory(addonfolder + @"\lua\gmod_tool");
                    Directory.CreateDirectory(addonfolder + @"\lua\gmod_tool\stools");
                    File.Copy(appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua", addonfolder + @"lua\swep_weapon\stool.lua");
                }
                if (checkBox3.Checked)
                {
                    Directory.CreateDirectory(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", ""));
                    File.Create(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\" + textBox2.Text.ToLower().Replace(" ", "") + ".txt").Dispose();
                    using (StreamWriter sw = new StreamWriter(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\" + textBox2.Text.ToLower().Replace(" ", "") + ".txt"))
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
                    File.Copy(appdat + @"\GMOD Template Creator\gamemode\init.lua", addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\init.lua");
                    File.Copy(appdat + @"\GMOD Template Creator\gamemode\cl_init.lua", addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"\cl_init.lua");
                    File.Create(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"shared.lua").Dispose();
                    using (StreamWriter sw = new StreamWriter(addonfolder + @"\gamemodes\" + textBox2.Text.ToLower().Replace(" ", "") + @"shared.lua"))
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
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                textBox8.Text = openFileDialog3.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}