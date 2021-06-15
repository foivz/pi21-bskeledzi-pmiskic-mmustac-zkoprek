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
    public partial class DodajLokacijuForm : Form
    {
        private Lokacija odabranaLokacija = null;
        private readonly CarRentalEntities _db;
        private bool izmijeni = false;
        public DodajLokacijuForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            PopuniGradove();
        }

        private void PopuniGradove()
        {
            List<Grad> listaGradova = new List<Grad>();
            using (var context = new CarRentalEntities())
            {
                listaGradova = context.Grads.ToList();
            }
            gradComboBox.DataSource = listaGradova;
        }

        public DodajLokacijuForm(Lokacija lokacija)
        {
            InitializeComponent();
            PopuniGradove();
            gradComboBox.SelectedItem = lokacija.Grad.id_grad;
            adresaTextBox.Text = lokacija.adresa;
            dodajButton.Text = "Izmijeni";
            _db = new CarRentalEntities();
            odabranaLokacija = lokacija;
            izmijeni = true;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (izmijeni == true)
            {
                using (var context = new CarRentalEntities())
                {
                    Grad grad = gradComboBox.SelectedItem as Grad;
                    context.Grads.Attach(grad);
                    string adresa = adresaTextBox.Text;

                    context.Lokacijas.Attach(odabranaLokacija);

                    odabranaLokacija.Grad = grad;
                    odabranaLokacija.adresa = adresa;

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new CarRentalEntities())
                {
                    Grad grad = gradComboBox.SelectedItem as Grad;
                    context.Grads.Attach(grad);
                    string adresa = adresaTextBox.Text;

                    Lokacija novaLokacija = new Lokacija
                    {
                        Grad = grad,
                        adresa = adresa
                    };

                    context.Lokacijas.Add(novaLokacija);
                    context.SaveChanges();
                }
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
