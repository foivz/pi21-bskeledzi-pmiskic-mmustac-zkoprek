using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Automobil
    {
        public string Oznaka { get; set; }
        public string Naziv { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }
        public string Boja { get; set; }
        public Osiguranje Osiguranje { get; set; }
        public Automobil(string oznaka, string naziv, string marka, string model, int godinaProizvodnje, string boja, Osiguranje osiguranje)
        {
            Oznaka = oznaka;
            Naziv = naziv;
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Boja = boja;
            Osiguranje = osiguranje;
        }
        public void DohvatiAutomobil(string oznaka)
        {
            //Dohvača automobil
        }
        public void DohvatiSveAutomobile()
        {
            //Dohvaća sve automobile iz liste
        }
    }
}
