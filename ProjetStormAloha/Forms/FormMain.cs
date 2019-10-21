using ProjetStormAloha.Classes.Config;
using ProjetStormAloha.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStormAloha.Forms
{
    public partial class FormMain : Form
    {
        private static FormMain main;
        private Form form = null;
        private UserControl uc = null;

        public FormMain()
        {
            InitializeComponent();
        }

        public static FormMain Instance
        {
            get
            {
                if (main == null)
                {
                    main = new FormMain();
                }

                return main;
            }

            set
            {
                value = main;
            }
        }

        public void LoadUserControles(UserControl uc)
        {
            Cursor = Cursors.WaitCursor;
            PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(uc);
            uc.Show();

            if (uc.Visible == true)
            {
                Cursor = Cursors.Default;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void GenerateConfiguration()
        {
            if (!AppConfig.InitialDirectoryExist())
            {
                AppConfig.CreateInitialDirectory();

                if (!AppConfig.ConnectionStringExist())
                {
                    AppConfig.CreateConnectionDirectory();
                    AppConfig.CreateConnectionString();
                }
            }
            else
            {
                if (!AppConfig.ConnectionStringExist())
                {
                    AppConfig.CreateConnectionDirectory();
                    AppConfig.CreateConnectionString();
                }

                if (AppConfig.ConnectionStringEmpty())
                {
                    MessageBox.Show(this, "Veuillez contacter l'administrateur système pour la configuration.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        public void RefreshOnlineStatus(bool autologout = false)
        {
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            GenerateConfiguration();
            RefreshOnlineStatus();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MenuGestionCarte_Click(object sender, EventArgs e)
        {
            form = new FormCarte
            {
                Icon = Icon,
                ShowInTaskbar = false
            };
            form.ShowDialog(this);
        }

        private void MenuGestionClient_Click(object sender, EventArgs e)
        {
            uc = UcClient.Instance;
            LoadUserControles(uc);
        }

        private void MenuGestionCompte_Click(object sender, EventArgs e)
        {
            uc = UcCompte.Instance;
            LoadUserControles(uc);
        }

        private void MenuGestionAgent_Click(object sender, EventArgs e)
        {
            uc = UcAgent.Instance;
            LoadUserControles(uc);
        }

        private void MenuHistTransact_Click(object sender, EventArgs e)
        {
            uc = UcHistTransact.Instance;
            LoadUserControles(uc);
        }

        private void MenuGestionUser_Click(object sender, EventArgs e)
        {
            form = new FormRegister
            {
                Icon = Icon,
                ShowInTaskbar = false
            };
            form.ShowDialog(this);
        }

        private void MenuConnection_Click(object sender, EventArgs e)
        {
            form = new FormLogin
            {
                Icon = Icon,
                ShowInTaskbar = false
            };
            form.ShowDialog(this);
        }

        private void MenuRapportTransact_Click(object sender, EventArgs e)
        {
            form = new FormReport
            {
                Icon = Icon,
                ShowInTaskbar = false
            };
            form.ShowDialog(this);
        }

        private void MenuGestionPos_Click(object sender, EventArgs e)
        {
            form = new FormPos
            {
                Icon = Icon,
                ShowInTaskbar = false
            };
            form.ShowDialog(this);
        }
    }
}
