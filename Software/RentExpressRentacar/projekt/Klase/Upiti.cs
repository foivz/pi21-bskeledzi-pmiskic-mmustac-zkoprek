using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt.Klase
{
    public class Upiti
    {
        public string Predmet { get; set; }
        public string Email { get; set; }
        public string Opis { get; set; }
        public Upiti(string predmet, string email, string opis)
        {
            Predmet = predmet;
            Email = email;
            Opis = opis;
        }

        public Upiti()
        {
        }
    }
}
