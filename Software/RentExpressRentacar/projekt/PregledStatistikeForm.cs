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
            var automobili = _db.Automobils.ToList();
            List<int> brojMarki = new List<int>();
            var broj = automobili.GroupBy(i => i.marka);
            foreach (var grp in broj)
            {
                chartStatistika.Series[0].Points.AddXY(grp.Key, grp.Count());
            }
        }
    }
}
