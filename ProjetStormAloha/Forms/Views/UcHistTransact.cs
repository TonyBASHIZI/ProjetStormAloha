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
    public partial class UcHistTransact : UserControl
    {
        private static UcHistTransact _instance;

        public UcHistTransact()
        {
            InitializeComponent();
        }

        public static UcHistTransact Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcHistTransact();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
