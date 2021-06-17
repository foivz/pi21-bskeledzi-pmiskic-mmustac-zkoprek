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
    public partial class DodajCustomZaposlenikaForm : Form
    {
        private readonly CarRentalEntities _db;
        public DodajCustomZaposlenikaForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void dodajButton_Click_1(object sender, EventArgs e)
        {
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string oib = oibTextBox.Text;
            string korime = korisnickoImeTextBox.Text;
            int ugovor_id;
            int obavijesti;
            int pregled;
            int statistika;
            int dodavanje;

            if (naOgranicenoVrijemeRadio.Checked == true)
            {
                ugovor_id = 1;
            }
            else
            {
                ugovor_id = 2;
            }
            string lozinka = lozinkaTextBox.Text;
            var hashedLozinka = Utils.Utils.HashPassword(lozinka);

            if (obavijestiDaRadio.Checked)
            {
                obavijesti = 1;
            }
            else
            {
                obavijesti = 0;
            }
            if (pregledDaRadio.Checked)
            {
                pregled = 1;
            }
            else
            {
                pregled = 0;
            }
            if (dodavanjeDaRadio.Checked)
            {
                dodavanje = 1;
            }
            else
            {
                dodavanje = 0;
            }
            if (statistikaDaRadio.Checked)
            {
                statistika = 1;
            }
            else
            {
                statistika = 0;
            }

            Zaposlenik zaposlenik = new Zaposlenik
            {
                ime = ime,
                prezime = prezime,
                OIB = oib,
                korisnicko_ime = korime,
                ugovor_id = ugovor_id,
                lozinka = hashedLozinka,
                pregled = pregled,
                obavijesti = obavijesti,
                dodavanje = dodavanje,
                statistika = statistika
            };

            _db.Zaposleniks.Add(zaposlenik);

            int id = 0;
            id = zaposlenik.id_zaposlenik;

            ZaposlenikUloge novaUloga = new ZaposlenikUloge
            {
                id_tip_zaposlenika = 2,
                id_zaposlenik = id
            };

            _db.ZaposlenikUloges.Add(novaUloga);
            _db.SaveChanges();
            Close();
        }

        private void odustaniButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
