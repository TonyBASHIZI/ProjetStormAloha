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
    public partial class UcClient : UserControl
    {
        private static UcClient _instance;

        public UcClient()
        {
            InitializeComponent();
        }

        public static UcClient Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcClient();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
