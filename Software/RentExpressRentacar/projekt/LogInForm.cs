using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void kupacButton_Click(object sender, EventArgs e)
        {
            NapraviRezervacijuForm napraviRezervaciju = new NapraviRezervacijuForm();
            napraviRezervaciju.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminViewForm administratorskaForma = new AdminViewForm();
            administratorskaForma.ShowDialog();
        }

        private void upitButton_Click(object sender, EventArgs e)
        {
            PosaljiUpitForm upitForm = new PosaljiUpitForm();
            upitForm.ShowDialog();
        }
    }
}
