using System;
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
    public partial class PosaljiUpitForm : Form
    {
        private Upit upit = null;
        public PosaljiUpitForm()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void posaljiButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
