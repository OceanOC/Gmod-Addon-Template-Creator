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

        private async void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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
                using var client = new HttpClient();
                var clinit = client.GetStringAsync("https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/cl_init.lua");
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "\nDownloaded: swep_weapon\\cl_init.lua\n"));
                Invoke(new ToDoDelegate(() => progressBar1.Value += 20));
                var init = client.GetStringAsync("https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/init.lua");
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: swep_weapon\\init.lua\n"));
                Thread.Sleep(num);
                var share = client.GetStringAsync("https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/swep_weapon/shared.lua");
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: swep_weapon\\shared.lua\n"));

                share.Wait();
                init.Wait();
                clinit.Wait();
                // Make files
                File.Create(appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\swep_weapon\cl_init.lua", clinit.Result);
                File.Create(appdat + @"\GMOD Template Creator\swep_weapon\init.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\swep_weapon\init.lua", init.Result);
                File.Create(appdat + @"\GMOD Template Creator\swep_weapon\shared.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\swep_weapon\shared.lua", share.Result);

                // Clear memory
                share.Dispose();
                clinit.Dispose();
                init.Dispose();
                client.Dispose();
            } else
            {
                Invoke(new ToDoDelegate(() => progressBar1.Value += 30));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gmod_tool"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool");
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gmod_tool\stools");
                using var client = new HttpClient();
                var stool = client.GetStringAsync("https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/weapons/gmod_tool/stools/stool.lua");
                stool.Wait();
                // Make files
                File.Create(appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\gmod_tool\stools\stool.lua", stool.Result);
                // clear memory
                stool.Dispose();
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gmod_tool\\stools\\stool.lua\n"));
            }
            else
            {
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
            }

            if (!Directory.Exists(appdat + @"\GMOD Template Creator\autorun"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\autorun");
                using var client = new HttpClient();
                var shloader = client.GetStringAsync("https://raw.githubusercontent.com/TomDotBat/gmod-templates/master/lua/autorun/sh_loader.lua");
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: autorun\\sh_loader.lua\n"));
                File.Create(appdat + @"\GMOD Template Creator\autorun\sh_loader.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\autorun\sh_loader.lua", shloader.Result);
                shloader.Dispose();
                client.Dispose();
            }
            else
            {
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\maps"))
            {
                // WebClient is required to download
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\maps");
                WebClient client = new WebClient();
                Thread.Sleep(num2);
                client.DownloadFile(@"https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/examples/gatc_example.bsp", appdat + @"\GMOD Template Creator\maps\gatc_example.bsp");
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: maps\\gatc_example.bsp\n"));
            }
            else
            {
                Invoke(new ToDoDelegate(() => progressBar1.Value += 10));
            }
            if (!Directory.Exists(appdat + @"\GMOD Template Creator\gamemode"))
            {
                Directory.CreateDirectory(appdat + @"\GMOD Template Creator\gamemode");
                using var client = new HttpClient();
                var init = client.GetStringAsync("https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/gamemode/init.lua");
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gamemode\\init.lua\n"));
                var cinit = client.GetStringAsync("https://raw.githubusercontent.com/OceanOC/Gmod-Addon-Template-Creator/master/gamemode/cl_init.lua");
                File.Create(appdat + @"\GMOD Template Creator\gamemode\cl_init.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\gamemode\cl_init.lua", cinit.Result);
                File.Create(appdat + @"\GMOD Template Creator\gamemode\init.lua").Dispose();
                File.WriteAllText(appdat + @"\GMOD Template Creator\gamemode\init.lua", init.Result);
                init.Wait();
                cinit.Wait();
                init.Dispose();
                cinit.Dispose();
                client.Dispose();
                Invoke(new ToDoDelegate(() => progressBar1.Value += 30));
                Invoke(new ToDoDelegate(() => richTextBox1.Text += "Downloaded: gamemode\\cl_init.lua\n"));
            }
            else
            {
                Invoke(new ToDoDelegate(() => progressBar1.Value += 30));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
