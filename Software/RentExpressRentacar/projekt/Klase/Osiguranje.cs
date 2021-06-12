using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Osiguranje
    {
        public string Opis { get; set; }
        public double Cijena { get; set; }
        public string PolicaOsiguranja { get; set; }
        public string Naziv { get; set; }
        public Osiguranje(string opis, double cijena, string policaOsiguranja, string naziv)
        {
            Opis = opis;
            Cijena = cijena;
            PolicaOsiguranja = policaOsiguranja;
            Naziv = naziv;
        }
        public void DohvatiOsiguranje()
        {
            //Dohvaća osiguranje
        }
        public override string ToString()
        {
            return this.Naziv;
        }
    }
}
