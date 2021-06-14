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
        private IznajmiAutomobil iznajmiAutomobil = null;
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
            GetData();
        }

        private void GetData()
        {
            using (var context = new CarRentalEntities())
            {
                var query = from p in context.Automobils.Include("OpremaAutomobilas").Include("Rezervacijas")
                            select p;

                automobilDataGridView.DataSource = query.ToList();

                automobilDataGridView.Columns[6].Visible = false;
                automobilDataGridView.Columns[7].Visible = false;
                automobilDataGridView.Columns[8].Visible = false;


            }
        }

        private void automobilTextBox_TextChanged(object sender, EventArgs e)
        {
            string txt = automobilTextBox.Text;

            using (var context = new CarRentalEntities())
            {
                var query = from p in context.Automobils.Include("OpremaAutomobilas").Include("Rezervacijas")
                            where p.marka.Contains(txt)
                            select p;

                automobilDataGridView.DataSource = query.ToList();
            }
        }
    }
}
