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
        public IznajmiAutomobilForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void iznajmiButton_Click(object sender, EventArgs e)
        {
            PodatciOKupcuForm kupacForm = new PodatciOKupcuForm();
            kupacForm.ShowDialog();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IznajmiAutomobilForm_Load(object sender, EventArgs e)
        {

        }
    }
}
