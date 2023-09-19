using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GmodAddonCreator
{

    public partial class Form2 : Form
    {
        private string appdat = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private bool advance = false;
        private delegate void ToDoDelegate();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!advance)
            {
                this.Size = new Size(538, 296);
                richTextBox1.Visible = true;
                advance = true;
            }
            else
            {
                this.Size = new Size(538, 189);
                richTextBox1.Visible = false;
                advance = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tomdotbat.dev/");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int num = new Random().Next(0000, 9999);
            int num2 = new Random().Next(0000, 9999);
            if (!Directory.Exists(appdat + @"\GMOD Template Creator"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator");
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\swep_weapon"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\swep_weapon");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/cl_init.lua", appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua");
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "\nDownloaded: swep_weapon\\cl_init.lua\n"));
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/init.lua", appdat + @"\GMOD Template Creator\swep_weapon\init.lua");
                Invoke(new ToDoDelegate(() => progressBar1.Value += 20));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: swep_weapon\\init.lua\n"));
                Thread.Sleep(num);
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/shared.lua", appdat + @"\GMOD Template Creator\swep_weapon\shared.lua");
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: swep_weapon\\shared.lua\n"));
                client.Dispose();
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gmod_tool"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool");
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool\stools");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/gmod_tool/stools/stool.lua", appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua");
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gmod_tool\\stools\\stool.lua\n"));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\autorun"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\autorun");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua", appdat + @"\GMOD Template Creator\autorun\sh_loader.lua");
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: autorun\\sh_loader.lua\n"));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\maps"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\maps");
                WebClient client = new WebClient();
                Thread.Sleep(num2);
                client.DownloadFile(@"https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/examples/gatc_example.bsp", appdat + @"\GMOD Template Creator\maps\gatc_example.bsp");
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: maps\\gatc_example.bsp\n"));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gamemode"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gamemode");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/gamemode/init.lua", appdat + @"\GMOD Template Creator\gamemode\init.lua");
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gamemode\\init.lua\n"));
                client.DownloadFile(@"https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/gamemode/cl_init.lua", appdat + @"\GMOD Template Creator\gamemode\cl_init.lua");
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 20));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gamemode\\cl_init.lua\n"));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\derma"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\derma");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/scripts/derma/basic.lua", appdat + @"\GMOD Template Creator\derma\basic.lua");
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: derma\\basic.lua\n"));

            }
        }
    }
}
