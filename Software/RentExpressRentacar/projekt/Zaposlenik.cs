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
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.ZaposlenikUloges = new HashSet<ZaposlenikUloge>();
        }
    
        public int id_zaposlenik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string OIB { get; set; }
        public int ugovor_id { get; set; }
        public string korisnicko_ime { get; set; }
        public string lozinka { get; set; }
        public Nullable<int> pregled { get; set; }
        public Nullable<int> obavijesti { get; set; }
        public Nullable<int> dodavanje { get; set; }
        public Nullable<int> statistika { get; set; }
    
        public virtual Ugovor Ugovor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZaposlenikUloge> ZaposlenikUloges { get; set; }
    }
}
