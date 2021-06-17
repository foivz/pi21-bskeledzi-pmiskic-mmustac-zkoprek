using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class SuperAdminForm : Form
    {
        private readonly CarRentalEntities _db;
        public SuperAdminForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void SuperAdminForm_Load(object sender, EventArgs e)
        {
            UcitajZaposlenike();
            UcitajPoduzeca();
        }

        private void UcitajZaposlenike()
        {
            cmbZaposlenici.Items.Clear();
            List<Zaposlenik> sviZaposlenici = _db.Zaposleniks.ToList();
            foreach (var zaposlenik in sviZaposlenici)
            {
                if (zaposlenik.idPoduzeca == null)
                    cmbZaposlenici.Items.Add(zaposlenik);
            }
        }

        private void UcitajPoduzeca()
        {
            cmbPoduzeca.DataSource = null;
            cmbPoduzeca.DataSource = _db.Poduzeces.ToList();
        }

        private void DodajPoduzece()
        {
            Poduzece novoPoduzece = new Poduzece
            {
                nazivPoduzeca = tbImePoduzeca.Text
            };

            _db.Poduzeces.Add(novoPoduzece);
            _db.SaveChanges();
        }
        
        private void SpremiKorisnikuPoduzece()
        {
            Zaposlenik zaposlenik = cmbZaposlenici.SelectedItem as Zaposlenik;
            int idPoduzeca = (cmbPoduzeca.SelectedItem as Poduzece).id;

            zaposlenik.idPoduzeca = idPoduzeca;

            _db.SaveChanges();
        }

        private void btnDodijeliAdmina_Click(object sender, EventArgs e)
        {
            SpremiKorisnikuPoduzece();
            UcitajZaposlenike();
            UcitajPoduzeca();
        }

        private void btnSpremiPoduzece_Click(object sender, EventArgs e)
        {
            DodajPoduzece();
            UcitajPoduzeca();
            tbImePoduzeca.Text = "";
        }

        private void btnDodajZaposlenika_Click(object sender, EventArgs e)
        {
            DodajZaposlenikaForm dzf = new DodajZaposlenikaForm();
            dzf.ShowDialog();
            UcitajZaposlenike();
        }
    }

}
