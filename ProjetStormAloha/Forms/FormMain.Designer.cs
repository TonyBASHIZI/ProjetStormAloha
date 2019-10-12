namespace ProjetStormAloha.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeconnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionCarte = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionClient = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionPos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHistTransact = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuGestionUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuRapportTransact = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.formulaireToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(984, 25);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuConnection,
            this.MenuDeconnection,
            this.toolStripSeparator5,
            this.MenuCloseAll,
            this.toolStripSeparator2,
            this.MenuExit});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(54, 19);
            this.fileMenu.Text = "&Fichier";
            // 
            // MenuConnection
            // 
            this.MenuConnection.ImageTransparentColor = System.Drawing.Color.Black;
            this.MenuConnection.Name = "MenuConnection";
            this.MenuConnection.Size = new System.Drawing.Size(152, 22);
            this.MenuConnection.Text = "&Connexion";
            this.MenuConnection.Click += new System.EventHandler(this.MenuConnection_Click);
            // 
            // MenuDeconnection
            // 
            this.MenuDeconnection.Name = "MenuDeconnection";
            this.MenuDeconnection.Size = new System.Drawing.Size(143, 22);
            this.MenuDeconnection.Text = "&Déconnexion";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(140, 6);
            // 
            // MenuCloseAll
            // 
            this.MenuCloseAll.Name = "MenuCloseAll";
            this.MenuCloseAll.Size = new System.Drawing.Size(143, 22);
            this.MenuCloseAll.Text = "&Fermer tout";
            this.MenuCloseAll.Click += new System.EventHandler(this.MenuCloseAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(140, 6);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(143, 22);
            this.MenuExit.Text = "&Quitter";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // formulaireToolStripMenuItem
            // 
            this.formulaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuGestionCarte,
            this.MenuGestionClient,
            this.MenuGestionCompte,
            this.MenuGestionPos,
            this.MenuGestionAgent});
            this.formulaireToolStripMenuItem.Name = "formulaireToolStripMenuItem";
            this.formulaireToolStripMenuItem.Size = new System.Drawing.Size(76, 19);
            this.formulaireToolStripMenuItem.Text = "&Formulaire";
            // 
            // MenuGestionCarte
            // 
            this.MenuGestionCarte.Name = "MenuGestionCarte";
            this.MenuGestionCarte.Size = new System.Drawing.Size(184, 22);
            this.MenuGestionCarte.Text = "Gestion des cartes";
            this.MenuGestionCarte.Click += new System.EventHandler(this.MenuGestionCarte_Click);
            // 
            // MenuGestionClient
            // 
            this.MenuGestionClient.Name = "MenuGestionClient";
            this.MenuGestionClient.Size = new System.Drawing.Size(184, 22);
            this.MenuGestionClient.Text = "Gestion des clients";
            this.MenuGestionClient.Click += new System.EventHandler(this.MenuGestionClient_Click);
            // 
            // MenuGestionCompte
            // 
            this.MenuGestionCompte.Name = "MenuGestionCompte";
            this.MenuGestionCompte.Size = new System.Drawing.Size(184, 22);
            this.MenuGestionCompte.Text = "Gestion des comptes";
            this.MenuGestionCompte.Click += new System.EventHandler(this.MenuGestionCompte_Click);
            // 
            // MenuGestionPos
            // 
            this.MenuGestionPos.Name = "MenuGestionPos";
            this.MenuGestionPos.Size = new System.Drawing.Size(184, 22);
            this.MenuGestionPos.Text = "Gestion des POS";
            // 
            // MenuGestionAgent
            // 
            this.MenuGestionAgent.Name = "MenuGestionAgent";
            this.MenuGestionAgent.Size = new System.Drawing.Size(184, 22);
            this.MenuGestionAgent.Text = "Gestion des agents";
            this.MenuGestionAgent.Click += new System.EventHandler(this.MenuGestionAgent_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOption,
            this.toolStripSeparator1,
            this.MenuRapportTransact});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(50, 19);
            this.toolsMenu.Text = "&Outils";
            // 
            // MenuOption
            // 
            this.MenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHistTransact,
            this.MenuGestionUser});
            this.MenuOption.Name = "MenuOption";
            this.MenuOption.Size = new System.Drawing.Size(194, 22);
            this.MenuOption.Text = "&Options";
            // 
            // MenuHistTransact
            // 
            this.MenuHistTransact.Name = "MenuHistTransact";
            this.MenuHistTransact.Size = new System.Drawing.Size(217, 22);
            this.MenuHistTransact.Text = "Historique des transactions";
            this.MenuHistTransact.Click += new System.EventHandler(this.MenuHistTransact_Click);
            // 
            // MenuGestionUser
            // 
            this.MenuGestionUser.Name = "MenuGestionUser";
            this.MenuGestionUser.Size = new System.Drawing.Size(217, 22);
            this.MenuGestionUser.Text = "Gestion des utilisateurs";
            this.MenuGestionUser.Click += new System.EventHandler(this.MenuGestionUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // MenuRapportTransact
            // 
            this.MenuRapportTransact.Name = "MenuRapportTransact";
            this.MenuRapportTransact.Size = new System.Drawing.Size(194, 22);
            this.MenuRapportTransact.Text = "&Rapport de transaction";
            this.MenuRapportTransact.Click += new System.EventHandler(this.MenuRapportTransact_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(24, 19);
            this.helpMenu.Text = "?";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&A propos";
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 559);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.StatusStrip.Size = new System.Drawing.Size(984, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel.Text = "By Aloha Dynamics";
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMain.Location = new System.Drawing.Point(0, 25);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(984, 534);
            this.PnlMain.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Storm Sport Admin";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuDeconnection;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuConnection;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuOption;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulaireToolStripMenuItem;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionCarte;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionClient;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionCompte;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionPos;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionAgent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuRapportTransact;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuHistTransact;
        private System.Windows.Forms.ToolStripMenuItem MenuGestionUser;
    }
}



