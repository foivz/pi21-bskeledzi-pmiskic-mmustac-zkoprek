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
    public partial class DodajOsiguranjeForm : Form
    {
        private Osiguranje osiguranje = null;
        private readonly CarRentalEntities _db;
        public DodajOsiguranjeForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public DodajOsiguranjeForm(Osiguranje osiguranje)
        {
            InitializeComponent();
            /*nazivTextBox.Text = osiguranje.Naziv;
            cijenaTextBox.Text = osiguranje.Cijena.ToString();
            policaTextBox.Text = osiguranje.PolicaOsiguranja;
            opisRichTextBox.Text = osiguranje.Opis;*/
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

        private void DodajOsiguranjeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
