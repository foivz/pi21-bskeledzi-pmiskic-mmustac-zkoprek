using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace projekt
{
    public partial class DodajZaposlenikaForm : Form
    {
        private Zaposlenik odabraniZaposlenik = null;
        private readonly CarRentalEntities _db;
        private bool izmijeni = false;
        public DodajZaposlenikaForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public DodajZaposlenikaForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            imeTextBox.Text = zaposlenik.ime;
            prezimeTextBox.Text = zaposlenik.prezime;
            oibTextBox.Text = zaposlenik.OIB;
            korisnickoImeTextBox.Text = zaposlenik.korisnicko_ime;

            if(zaposlenik.Ugovor.ugovor_id == 1)
            {
                naOgranicenoVrijemeRadio.Checked = true;
            }
            else
            {
                trajniRadio.Checked = true;
            }
            dodajButton.Text = "Izmijeni";
            _db = new CarRentalEntities();
            odabraniZaposlenik = zaposlenik;
            izmijeni = true;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (izmijeni == true)
            {
                string ime = imeTextBox.Text;
                string prezime = prezimeTextBox.Text;
                string oib = oibTextBox.Text;
                string korime = korisnickoImeTextBox.Text;
                int ugovor_id;

                if (naOgranicenoVrijemeRadio.Checked == true)
                {
                    ugovor_id = 1;
                }
                else
                {
                    ugovor_id = 2;
                }

                odabraniZaposlenik.ime = ime;
                odabraniZaposlenik.prezime = prezime;
                odabraniZaposlenik.OIB = oib;
                odabraniZaposlenik.korisnicko_ime = korime;
                odabraniZaposlenik.ugovor_id = ugovor_id;

                _db.SaveChanges();
            }
            else
            {
                string ime = imeTextBox.Text;
                string prezime = prezimeTextBox.Text;
                string oib = oibTextBox.Text;
                string korime = korisnickoImeTextBox.Text;
                int ugovor_id;

                if (naOgranicenoVrijemeRadio.Checked == true)
                {
                    ugovor_id = 1;
                }
                else
                {
                    ugovor_id = 2;
                }
                string lozinka = Utils.Utils.DefaultHashedPassword();

                Zaposlenik noviZaposlenik = new Zaposlenik
                {
                    ime = ime,
                    prezime = prezime,
                    OIB = oib,
                    korisnicko_ime = korime,
                    ugovor_id = ugovor_id,
                    lozinka = lozinka,
                    pregled = 1,
                    obavijesti = 1,
                    dodavanje = 1,
                    statistika = 1
                };

                _db.Zaposleniks.Add(noviZaposlenik);
                _db.SaveChanges();

                ZaposlenikUloge zu = new ZaposlenikUloge
                {
                    id_tip_zaposlenika = (cmbUloge.SelectedItem as TipZaposlenika).tip_zaposlenika_id,
                    id_zaposlenik = (_db.Zaposleniks.ToList().Last()).id_zaposlenik
                };
                _db.ZaposlenikUloges.Add(zu);
                _db.SaveChanges();
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajZaposlenikaForm_Load(object sender, EventArgs e)
        {
            UcitajUloge();
        }
        
        private void UcitajUloge()
        {
            cmbUloge.DataSource = null;
            using (var context = new CarRentalEntities())
            {
                var query = from u in context.TipZaposlenikas select u;
                cmbUloge.DataSource = query.ToList();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

}
