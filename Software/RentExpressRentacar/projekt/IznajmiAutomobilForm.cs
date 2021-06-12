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
    public partial class IznajmiAutomobilForm : Form
    {
        private IznajmiAutomobil iznajmiAutomobil = null;
        private readonly CarRentalEntities _db;
        private bool Ka { get; set; }
        private Lokacija Lokacija { get; set; }

        public IznajmiAutomobilForm(bool k, Lokacija lok)
        {
            InitializeComponent();
            _db = new CarRentalEntities();
            Ka = k;
            Lokacija = lok;
        }

        private void iznajmiButton_Click(object sender, EventArgs e)
        {
            Automobil auto = automobilDataGridView.CurrentRow.DataBoundItem as Automobil;

            PodatciOKupcuForm kupacForm = new PodatciOKupcuForm(auto, Lokacija, Ka);
            kupacForm.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IznajmiAutomobilForm_Load(object sender, EventArgs e)
        {
            automobilDataGridView.DataSource = GetData();
        }

        private object GetData()
        {
            using (var context = new Entities())
            {
                return context.Automobils.ToList();
            }
        }
    }
}
