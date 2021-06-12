using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Kupac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public string VozackaDozvola { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
        public Kupac(string ime, string prezime, string oib, string vozackaDozvola, NacinPlacanja nacinPlacanja)
        {
            Ime = ime;
            Prezime = prezime;
            Oib = oib;
            VozackaDozvola = vozackaDozvola;
            NacinPlacanja = nacinPlacanja;
        }
        public void DohvatiKupca(string oib)
        {
            //Dohvaća kupca
        }
    }
}
