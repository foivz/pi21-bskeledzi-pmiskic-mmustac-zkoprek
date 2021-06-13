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
    public partial class PregledUpitaForm : Form
    {
        private readonly CarRentalEntities _db;
        public PregledUpitaForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdgovori_Click(object sender, EventArgs e)
        {
            var upit = dgvUpiti.CurrentRow.DataBoundItem as Upiti;

            var upitForm = new OdgovoriUpitForm(upit);
            upitForm.ShowDialog();
           

            

        }

        private void PregledUpitaForm_Load(object sender, EventArgs e)
        {
            var upiti = _db.Upitis.ToList();
            dgvUpiti.DataSource = upiti;
        }
    }
}
