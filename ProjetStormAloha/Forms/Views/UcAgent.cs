﻿using System;
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
    public partial class UcAgent : UserControl
    {
        private static UcAgent _instance;

        public UcAgent()
        {
            InitializeComponent();
        }

        public static UcAgent Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UcAgent();
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }
    }
}
