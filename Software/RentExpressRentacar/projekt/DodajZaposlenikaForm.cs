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
                //Ugovor ugovor = null;
                int ugovor_id;
                //Ugovor ugovori = new Ugovor();

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
                //Ugovor ugovor = null;
                int ugovor_id;
                //Ugovor ugovori = new Ugovor();

                if (naOgranicenoVrijemeRadio.Checked == true)
                {
                    ugovor_id = 1;
                }
                else
                {
                    ugovor_id = 2;
                }
                //string lozinka = Utils.DefaultHashedPassword();

                Zaposlenik noviZaposlenik = new Zaposlenik
                {
                    ime = ime,
                    prezime = prezime,
                    OIB = oib,
                    korisnicko_ime = korime,
                    ugovor_id = ugovor_id
                    //lozinka = lozinka
                };

                _db.Zaposleniks.Add(noviZaposlenik);
                _db.SaveChanges();
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
