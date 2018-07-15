namespace kaktus_dobijecka
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.text_main = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zobrazitStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.webovéStránkyKaktusuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.githubFastmanczToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nastaveníToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapnoutPřiSpuštěníPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vypnoutPřiSpuštěníPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webovéStránkyKaktusuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubFastmanczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukončitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.text_version_aktualni = new System.Windows.Forms.Label();
            this.text_version_neaktualni = new System.Windows.Forms.LinkLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nejedná se o oficiální aplikaci společnosti T-Mobile Czech Republic a.s. / Kaktus" +
    "";
            // 
            // text_main
            // 
            this.text_main.AutoSize = true;
            this.text_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_main.Location = new System.Drawing.Point(12, 43);
            this.text_main.Name = "text_main";
            this.text_main.Size = new System.Drawing.Size(306, 42);
            this.text_main.TabIndex = 1;
            this.text_main.Text = "... Zjišťuji stav ...";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kaktus - Dobíječka";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zobrazitStatusToolStripMenuItem,
            this.nastaveníToolStripMenuItem1,
            this.webovéStránkyKaktusuToolStripMenuItem1,
            this.githubFastmanczToolStripMenuItem1,
            this.ukončitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(204, 114);
            // 
            // zobrazitStatusToolStripMenuItem
            // 
            this.zobrazitStatusToolStripMenuItem.Name = "zobrazitStatusToolStripMenuItem";
            this.zobrazitStatusToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.zobrazitStatusToolStripMenuItem.Text = "Zobrazit status";
            this.zobrazitStatusToolStripMenuItem.Click += new System.EventHandler(this.zobrazitStatusToolStripMenuItem_Click);
            // 
            // nastaveníToolStripMenuItem1
            // 
            this.nastaveníToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1,
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1});
            this.nastaveníToolStripMenuItem1.Name = "nastaveníToolStripMenuItem1";
            this.nastaveníToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.nastaveníToolStripMenuItem1.Text = "Nastavení";
            // 
            // zapnoutPřiSpuštěníPCToolStripMenuItem1
            // 
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1.Name = "zapnoutPřiSpuštěníPCToolStripMenuItem1";
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1.Text = "Zapnout při spuštění PC";
            this.zapnoutPřiSpuštěníPCToolStripMenuItem1.Click += new System.EventHandler(this.zapnoutPřiSpuštěníPCToolStripMenuItem_Click);
            // 
            // vypnoutPřiSpuštěníPCToolStripMenuItem1
            // 
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1.Name = "vypnoutPřiSpuštěníPCToolStripMenuItem1";
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1.Text = "Vypnout při spuštění PC";
            this.vypnoutPřiSpuštěníPCToolStripMenuItem1.Click += new System.EventHandler(this.vypnoutPřiSpuštěníPCToolStripMenuItem_Click);
            // 
            // webovéStránkyKaktusuToolStripMenuItem1
            // 
            this.webovéStránkyKaktusuToolStripMenuItem1.Name = "webovéStránkyKaktusuToolStripMenuItem1";
            this.webovéStránkyKaktusuToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.webovéStránkyKaktusuToolStripMenuItem1.Text = "Webové stránky Kaktusu";
            this.webovéStránkyKaktusuToolStripMenuItem1.Click += new System.EventHandler(this.webovéStránkyKaktusuToolStripMenuItem_Click);
            // 
            // githubFastmanczToolStripMenuItem1
            // 
            this.githubFastmanczToolStripMenuItem1.Name = "githubFastmanczToolStripMenuItem1";
            this.githubFastmanczToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.githubFastmanczToolStripMenuItem1.Text = "Github - Fastmancz";
            this.githubFastmanczToolStripMenuItem1.Click += new System.EventHandler(this.githubFastmanczToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem1
            // 
            this.ukončitToolStripMenuItem1.Name = "ukončitToolStripMenuItem1";
            this.ukončitToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.ukončitToolStripMenuItem1.Text = "Ukončit";
            this.ukončitToolStripMenuItem1.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nastaveníToolStripMenuItem,
            this.webovéStránkyKaktusuToolStripMenuItem,
            this.githubFastmanczToolStripMenuItem,
            this.ukončitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nastaveníToolStripMenuItem
            // 
            this.nastaveníToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapnoutPřiSpuštěníPCToolStripMenuItem,
            this.vypnoutPřiSpuštěníPCToolStripMenuItem});
            this.nastaveníToolStripMenuItem.Name = "nastaveníToolStripMenuItem";
            this.nastaveníToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nastaveníToolStripMenuItem.Text = "Nastavení";
            // 
            // zapnoutPřiSpuštěníPCToolStripMenuItem
            // 
            this.zapnoutPřiSpuštěníPCToolStripMenuItem.Name = "zapnoutPřiSpuštěníPCToolStripMenuItem";
            this.zapnoutPřiSpuštěníPCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.zapnoutPřiSpuštěníPCToolStripMenuItem.Text = "Zapnout při spuštění PC";
            this.zapnoutPřiSpuštěníPCToolStripMenuItem.Click += new System.EventHandler(this.zapnoutPřiSpuštěníPCToolStripMenuItem_Click);
            // 
            // vypnoutPřiSpuštěníPCToolStripMenuItem
            // 
            this.vypnoutPřiSpuštěníPCToolStripMenuItem.Name = "vypnoutPřiSpuštěníPCToolStripMenuItem";
            this.vypnoutPřiSpuštěníPCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.vypnoutPřiSpuštěníPCToolStripMenuItem.Text = "Vypnout při spuštění PC";
            this.vypnoutPřiSpuštěníPCToolStripMenuItem.Click += new System.EventHandler(this.vypnoutPřiSpuštěníPCToolStripMenuItem_Click);
            // 
            // webovéStránkyKaktusuToolStripMenuItem
            // 
            this.webovéStránkyKaktusuToolStripMenuItem.Name = "webovéStránkyKaktusuToolStripMenuItem";
            this.webovéStránkyKaktusuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.webovéStránkyKaktusuToolStripMenuItem.Text = "Webové stránky Kaktusu";
            this.webovéStránkyKaktusuToolStripMenuItem.Click += new System.EventHandler(this.webovéStránkyKaktusuToolStripMenuItem_Click);
            // 
            // githubFastmanczToolStripMenuItem
            // 
            this.githubFastmanczToolStripMenuItem.Name = "githubFastmanczToolStripMenuItem";
            this.githubFastmanczToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.githubFastmanczToolStripMenuItem.Text = "Github - Fastmancz";
            this.githubFastmanczToolStripMenuItem.Click += new System.EventHandler(this.githubFastmanczToolStripMenuItem_Click);
            // 
            // ukončitToolStripMenuItem
            // 
            this.ukončitToolStripMenuItem.Name = "ukončitToolStripMenuItem";
            this.ukončitToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ukončitToolStripMenuItem.Text = "Ukončit";
            this.ukončitToolStripMenuItem.Click += new System.EventHandler(this.ukončitToolStripMenuItem_Click);
            // 
            // text_version_aktualni
            // 
            this.text_version_aktualni.AutoSize = true;
            this.text_version_aktualni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_version_aktualni.ForeColor = System.Drawing.Color.Green;
            this.text_version_aktualni.Location = new System.Drawing.Point(294, 9);
            this.text_version_aktualni.Name = "text_version_aktualni";
            this.text_version_aktualni.Size = new System.Drawing.Size(96, 15);
            this.text_version_aktualni.TabIndex = 3;
            this.text_version_aktualni.Text = "Aktuální verze";
            // 
            // text_version_neaktualni
            // 
            this.text_version_neaktualni.AutoSize = true;
            this.text_version_neaktualni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_version_neaktualni.LinkColor = System.Drawing.Color.Red;
            this.text_version_neaktualni.Location = new System.Drawing.Point(227, 9);
            this.text_version_neaktualni.Name = "text_version_neaktualni";
            this.text_version_neaktualni.Size = new System.Drawing.Size(165, 15);
            this.text_version_neaktualni.TabIndex = 4;
            this.text_version_neaktualni.TabStop = true;
            this.text_version_neaktualni.Text = "K dispozici je nová verze";
            this.text_version_neaktualni.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KdispozicinovaverzeLinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 123);
            this.Controls.Add(this.text_version_neaktualni);
            this.Controls.Add(this.text_version_aktualni);
            this.Controls.Add(this.text_main);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaktus - Dobíječka - v1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label text_main;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapnoutPřiSpuštěníPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webovéStránkyKaktusuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubFastmanczToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vypnoutPřiSpuštěníPCToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zobrazitStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nastaveníToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapnoutPřiSpuštěníPCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vypnoutPřiSpuštěníPCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem webovéStránkyKaktusuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem githubFastmanczToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ukončitToolStripMenuItem1;
        private System.Windows.Forms.Label text_version_aktualni;
        private System.Windows.Forms.LinkLabel text_version_neaktualni;
    }
}

