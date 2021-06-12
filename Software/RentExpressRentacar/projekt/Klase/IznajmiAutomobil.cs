using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class IznajmiAutomobil
    {
        public Kupac Kupac { get; set; }
        public Rezervacija Rezervacija { get; set; }
        public Lokacija Lokacija { get; set; }
        public Osiguranje Osiguranje { get; set; }
        public IznajmiAutomobil(Kupac kupac, Rezervacija rezervacija, Lokacija lokacija, Osiguranje osiguranje)
        {
            Kupac = kupac;
            Rezervacija = rezervacija;
            Lokacija = lokacija;
            Osiguranje = osiguranje;
        }
    }
}
