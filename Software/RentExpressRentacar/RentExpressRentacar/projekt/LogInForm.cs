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
using Utils;

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
                var hashedPassword = Utils.Utils.HashPassword(lozinka);
                var korisnik = _db.Zaposleniks.FirstOrDefault(q => q.korisnicko_ime == korisnickoIme && q.lozinka == hashedPassword);
                List<ZaposlenikUloge> ulogeZaposlenika = new List<ZaposlenikUloge>();
                ulogeZaposlenika = _db.ZaposlenikUloges.ToList();
                //MessageBox.Show(ulogeZaposlenika.Count() + "");


                int ulogaZaposlenika = 0;
                if(korisnik != null)
                {
                    ulogaZaposlenika = ulogeZaposlenika.FirstOrDefault(q => q.id_zaposlenik == korisnik.id_zaposlenik).id_tip_zaposlenika.Value;
                    InfoPoduzeca.idPoduzeca = korisnik.idPoduzeca.Value;

                }
                    
                if(ulogaZaposlenika == 4)
                {
                    MessageBox.Show("Prijavljeni ste kao superadmin!");
                    var superAdminForm = new SuperAdminForm();
                    superAdminForm.ShowDialog();
                }
                if (korisnik == null)
                {
                    MessageBox.Show("Unesite ispravne podatke u polja!");
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
                MessageBox.Show(ex.Message);
            }
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
