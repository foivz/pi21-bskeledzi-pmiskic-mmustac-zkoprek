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
    public partial class NapraviRezervacijuForm : Form
    {
        private readonly CarRentalEntities _db;
        private bool kartica;
        private string datum1;
        private string datum2;
        private Lokacija lokacija;
        private Grad grad;

        public NapraviRezervacijuForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private Grad DohvatiOdabraniGrad()
        {
            grad = gradComboBox.SelectedItem as Grad;
            return grad;
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
                IznajmiAutomobilForm frm = new IznajmiAutomobilForm( kartica, lokacija, datum1, datum2);
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
            List<Grad> grad;

            using(var context = new CarRentalEntities())
            {
                grad = context.Grads.ToList();
            }
            gradComboBox.DataSource = grad;
            gradComboBox.DisplayMember = "grad";
            
            using (var context = new CarRentalEntities())
            {
                lokacija = context.Lokacijas.ToList();
            }

            lokacijaComboBox.DataSource = lokacija;
            lokacijaComboBox.DisplayMember = "adresa";


        }

        private void gradComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grad grad = gradComboBox.SelectedItem as Grad;
            int id = grad.id_grad;
            Lokacija nova = new Lokacija();
            List<Lokacija> listaLokacija = new List<Lokacija>();
            using (var context = new CarRentalEntities())
            {

                listaLokacija = context.Lokacijas.ToList();
                           
            }

            List<string> pomocnaLista = new List<string>();
            foreach (Lokacija item in listaLokacija)
            {
                if(id == item.id_grad)
                {
                    pomocnaLista.Add(item.adresa);
                }
            }

            lokacijaComboBox.DataSource = pomocnaLista;
        }
    }
}
