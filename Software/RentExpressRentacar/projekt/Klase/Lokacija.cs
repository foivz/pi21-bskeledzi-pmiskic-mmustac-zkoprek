using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Lokacija
    {
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public Lokacija(string grad, string adresa)
        {
            Grad = grad;
            Adresa = adresa;
        }
        public void DohvatiSveLokacije()
        {
            //Dohvaća sve lokacije iz liste
        }

        
    }
}
