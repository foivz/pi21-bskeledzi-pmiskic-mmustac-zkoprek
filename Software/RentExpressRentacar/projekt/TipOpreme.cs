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
    
    public partial class TipOpreme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipOpreme()
        {
            this.Opremas = new HashSet<Oprema>();
            this.RezervacijaOpremes = new HashSet<RezervacijaOpreme>();
            this.RezervacijaOpremes1 = new HashSet<RezervacijaOpreme>();
        }
    
        public int id_tip_opreme { get; set; }
        public string ime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oprema> Opremas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RezervacijaOpreme> RezervacijaOpremes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RezervacijaOpreme> RezervacijaOpremes1 { get; set; }
    }
}
