using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetStormAloha.Forms.Views
{
    public partial class UcCompte : UserControl
    {
        private static UcCompte _instance;

        public UcCompte()
        {
            InitializeComponent();
        }

        public static UcCompte Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcCompte();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
