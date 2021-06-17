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
    public partial class AdminViewForm : Form
    {
        private Zaposlenik zaposlenik = null;
        private Osiguranje osiguranje = null;
        private Lokacija lokacija = null;
        private Automobil automobil = null;
        
        public int Id { get; set; }
        private LogInForm _login;
        public Zaposlenik _zaposlenik;
        public string _tipZaposlenika;
        private readonly CarRentalEntities _db;
        
        public AdminViewForm()
        {
            InitializeComponent();
            Id = 0;
            _db = new CarRentalEntities();
        }
        public AdminViewForm(LogInForm login, Zaposlenik zaposlenik)
        {
            InitializeComponent();
            _login = login;

            _zaposlenik = zaposlenik;
            _tipZaposlenika = zaposlenik.ZaposlenikUloges.FirstOrDefault().TipZaposlenika.naziv;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(_tipZaposlenika == "admin")
            {
                AdminView();
                osvjeziDataGrid();
            }
            else if(_tipZaposlenika == "moderator")
            {
                ModeratorView();
                osvjeziDataGrid();
            }
            UcitajImePoduzeca();
        }

        private void ModeratorView()
        {
            vidiZaposlenikeButton.Visible = true;
            vidiZaposlenikeButton.Enabled = false;
            vidiOsiguranjaButton.Visible = true;
            vidiLokacijeButton.Visible = true;
            vidiAutomobileButton.Visible = true;
            statistikaButton.Visible = true;
            dodajButton.Visible = false;
            izbrisiButton.Visible =false;
            izmijeniButton.Visible = false;
        }

        private void AdminView()
        {
            vidiZaposlenikeButton.Visible = true;
            vidiZaposlenikeButton.Enabled = false;
            vidiOsiguranjaButton.Visible = true;
            vidiLokacijeButton.Visible = true;
            vidiAutomobileButton.Visible = true;
            statistikaButton.Visible = true;
            dodajButton.Visible = true;
            izbrisiButton.Visible = true;
            izmijeniButton.Visible = true;

        }

        private void vidiZaposlenikeButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis zaposlenika: ";
            dodajButton.Text = "Dodaj zaposlenika ";
            izmijeniButton.Text = "Izmijeni zaposlenika ";
            izbrisiButton.Text = "Izbriši zaposlenika";
            if (_tipZaposlenika == "admin")
            {
                osvjeziButtone();
                vidiZaposlenikeButton.Enabled = false;
                Id = 0;
                osvjeziDataGrid();
            }
            else
            {
                osvjeziButtoneZaposleniciMod();
                vidiZaposlenikeButton.Enabled = false;
                Id = 0;
                osvjeziDataGrid();
            }
        }

        private void osvjeziButtoneZaposleniciMod()
        {
            vidiOsiguranjaButton.Enabled = true;
            dodajButton.Visible = false;
            izbrisiButton.Visible = false;
            izmijeniButton.Visible = false;

        }

        private void vidiOsiguranjaButton_Click(object sender, EventArgs e)
        {
            dodajButton.Visible = true;
            izbrisiButton.Visible = true;
            izmijeniButton.Visible = true;
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
            dodajButton.Visible = true;
            izbrisiButton.Visible = true;
            izmijeniButton.Visible = true;
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
            dodajButton.Visible = true;
            izbrisiButton.Visible = true;
            izmijeniButton.Visible = true;
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
            var form = new PregledStatistikeForm();
            form.ShowDialog();
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
                        if (zaposlenik != null)
                        {
                            DodajZaposlenikaForm izmijeniZaposlenika = new DodajZaposlenikaForm(zaposlenik);
                            izmijeniZaposlenika.ShowDialog();
                            osvjeziDataGrid();
                        }
                        break;
                    }
                case 1:
                    {
                        if (glavniDataGrid.DataSource != null)
                        {
                            if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                            {
                                osiguranje = glavniDataGrid.CurrentRow.DataBoundItem as Osiguranje;
                            }
                        }
                        if (osiguranje != null)
                        {
                            DodajOsiguranjeForm dodajOsiguranje = new DodajOsiguranjeForm(osiguranje);
                            dodajOsiguranje.ShowDialog();
                            osvjeziDataGrid();
                        }
                        break;
                    }
                case 2:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            lokacija = glavniDataGrid.CurrentRow.DataBoundItem as Lokacija;
                        }
                        if (lokacija != null)
                        {
                            DodajLokacijuForm dodajLokaciju = new DodajLokacijuForm(lokacija);
                            dodajLokaciju.ShowDialog();
                            osvjeziDataGrid();
                        }
                        break;
                    }
                case 3:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            automobil = glavniDataGrid.CurrentRow.DataBoundItem as Automobil;
                        }
                        if (automobil != null)
                        {
                            DodajAutomobilForm dodajAutomobil = new DodajAutomobilForm(automobil);
                            dodajAutomobil.ShowDialog();
                            osvjeziDataGrid();
                        }
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
                        if(zaposlenik != null)
                        {
                            using (var context = new CarRentalEntities())
                            {
                                context.Zaposleniks.Attach(zaposlenik);
                                context.Zaposleniks.Remove(zaposlenik);
                                context.SaveChanges();
                            }
                        }
                        osvjeziDataGrid();
                        break;
                    }
                case 1:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            osiguranje = glavniDataGrid.CurrentRow.DataBoundItem as Osiguranje;
                        }
                        if (osiguranje != null)
                        {
                            using (var context = new CarRentalEntities())
                            {
                                context.Osiguranjes.Attach(osiguranje);
                                context.Osiguranjes.Remove(osiguranje);
                                context.SaveChanges();
                            }
                        }
                        osvjeziDataGrid();
                        break;
                    }
                case 2:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            lokacija = glavniDataGrid.CurrentRow.DataBoundItem as Lokacija;
                        }
                        if (lokacija != null)
                        {
                            using (var context = new CarRentalEntities())
                            {
                                context.Lokacijas.Attach(lokacija);
                                context.Lokacijas.Remove(lokacija);
                                context.SaveChanges();
                            }
                        }
                        osvjeziDataGrid();
                        break;
                    }
                case 3:
                    {
                        if (glavniDataGrid.CurrentRow.DataBoundItem != null)
                        {
                            automobil = glavniDataGrid.CurrentRow.DataBoundItem as Automobil;
                        }
                        if (automobil != null)
                        {
                            using (var context = new CarRentalEntities())
                            {
                                context.Automobils.Attach(automobil);
                                context.Automobils.Remove(automobil);
                                context.SaveChanges();
                            }
                        }
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
                        using (var context = new CarRentalEntities())
                        {
                            var query = from z in context.Zaposleniks
                                        where z.idPoduzeca == InfoPoduzeca.idPoduzeca select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns["lozinka"].Visible = false;
                            glavniDataGrid.Columns[12].Visible = false;
                            glavniDataGrid.Columns[13].Visible = false;
                        }
                        break;
                    }
                case 1:
                    {
                        glavniDataGrid.DataSource = null;
                        using (var context = new CarRentalEntities())
                        {
                            var query = from z in context.Osiguranjes
                                        select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns[3].Visible = false;
                        }
                        break;
                    }
                case 2:
                    {
                        glavniDataGrid.DataSource = null;
                        using (var context = new CarRentalEntities())
                        {
                            var query = from z in context.Lokacijas.Include("Grad")
                                        select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns[3].Visible = false;
                            glavniDataGrid.Columns[4].Visible = false;
                            glavniDataGrid.Columns[5].Visible = false;
                        }
                        break;
                    }
                case 3:
                    {
                        glavniDataGrid.DataSource = null;
                        using (var context = new CarRentalEntities())
                        {
                            var query = from z in context.Automobils
                                       where z.idPoduzeca == InfoPoduzeca.idPoduzeca select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns[6].HeaderText = "Cijena HRK";
                            glavniDataGrid.Columns[8].Visible = false;
                            glavniDataGrid.Columns[9].Visible = false;
                            glavniDataGrid.Columns[10].Visible = false;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        private void AdminViewForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            _login.Close(); 

        }

        private void ObavjestBtn_Click(object sender, EventArgs e)
        {
            var form = new PregledObavijestForm();
            form.ShowDialog();
        }

        private void UcitajImePoduzeca()
        {
            List<Poduzece> poduzeca = new List<Poduzece>();

            using (var context = new CarRentalEntities())
            {
                var query = from p in context.Poduzeces select p;

                poduzeca = query.ToList();
            }

            foreach (var p in poduzeca)
            {
                if(p.id == InfoPoduzeca.idPoduzeca)
                    lblPoduzece.Text = p.nazivPoduzeca;
            }
        }
    }
}
