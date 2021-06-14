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
    public partial class DodajLokacijuForm : Form
    {
        
        private readonly CarRentalEntities _db;
        public DodajLokacijuForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }
        public DodajLokacijuForm(Lokacija lokacija)
        {
            InitializeComponent();
            /*gradTextBox.Text = lokacija.Grad;
            adresaTextBox.Text = lokacija.Adresa;*/
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

        private void DodajLokacijuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
