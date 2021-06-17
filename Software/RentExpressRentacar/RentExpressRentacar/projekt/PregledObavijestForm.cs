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
    public partial class PregledObavijestForm : Form
    {
        private readonly CarRentalEntities _db;
        public PregledObavijestForm()

        {
            _db = new CarRentalEntities();
            InitializeComponent();
        }

        private void PregledObavijestForm_Load(object sender, EventArgs e)
        {
            osvjeziDgv();
        }

        private void osvjeziDgv()
        {
            dgvObavijesti.DataSource = null;

            using(var context = new CarRentalEntities())
            {
                var query = from o in context.Upitis where o.idPoduzeca == InfoPoduzeca.idPoduzeca select o;
                dgvObavijesti.DataSource = query.ToList();
            }


        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {
            var upit = dgvObavijesti.CurrentRow.DataBoundItem as Upiti;
            var form = new OdgovoriForm(upit);
            form.ShowDialog();
            
            
        }
    }
}
