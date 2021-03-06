//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projekt
{
    using System;
    using System.Collections.Generic;
    
    public partial class Iznajmljivanje
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Iznajmljivanje()
        {
            this.OsiguranjeIznajmljivanjas = new HashSet<OsiguranjeIznajmljivanja>();
        }
    
        public int id_iznajmljivanje { get; set; }
        public int id_kupac { get; set; }
        public int id_automobil { get; set; }
        public System.DateTime pocetni_datum { get; set; }
        public System.DateTime zavrsni_datum { get; set; }
        public int lokacija_preuzimanja { get; set; }
        public int lokacija_vracanja { get; set; }
    
        public virtual Automobil Automobil { get; set; }
        public virtual Kupac Kupac { get; set; }
        public virtual Lokacija Lokacija { get; set; }
        public virtual Lokacija Lokacija1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OsiguranjeIznajmljivanja> OsiguranjeIznajmljivanjas { get; set; }
    }
}
