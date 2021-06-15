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
    public partial class DodajAutomobilForm : Form
    {
        private Automobil odabraniAutomobil = null;
        private readonly CarRentalEntities _db;
        private bool izmijeni = false;
        public DodajAutomobilForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            PopuniOpremu();
        }

        private void PopuniOpremu()
        {
            List<Oprema> listaOpreme = new List<Oprema>();
            
            listaOpreme = _db.Opremas.ToList();
            
            
        }

        public DodajAutomobilForm(Automobil automobil)
        {
            InitializeComponent();
            markaTextBox.Text = automobil.marka;
            modelTextBox.Text = automobil.model;
            godinaTextBox.Text = automobil.godina_prozivodnje.ToString();
            //opremaComboBox.SelectedItem = automobil.OpremaAutomobilas;
            kilometrazaTextBox.Text = automobil.kilometraza.ToString();
            bojaTextBox.Text = automobil.boja;
            dodajButton.Text = "Izmijeni";
            odabraniAutomobil = automobil;
            txtCijenPoDanu.Text = automobil.cijena.ToString();
            _db = new CarRentalEntities();
            izmijeni = true;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (izmijeni == true)
            {
                using (var context = new CarRentalEntities())
                {
                    string marka = markaTextBox.Text;
                    string model = modelTextBox.Text;
                    int godinaProizvodnje = int.Parse(godinaTextBox.Text);
                    int kilometraza = int.Parse(kilometrazaTextBox.Text);
                    string boja = bojaTextBox.Text;
                    string cijena = txtCijenPoDanu.Text;

                    //OpremaAutomobila oprema = opremaComboBox.SelectedItem as OpremaAutomobila;

                    //context.OpremaAutomobilas.Attach(oprema);

                    context.Automobils.Attach(odabraniAutomobil);

                    odabraniAutomobil.marka = marka;
                    odabraniAutomobil.model = model;
                    odabraniAutomobil.godina_prozivodnje = godinaProizvodnje;
                    odabraniAutomobil.kilometraza = kilometraza;
                    odabraniAutomobil.boja = boja;
                    odabraniAutomobil.cijena = int.Parse(cijena);

                    context.SaveChanges();
                }
            }
            else
            {
                using (var context = new CarRentalEntities())
                {
                    string marka = markaTextBox.Text;
                    string model = modelTextBox.Text;
                    int godinaProizvodnje = int.Parse(godinaTextBox.Text);
                    int kilometraza = int.Parse(kilometrazaTextBox.Text);
                    string boja = bojaTextBox.Text;
                    string cijena = txtCijenPoDanu.Text;

                    //OpremaAutomobila oprema = opremaComboBox.SelectedItem as OpremaAutomobila;

                    //context.OpremaAutomobilas.Attach(oprema);

                    Automobil noviAutomobil = new Automobil
                    {
                        marka = marka,
                        model = model,
                        godina_prozivodnje = godinaProizvodnje,
                        kilometraza = kilometraza,
                        boja = boja,
                        cijena = int.Parse(cijena)                   //OpremaAutomobilas = oprema
                    };
                    context.Automobils.Add(noviAutomobil);
                    context.SaveChanges();
                }
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DodajAutomobilForm_Load(object sender, EventArgs e)
        {

        }
    }
}
