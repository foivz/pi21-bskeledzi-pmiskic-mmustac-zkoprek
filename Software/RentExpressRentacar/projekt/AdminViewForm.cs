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
            if (_tipZaposlenika == "admin")
            {
                AdminView();
                vidiZaposlenikeButton.Enabled = false;
                osvjeziDataGrid();
            }
            else if (_tipZaposlenika == "moderator")
            {
                ModeratorView();
                vidiZaposlenikeButton.Enabled = false;
                osvjeziDataGrid();
            }
            zaposlenikLabel.Text = _zaposlenik.korisnicko_ime;
            ProvjeraUloge();
        }

        private void ProvjeraUloge()
        {
            if (_zaposlenik.obavijesti == 1)
            {
                ObavjestBtn.Visible = true;
            }
            else
            {
                ObavjestBtn.Visible = false;
            }
            if (_zaposlenik.pregled == 1)
            {
                vidiZaposlenikeButton.Visible = true;
                vidiOsiguranjaButton.Visible = true;
                vidiLokacijeButton.Visible = true;
                vidiAutomobileButton.Visible = true;
            }
            else
            {
                vidiZaposlenikeButton.Visible = false;
                vidiOsiguranjaButton.Visible = false;
                vidiLokacijeButton.Visible = false;
                vidiAutomobileButton.Visible = false;
            }
            if (_zaposlenik.dodavanje == 1)
            {
                dodajButton.Visible = true;
                izmijeniButton.Visible = true;
                izbrisiButton.Visible = true;
            }
            else
            {
                dodajButton.Visible = false;
                izmijeniButton.Visible = false;
                izbrisiButton.Visible = false;
            }
            if (_zaposlenik.statistika == 1)
            {
                statistikaButton.Visible = true;
            }
            else
            {
                statistikaButton.Visible = false;
            }
            if (ObavjestBtn.Visible == false)
            {
                Point novaTocka = new Point(349, 282);
                statistikaButton.Location = novaTocka;
            }
            if(vidiZaposlenikeButton.Visible == false)
            {
                Point novaTocka = new Point(16, 282);
                Point novaTocka2 = new Point(98, 282);
                ObavjestBtn.Location = novaTocka;
                statistikaButton.Location = novaTocka2;
                if(ObavjestBtn.Visible == false)
                {
                    statistikaButton.Location = novaTocka;
                }
            }
            if(dodajCustomButton.Visible == false)
            {
                Point novaTocka = new Point(794, 282);
                Point novaTocka2 = new Point(704, 282);
                Point novaTocka3 = new Point(614, 282);
                dodajButton.Location = novaTocka3;
                izmijeniButton.Location = novaTocka2;
                izbrisiButton.Location = novaTocka;
            }
        }

        private void ModeratorView()
        {
            vidiZaposlenikeButton.Visible = true;
            vidiOsiguranjaButton.Visible = true;
            vidiLokacijeButton.Visible = true;
            vidiAutomobileButton.Visible = true;
            statistikaButton.Visible = true;
            dodajButton.Visible = false;
            izbrisiButton.Visible =false;
            izmijeniButton.Visible = false;
            dodajCustomButton.Visible = false;
            promijeniOvlastiButton.Visible = false;
        }

        private void AdminView()
        {
            vidiZaposlenikeButton.Visible = true;
            vidiOsiguranjaButton.Visible = true;
            vidiLokacijeButton.Visible = true;
            vidiAutomobileButton.Visible = true;
            statistikaButton.Visible = true;
            dodajButton.Visible = true;
            izbrisiButton.Visible = true;
            izmijeniButton.Visible = true;
            dodajCustomButton.Visible = true;
            promijeniOvlastiButton.Visible = true;
        }

        private void vidiZaposlenikeButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis zaposlenika: ";
            dodajButton.Text = "Dodaj zaposlenika ";
            izmijeniButton.Text = "Izmijeni zaposlenika ";
            izbrisiButton.Text = "Izbriši zaposlenika";
            if (_tipZaposlenika == "admin")
            {
                vidiZaposlenikeButton.Enabled = false;
                Id = 0;
                AdminView();
                vidiOsiguranjaButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                osvjeziDataGrid();
            }
            else
            {
                osvjeziButtoneZaposleniciMod();
                vidiZaposlenikeButton.Enabled = false;
                vidiOsiguranjaButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                Id = 0;
                osvjeziDataGrid();
            }
            ProvjeraUloge();
        }

        private void osvjeziButtoneZaposleniciMod()
        {
            vidiZaposlenikeButton.Enabled = true;
            vidiOsiguranjaButton.Enabled = true;
            vidiLokacijeButton.Enabled = true;
            vidiAutomobileButton.Enabled = true;
            dodajButton.Visible = false;
            izbrisiButton.Visible = false;
            izmijeniButton.Visible = false;
            dodajCustomButton.Visible = false;
            promijeniOvlastiButton.Visible = false;
        }

        private void vidiOsiguranjaButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis osiguranja: ";
            dodajButton.Text = "Dodaj osiguranje ";
            izmijeniButton.Text = "Izmijeni osiguranje ";
            izbrisiButton.Text = "Izbriši osiguranje";
            if (_tipZaposlenika == "admin")
            {
                AdminView();
                vidiOsiguranjaButton.Enabled = false;
                vidiZaposlenikeButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                Id = 1;
                osvjeziDataGrid();
            }
            else
            {
                osvjeziButtoneZaposleniciMod();
                vidiOsiguranjaButton.Enabled = false;
                vidiZaposlenikeButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                Id = 1;
                osvjeziDataGrid();
            }
            ProvjeraUloge();
        }

        private void vidiLokacijeButton_Click(object sender, EventArgs e)
        {
            glavniLabel.Text = "Popis lokacija: ";
            dodajButton.Text = "Dodaj lokaciju ";
            izmijeniButton.Text = "Izmijeni lokaciju ";
            izbrisiButton.Text = "Izbriši lokaciju";
            if (_tipZaposlenika == "admin")
            {
                AdminView();
                vidiLokacijeButton.Enabled = false;
                vidiOsiguranjaButton.Enabled = true;
                vidiZaposlenikeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                Id = 2;
                osvjeziDataGrid();
            }
            else
            {
                osvjeziButtoneZaposleniciMod();
                vidiLokacijeButton.Enabled = false;
                vidiOsiguranjaButton.Enabled = true;
                vidiZaposlenikeButton.Enabled = true;
                vidiAutomobileButton.Enabled = true;
                Id = 2;
                osvjeziDataGrid();
            }
            ProvjeraUloge();
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
            if (_tipZaposlenika == "admin")
            {
                AdminView();
                vidiAutomobileButton.Enabled = false;
                vidiOsiguranjaButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiZaposlenikeButton.Enabled = true;
                Id = 3;
                osvjeziDataGrid();
            }
            else
            {
                osvjeziButtoneZaposleniciMod();
                vidiAutomobileButton.Enabled = false;
                vidiOsiguranjaButton.Enabled = true;
                vidiLokacijeButton.Enabled = true;
                vidiZaposlenikeButton.Enabled = true;
                Id = 3;
                osvjeziDataGrid();
            }
            ProvjeraUloge();
        }

        private void statistikaButton_Click(object sender, EventArgs e)
        {
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
                                foreach (var item in context.ZaposlenikUloges)
                                {
                                    if(zaposlenik.id_zaposlenik == item.id_zaposlenik)
                                    {
                                        context.ZaposlenikUloges.Remove(item);
                                    }
                                }
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
                                        select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns["lozinka"].Visible = false;
                            glavniDataGrid.Columns[7].Visible = false;
                            glavniDataGrid.Columns[8].Visible = false;
                            glavniDataGrid.Columns[9].Visible = false;
                            glavniDataGrid.Columns[10].Visible = false;
                            glavniDataGrid.Columns[11].Visible = false;
                            glavniDataGrid.Columns[12].Visible = false;
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
                            glavniDataGrid.Columns[4].Visible = false;
                            glavniDataGrid.Columns[5].Visible = false;
                            glavniDataGrid.Columns[6].Visible = false;
                            glavniDataGrid.Columns[7].Visible = false;
                        }
                        break;
                    }
                case 3:
                    {
                        glavniDataGrid.DataSource = null;
                        using (var context = new CarRentalEntities())
                        {
                            var query = from z in context.Automobils
                                        select z;
                            glavniDataGrid.DataSource = query.ToList();
                            glavniDataGrid.Columns[6].HeaderText = "Cijena HRK";
                            glavniDataGrid.Columns[7].Visible = false;
                            glavniDataGrid.Columns[8].Visible = false;
                            glavniDataGrid.Columns[9].Visible = false;
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

        private void dodajCustomButton_Click_1(object sender, EventArgs e)
        {
            DodajCustomZaposlenikaForm customUloga = new DodajCustomZaposlenikaForm();
            customUloga.ShowDialog();
            osvjeziDataGrid();
        }

        private void promijeniOvlastiButton_Click(object sender, EventArgs e)
        {
            if (glavniDataGrid.CurrentRow.DataBoundItem != null)
            {
                zaposlenik = glavniDataGrid.CurrentRow.DataBoundItem as Zaposlenik;
            }

            PromijeniOvlastiForm promijeniOvlasti = new PromijeniOvlastiForm(zaposlenik);
            promijeniOvlasti.ShowDialog();
            osvjeziDataGrid();
            
        }
    }
}
