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
    public partial class NapraviRezervacijuForm : Form
    {
        private readonly CarRentalEntities _db;
        private Rezervacija rezervacija = null;
        private bool kartica;
        private string datum1;
        private string datum2;
        private Lokacija lokacija;

        public NapraviRezervacijuForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private Lokacija DohvatiOdabranuLokaciju()
        {
            lokacija = lokacijaComboBox.SelectedItem as Lokacija;
            return lokacija;
        }

        private string DohvatiOdabraniDatum1()
        {
            datum1 = kalendarPruzimanje.Text;
            return datum1;
        }

        private string DohvatiOdabraniDatum2()
        {
            datum2 = kalendarVracanje.Text;
            return datum2;
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
            DohvatiOdabranuLokaciju();
            DohvatiOdabraniDatum1();
            DohvatiOdabraniDatum2();

            if (karticaRadio.Checked == false && gotovinaRadio.Checked == false)
            {
                MessageBox.Show("Morate odabrati način plaćanja!");
                return;
            }

            if (karticaRadio.Checked == true)
            {
                kartica = true;
                IznajmiAutomobilForm frm = new IznajmiAutomobilForm(kartica, lokacija, datum1, datum2);
                frm.ShowDialog();
            }

            if (karticaRadio.Checked != true)
            {
                kartica = false;
                IznajmiAutomobilForm frm = new IznajmiAutomobilForm(kartica, lokacija, datum1, datum2);
                frm.ShowDialog();
            }                                     
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NapraviRezervacijuForm_Load(object sender, EventArgs e)
        {
            List<Lokacija> lokacija;

            using (var context = new CarRentalEntities())
            {
                lokacija = context.Lokacijas.ToList();
            }

             lokacijaComboBox.DataSource = lokacija;
            lokacijaComboBox.DisplayMember = "adresa";


        }
    }
}
