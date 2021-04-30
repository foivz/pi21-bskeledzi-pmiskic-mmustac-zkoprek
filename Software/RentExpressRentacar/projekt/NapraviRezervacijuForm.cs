﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projekt.Klase;

namespace projekt
{
    public partial class NapraviRezervacijuForm : Form
    {
        private Rezervacija rezervacija = null;
        public NapraviRezervacijuForm()
        {
            InitializeComponent();
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
            IznajmiAutomobilForm iznajmiAutomobil = new IznajmiAutomobilForm();
            iznajmiAutomobil.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
