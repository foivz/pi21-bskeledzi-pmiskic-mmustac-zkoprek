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
    public partial class IznajmiAutomobilForm : Form
    {
        private readonly CarRentalEntities _db;
        private bool Ka { get; set; }
        private Lokacija Lokacija { get; set; }
        private string datum1 { get; set; }
        private string datum2 { get; set; }

        public IznajmiAutomobilForm(bool k, Lokacija lok, string d1, string d2)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            Ka = k;
            Lokacija = lok;
            datum1 = d1;
            datum2 = d2;
        }

        private void iznajmiButton_Click(object sender, EventArgs e)
        {
            Automobil auto = automobilDataGridView.CurrentRow.DataBoundItem as Automobil;

            PodatciOKupcuForm kupacForm = new PodatciOKupcuForm(auto, Lokacija, Ka, datum1, datum2);
            kupacForm.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IznajmiAutomobilForm_Load(object sender, EventArgs e)
        {
            UcitajPoduzeca();
            GetData();
            
        }

        private void GetData()
        {
            int idPoduzeca = (cmbPoduzeca.SelectedItem as Poduzece).id;
            using (var context = new CarRentalEntities())
            {
                var query = from p in context.Automobils.Include("OpremaAutomobilas").Include("Rezervacijas")
                            where p.idPoduzeca == idPoduzeca select p;

                automobilDataGridView.DataSource = query.ToList();
                automobilDataGridView.Columns[6].HeaderText = "Cijena HRK";
                automobilDataGridView.Columns[7].Visible = false;
                automobilDataGridView.Columns[0].Visible = false;
                automobilDataGridView.Columns[8].Visible = false;
                automobilDataGridView.Columns[9].Visible = false;

            }
        }

        private void automobilTextBox_TextChanged(object sender, EventArgs e)
        {
            int idPoduzeca = (cmbPoduzeca.SelectedItem as Poduzece).id;
            string txt = automobilTextBox.Text;

            using (var context = new CarRentalEntities())
            {
                var query = from p in context.Automobils.Include("OpremaAutomobilas").Include("Rezervacijas")
                            where p.marka.Contains(txt) && p.idPoduzeca == idPoduzeca
                            select p;

                automobilDataGridView.DataSource = query.ToList();
            }
        }

        private void UcitajPoduzeca()
        {
            cmbPoduzeca.DataSource = null;
            cmbPoduzeca.DataSource = _db.Poduzeces.ToList();
        }

        private void cmbPoduzeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
