using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public Ugovor Ugovor { get; set; }
        public TipKorisnika TipKorisnika { get; set; }
        public Spol Spol { get; set; }
        public string BrojTelefona { get; set; }
        public Zaposlenik(string ime, string prezime, string oib, Ugovor ugovor, TipKorisnika tipKorisnika, Spol spol, string brojTelefona)
        {
            Ime = ime;
            Prezime = prezime;
            Oib = oib;
            Ugovor = ugovor;
            TipKorisnika = tipKorisnika;
            Spol = spol;
            BrojTelefona = brojTelefona;
        }
        public void DohvatiZaposlenika(string oib)
        {
            //dohvaćanje zaposlenika
        }
    }
}
