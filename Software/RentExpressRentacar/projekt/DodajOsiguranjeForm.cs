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
    public partial class DodajOsiguranjeForm : Form
    {
        private Osiguranje odabranoOsiguranje = null;
        private readonly CarRentalEntities _db;
        private bool izmijeni = false;
        public DodajOsiguranjeForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public DodajOsiguranjeForm(Osiguranje osiguranje)
        {
            InitializeComponent();
            nazivTextBox.Text = osiguranje.naziv;
            //cijenaTextBox.Text = osiguranje.Cijena.ToString();
            //policaTextBox.Text = osiguranje.PolicaOsiguranja;
            opisRichTextBox.Text = osiguranje.opis;
            dodajButton.Text = "Izmijeni";
            _db = new CarRentalEntities();
            izmijeni = true;
            odabranoOsiguranje = osiguranje;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (izmijeni == true)
            {
                using (var context = new CarRentalEntities())
                {
                    string naziv = nazivTextBox.Text;
                    string opis = opisRichTextBox.Text;

                    context.Osiguranjes.Attach(odabranoOsiguranje);

                    odabranoOsiguranje.naziv = naziv;
                    odabranoOsiguranje.opis = opis;

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new CarRentalEntities())
                {
                    string naziv = nazivTextBox.Text;
                    string opis = opisRichTextBox.Text;

                    Osiguranje novoOsiguranja = new Osiguranje
                    {
                        naziv = naziv,
                        opis = opis
                    };

                    context.Osiguranjes.Add(novoOsiguranja);
                    context.SaveChanges();
                }
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajOsiguranjeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
