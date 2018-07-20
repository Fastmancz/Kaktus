using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Mnou přidané
using Newtonsoft.Json;
using System.Net;
using System.Management;
using System.IO;
using Microsoft.Win32;

namespace kaktus_dobijecka
{
    public partial class MainForm : Form
    {
        //Variables
        string version = "1.0.1";
        string checkinternetping = "https://google.cz";
        string website = "https://fastmancz.000webhostapp.com/api/kaktus/";
        int check = 300000; // in miliseconds, 300000 - 5 min., 5000 - 5 sec.

        private bool CheckConnection(String URL)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Timeout = 1000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.Close();
                    return true;
                }
                else
                {
                    response.Close();
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public MainForm()
        {
            bool checkinternet = CheckConnection(checkinternetping); if (checkinternet == false) { MessageBox.Show("Nelze se připojit ke vzdálenému serveru.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error); GV.OK = 0; if (Application.MessageLoop) { Application.Exit(); } else { Environment.Exit(1); } }

            if (GV.OK == 1)
            {
                InitializeComponent();

                var json = new WebClient().DownloadString(String.Format(website));
                CB_JSON app_json = JsonConvert.DeserializeObject<CB_JSON>(json);

                if(app_json.Kaktus_version != version)
                {
                    Text = "Kaktus - Dobíječka - "+version+" ("+app_json.Kaktus_version+")";
                    text_version_aktualni.Visible = false;
                    text_version_neaktualni.Visible = true;
                }
                else
                {
                    Text = "Kaktus - Dobíječka - " +version+"";
                    text_version_aktualni.Visible = true;
                    text_version_neaktualni.Visible = false;
                }

                if (app_json.Kaktus_dobijecka == "1")
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "KAKTUS - DOBÍJEČKA!";
                    notifyIcon1.BalloonTipText = "Právě probíhá dobíječka.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(5000);
                    notifyIcon1.Icon = Properties.Resources.icon_active;

                    text_main.Text = "Právě probíhá dobíječka!";
                    text_main.ForeColor = Color.Green;
                    text_main.Font = new Font("Microsoft Sans Serif", 23, FontStyle.Bold);
                }
                else
                {
                    notifyIcon1.Icon = Properties.Resources.faicon;
                    text_main.Text = "Právě neprobíhá dobíječka";
                    text_main.ForeColor = Color.Red;
                    text_main.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                }

                InitTimer();
            }
        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = check;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool checkinternet = CheckConnection(checkinternetping);
            if (checkinternet == false)
            {
                text_main.Text = "Nelze se připojit k serveru";
                text_main.ForeColor = Color.Red;
                text_main.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                GV.OK = 0;
            }
            else
            {
                GV.OK = 1;
            }

            if (GV.OK == 1)
            {
                var json = new WebClient().DownloadString(String.Format(website));
                CB_JSON app_json = JsonConvert.DeserializeObject<CB_JSON>(json);

                if (app_json.Kaktus_version != version)
                {
                    Text = "Kaktus - Dobíječka - " + version + " (" + app_json.Kaktus_version + ")";
                    text_version_aktualni.Visible = false;
                    text_version_neaktualni.Visible = true;
                }
                else
                {
                    Text = "Kaktus - Dobíječka - " + version + "";
                    text_version_aktualni.Visible = true;
                    text_version_neaktualni.Visible = false;
                }

                if (app_json.Kaktus_dobijecka == "1")
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.BalloonTipTitle = "KAKTUS - DOBÍJEČKA!";
                    notifyIcon1.BalloonTipText = "Právě probíhá dobíječka.";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
                    notifyIcon1.ShowBalloonTip(5000);
                    notifyIcon1.Icon = Properties.Resources.icon_active;

                    text_main.Text = "Právě probíhá dobíječka!";
                    text_main.ForeColor = Color.Green;
                    text_main.Font = new Font("Microsoft Sans Serif", 23, FontStyle.Bold);
                }
                else
                {
                    notifyIcon1.Icon = Properties.Resources.faicon;
                    text_main.Text = "Právě neprobíhá dobíječka";
                    text_main.ForeColor = Color.Red;
                    text_main.Font = new Font("Microsoft Sans Serif", 21, FontStyle.Bold);
                }
            }
        }

        public class CB_JSON
        {
            //Zjištění stavu
            public string Kaktus_dobijecka { get; set; }
            public string Kaktus_version { get; set; }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            ShowInTaskbar = true;
            e.Cancel = true;
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
            notifyIcon1.Visible = true;
        }

        private void zobrazitStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
        }

        private void zapnoutPřiSpuštěníPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            string valueName = "Kaktus - Dobijecka";
            if (Registry.GetValue(keyName, valueName, null) != null)
            {
                MessageBox.Show("Kaktus nemohl být přidát do automatického spuštění, protože se již v seznamu nachází.", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.SetValue("Kaktus - Dobijecka", Application.ExecutablePath.ToString());

                MessageBox.Show("Kaktus bude nyní zapnutý při každém spuštění Windows.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void vypnoutPřiSpuštěníPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string keyName = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
            string valueName = "Kaktus - Dobijecka";
            if (Registry.GetValue(keyName, valueName, null) != null)
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                reg.DeleteValue("Kaktus - Dobijecka");
                MessageBox.Show("Kaktus se již nyní nebude zapínat při každém spuštění Windows.", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kaktus nebyl nalezen. Pravděpodobně byl již vymazán, a nebo vzal roha :(", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void webovéStránkyKaktusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mujkaktus.cz");
        }

        private void githubFastmanczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Fastmancz/Kaktus");
        }

        private void KdispozicinovaverzeLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Fastmancz/Kaktus");
        }

        private void ukončitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = false;
            Environment.Exit(1);
        }
    }
}
