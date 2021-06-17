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
    public partial class PromijeniOvlastiForm : Form
    {
        Zaposlenik odabraniZaposlenik = null;
        public PromijeniOvlastiForm(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            if(zaposlenik.obavijesti == 1)
            {
                obavijestiDaRadio.Checked = true;
            }
            else
            {
                obavijestiNeRadio.Checked = true;
            }

            if(zaposlenik.pregled == 1)
                {
                    pregledDaRadio.Checked = true;
                }
            else
                {
                    pregledNeRadio.Checked = true;
                }
            if(zaposlenik.dodavanje == 1)
                {
                    dodavanjeDaRadio.Checked = true;
                }
             else
                {
                    dodavanjeNeRadio.Checked = true;
                }
            if(zaposlenik.statistika == 1)
                {
                    statistikaDaRadio.Checked = true;
                }
             else
                {
                    statistikaNeRadio.Checked = true;
                }
            odabraniZaposlenik = zaposlenik;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            using (var context = new CarRentalEntities())
            {
                int obavijesti;
                int pregled;
                int statistika;
                int dodavanje;
                context.Zaposleniks.Attach(odabraniZaposlenik);

                if (obavijestiDaRadio.Checked == true)
                {
                    obavijesti = 1;
                }
                else
                {
                    obavijesti = 0;
                }

                if (pregledDaRadio.Checked == true)
                {
                    pregled = 1;
                }
                else
                {
                    pregled = 0;
                }
                if (dodavanjeDaRadio.Checked == true)
                {
                    dodavanje = 1;
                }
                else
                {
                    dodavanje = 0;
                }
                if (statistikaDaRadio.Checked == true)
                {
                    statistika = 1;
                }
                else
                {
                    statistika = 0;
                }

                odabraniZaposlenik.obavijesti = obavijesti;
                odabraniZaposlenik.pregled = pregled;
                odabraniZaposlenik.statistika = statistika;
                odabraniZaposlenik.dodavanje = dodavanje;

                context.SaveChanges();
            }
            Close();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
