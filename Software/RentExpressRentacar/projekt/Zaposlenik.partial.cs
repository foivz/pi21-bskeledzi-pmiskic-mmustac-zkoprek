using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    partial class Zaposlenik
    {
        public override string ToString() => this.ime + " " + this.prezime + " - " + this.OIB;
    }
}
