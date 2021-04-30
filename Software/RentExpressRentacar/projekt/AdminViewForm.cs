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
    public partial class AdminViewForm : Form
    {
        private Zaposlenik zaposlenik = null;
        private Osiguranje osiguranje = null;
        private Lokacija lokacija = null;
        private Automobil automobil = null;
        private List<Zaposlenik> listaZaposlenika;
        private List<Osiguranje> listaOsiguranja;
        private List<Automobil> listaAutomobila;
        private List<Lokacija> listaLokacija;
        public int Id { get; set; }
        public AdminViewForm()
        {
            InitializeComponent();
            Id = 0;
            listaZaposlenika = new List<Zaposlenik>();
            listaZaposlenika.Add(new Zaposlenik("Pero", "Perić", "111", Ugovor.NaOgraničenoVrijeme, TipKorisnika.Zaposlenik, Spol.Muško, "111"));
            listaZaposlenika.Add(new Zaposlenik("Marko", "Marić", "222", Ugovor.Trajni, TipKorisnika.Administrator, Spol.Muško, "222"));
            listaZaposlenika.Add(new Zaposlenik("Ivana", "Ivić", "333", Ugovor.Trajni, TipKorisnika.Moderator, Spol.Žensko, "333"));

            listaOsiguranja = new List<Osiguranje>();
            Osiguranje novoOsiguranje1 = new Osiguranje("Osiguranje 1", 1600.5, "Polica 1", "CROATIA");
            Osiguranje novoOsiguranje2 = new Osiguranje("Osiguranje 2", 3000, "Polica 2", "Osiguraj se");
            Osiguranje novoOsiguranje3 = new Osiguranje("Osiguranje 3", 300, "Polica 3", "Jeftino");
            listaOsiguranja.Add(novoOsiguranje1);
            listaOsiguranja.Add(novoOsiguranje2);
            listaOsiguranja.Add(novoOsiguranje3);

            listaAutomobila = new List<Automobil>();
            listaAutomobila.Add(new Automobil("A1", "BMW M3", "BMW", "M3", 1998, "siva",novoOsiguranje1));
            listaAutomobila.Add(new Automobil("B1", "Mercedes AMG500", "Mercedes", "AMG500", 1998, "bijela", novoOsiguranje2));
            listaAutomobila.Add(new Automobil("C1", "Seat Leon", "Seat", "Leon", 2013, "plava", novoOsiguranje3));

            listaLokacija = new List<Lokacija>();
            listaLokacija.Add(new Lokacija("Varaždin", "Adresa 1"));
            listaLokacija.Add(new Lokacija("Zadar", "Adresa 2"));
            listaLokacija.Add(new Lokacija("Zagreb", "Adresa 3"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            osvjeziButtone();
            vidiZaposlenikeButton.Enabled = false;
            osvjeziDataGrid();

        }
        private void vidiZaposlenikeButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis zaposlenika: ";
            dodajButton.Text = "Dodaj zaposlenika ";
            izmijeniButton.Text = "Izmijeni zaposlenika ";
            izbrisiButton.Text = "Izbriši zaposlenika";
            osvjeziButtone();
            vidiZaposlenikeButton.Enabled = false;
            Id = 0;
            osvjeziDataGrid();
        }

        private void vidiOsiguranjaButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis osiguranja: ";
            dodajButton.Text = "Dodaj osiguranje ";
            izmijeniButton.Text = "Izmijeni osiguranje ";
            izbrisiButton.Text = "Izbriši osiguranje";
            osvjeziButtone();
            vidiOsiguranjaButton.Enabled = false;
            Id = 1;
            osvjeziDataGrid();
        }

        private void vidiLokacijeButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis lokacija: ";
            dodajButton.Text = "Dodaj lokaciju ";
            izmijeniButton.Text = "Izmijeni lokaciju ";
            izbrisiButton.Text = "Izbriši lokaciju";
            osvjeziButtone();
            vidiLokacijeButton.Enabled = false;
            Id = 2;
            osvjeziDataGrid();
        }

        private void vidiAutomobilButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis automobila: ";
            dodajButton.Text = "Dodaj automobil ";
            izmijeniButton.Text = "Izmijeni automobil ";
            izbrisiButton.Text = "Izbriši automobil";
            osvjeziButtone();
            vidiAutomobileButton.Enabled = false;
            Id = 3;
            osvjeziDataGrid();
        }

        private void statistikaButton_Click(object sender, EventArgs e)
        {
            //Gumb koji će prikazati statistiku, grafove & tablice rezervacija itd...
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            switch (Id)
            {
                case 0:
                    {
                        DodajZaposlenikaForm dodajZaposlenika = new DodajZaposlenikaForm();
                        dodajZaposlenika.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 1:
                    {
                        DodajOsiguranjeForm dodajOsiguranje = new DodajOsiguranjeForm();
                        dodajOsiguranje.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 2:
                    {
                        DodajLokacijuForm dodajLokaciju = new DodajLokacijuForm();
                        dodajLokaciju.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 3:
                    {
                        DodajAutomobilForm dodajAutomobil = new DodajAutomobilForm();
                        dodajAutomobil.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                default:
                    break;
            }
        }

        private void izmijeniButton_Click(object sender, EventArgs e)
        {
            switch (Id)
            {
                case 0:
                    {
                        if(glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            zaposlenik = glavniDataGrid.CurrentRow.DataBoundItem as Zaposlenik;
                        }
                        DodajZaposlenikaForm izmijeniZaposlenika = new DodajZaposlenikaForm(zaposlenik);
                        izmijeniZaposlenika.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 1:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            osiguranje = glavniDataGrid.CurrentRow.DataBoundItem as Osiguranje;
                        }
                        DodajOsiguranjeForm dodajOsiguranje = new DodajOsiguranjeForm(osiguranje);
                        dodajOsiguranje.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 2:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            lokacija = glavniDataGrid.CurrentRow.DataBoundItem as Lokacija;
                        }
                        DodajLokacijuForm dodajLokaciju = new DodajLokacijuForm(lokacija);
                        dodajLokaciju.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                case 3:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            automobil = glavniDataGrid.CurrentRow.DataBoundItem as Automobil;
                        }
                        DodajAutomobilForm dodajAutomobil = new DodajAutomobilForm(automobil);
                        dodajAutomobil.ShowDialog();
                        osvjeziDataGrid();
                        break;
                    }
                default:
                    break;
            }
        }
        private void izbrisiButton_Click(object sender, EventArgs e)
        {
            switch (Id)
            {
                case 0:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            zaposlenik = glavniDataGrid.CurrentRow.DataBoundItem as Zaposlenik;
                        }
                        listaZaposlenika.Remove(zaposlenik);
                        osvjeziDataGrid();
                        break;
                    }
                case 1:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            osiguranje = glavniDataGrid.CurrentRow.DataBoundItem as Osiguranje;
                        }
                        listaOsiguranja.Remove(osiguranje);
                        osvjeziDataGrid();
                        break;
                    }
                case 2:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            lokacija = glavniDataGrid.CurrentRow.DataBoundItem as Lokacija;
                        }
                        listaLokacija.Remove(lokacija);
                        osvjeziDataGrid();
                        break;
                    }
                case 3:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            automobil = glavniDataGrid.CurrentRow.DataBoundItem as Automobil;
                        }
                        listaAutomobila.Remove(automobil);
                        osvjeziDataGrid();
                        break;
                    }
                default:
                    break;
            }
        }
        private void osvjeziButtone()
        {
            vidiZaposlenikeButton.Enabled = true;
            vidiLokacijeButton.Enabled = true;
            vidiOsiguranjaButton.Enabled = true;
            vidiAutomobileButton.Enabled = true;
            statistikaButton.Visible = true;
        }
        private void osvjeziDataGrid()
        {
            switch (Id)
            {
                case 0:
                    {
                        glavniDataGrid.DataSource = null;
                        glavniDataGrid.DataSource = listaZaposlenika;
                        break;
                    }
                case 1:
                    {
                        glavniDataGrid.DataSource = null;
                        glavniDataGrid.DataSource = listaOsiguranja;
                        break;
                    }
                case 2:
                    {
                        glavniDataGrid.DataSource = null;
                        glavniDataGrid.DataSource = listaLokacija;
                        break;
                    }
                case 3:
                    {
                        glavniDataGrid.DataSource = null;
                        glavniDataGrid.DataSource = listaAutomobila;
                        break;
                    }
                default:
                    break;
            }
        }

        private void AdminViewForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("f1");
            }
        }
    }
}
