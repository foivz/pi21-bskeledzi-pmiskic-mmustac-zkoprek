using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Rezervacija
    {
        public DateTime Datum { get; set; }
        public Rezervacija(DateTime datum)
        {
            Datum = datum;
        }
        public void DohvatiRezervaciju()
        {
            //Dohvaća rezervaciju
        }
    }
}
