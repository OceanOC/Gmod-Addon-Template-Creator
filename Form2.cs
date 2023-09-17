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
            if (!Directory.Exists(appdat + @"\GMOD Template Creator"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator");
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\swep_weapon"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\swep_weapon");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/cl_init.lua", appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua");
                progressBar1.Value += 10;
                richTextBox1.Text += "\nDownloaded: swep_weapon\\cl_init.lua\n";
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/init.lua", appdat + @"\GMOD Template Creator\swep_weapon\init.lua");
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: swep_weapon\\init.lua\n";
                Thread.Sleep(1100);
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/shared.lua", appdat + @"\GMOD Template Creator\swep_weapon\shared.lua");
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: swep_weapon\\shared.lua\n";
                client.Dispose();
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gmod_tool"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool");
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool\stools");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/gmod_tool/stools/stool.lua", appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua");
                client.Dispose();
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: gmod_tool\\stools\\stool.lua\n";
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\autorun"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\autorun");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua", appdat + @"\GMOD Template Creator\autorun\sh_loader.lua");
                client.Dispose();
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: autorun\\sh_loader.lua\n";
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\maps"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gamemode");
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua", appdat + @"\GMOD Template Creator\autorun\sh_loader.lua");
                client.Dispose();
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: maps\\gatc_example.bsp\n";
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gamemode"))
            {
                WebClient client = new WebClient();
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua", appdat + @"\GMOD Template Creator\autorun\init.lua");
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: gamemode\\init.lua";
                client.DownloadFile(@"https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua", appdat + @"\GMOD Template Creator\autorun\cl_init.lua");
                client.Dispose();
                progressBar1.Value += 10;
                richTextBox1.Text += "Downloaded: gamemode\\cl_init.lua";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tomdotbat.dev/");
        }
    }
}
