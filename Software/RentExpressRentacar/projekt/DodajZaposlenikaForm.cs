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
    public partial class DodajZaposlenikaForm : Form
    {
        private Zaposlenik zaposlenik = null;
        private readonly CarRentalEntities _db;
        public DodajZaposlenikaForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public DodajZaposlenikaForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            /*imeTextBox.Text = zaposlenik.Ime;
            prezimeTextBox.Text = zaposlenik.Prezime;
            oibTextBox.Text = zaposlenik.Oib;
            brojTelefonaTextBox.Text = zaposlenik.BrojTelefona;*/
            /*if(zaposlenik.Spol == Spol.Muško)
            {
                muskoRadio.Checked = true;
            }
            else
            {
                zenskoRadio.Checked = true;
            }

            if(zaposlenik.TipKorisnika == TipKorisnika.Administrator)
            {
                adminRadio.Checked = true;
            }
            else if (zaposlenik.TipKorisnika == TipKorisnika.Moderator)
            {
                moderatorRadio.Checked = true;
            }
            else
            {
                zaposlenikRadio.Checked = true;
            }

            if(zaposlenik.Ugovor == Ugovor.NaOgraničenoVrijeme)
            {
                naOgranicenoVrijemeRadio.Checked = true;
            }
            else
            {
                trajniRadio.Checked = true;
            }*/
            dodajButton.Text = "Izmijeni";
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajZaposlenikaForm_Load(object sender, EventArgs e)
        {

        }
    }

}
