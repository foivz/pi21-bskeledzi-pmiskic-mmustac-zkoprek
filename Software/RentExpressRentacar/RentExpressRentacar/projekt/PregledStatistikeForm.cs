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
    public partial class PregledStatistikeForm : Form
    {
        private readonly CarRentalEntities _db;
        public PregledStatistikeForm()
        {
            InitializeComponent();
            _db = new CarRentalEntities();
        }

        private void PregledStatistikeForm_Load(object sender, EventArgs e)
        {
            

            var automobili = new List<Automobil>();

            using(var context = new CarRentalEntities())
            {
                var query = from a in context.Automobils
                            where a.idPoduzeca == InfoPoduzeca.idPoduzeca
                            select a;
                automobili = query.ToList();
            }
            
            List<int> brojMarki = new List<int>();
            var broj = automobili.GroupBy(i => i.marka);
            foreach (var grp in broj)
            {
                chartStatistika.Series[0].Points.AddXY(grp.Key, grp.Count());
            }
        }
    }
}
