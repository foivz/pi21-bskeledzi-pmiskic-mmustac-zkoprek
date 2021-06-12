using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace projekt
{
    public partial class LogInForm : Form
    {
        private readonly CarRentalEntities _db;
        public LogInForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void kupacButton_Click(object sender, EventArgs e)
        {
            NapraviRezervacijuForm napraviRezervaciju = new NapraviRezervacijuForm();
            napraviRezervaciju.ShowDialog();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

            try
            {
                SHA256 sha256 = SHA256.Create();
                var korisnickoIme = korisnickoImeTextBox.Text.Trim();
                var lozinka = lozinkaTextBox.Text.Trim();
                var hashedPassword = Utils.HashPassword(lozinka);
                var korisnik = _db.Zaposleniks.FirstOrDefault(q => q.korisnicko_ime == korisnickoIme && q.lozinka == hashedPassword);
                if (korisnik == null)
                {
                    MessageBox.Show("Unesite podatke u polja!");
                }
                else
                {
                    var adminViewForm = new AdminViewForm(this, korisnik);
                    adminViewForm.ShowDialog();
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("Nesto je poslo po zlu!");
            }
          //  AdminViewForm administratorskaForma = new AdminViewForm();
          //  administratorskaForma.ShowDialog();
        }

        private void upitButton_Click(object sender, EventArgs e)
        {
            PosaljiUpitForm upitForm = new PosaljiUpitForm();
            upitForm.ShowDialog();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
