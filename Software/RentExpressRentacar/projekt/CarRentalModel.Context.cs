﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarRentalEntities : DbContext
    {
        public CarRentalEntities()
            : base("name=CarRentalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Automobil> Automobils { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Iznajmljivanje> Iznajmljivanjes { get; set; }
        public virtual DbSet<Kupac> Kupacs { get; set; }
        public virtual DbSet<Lokacija> Lokacijas { get; set; }
        public virtual DbSet<Oprema> Opremas { get; set; }
        public virtual DbSet<OpremaAutomobila> OpremaAutomobilas { get; set; }
        public virtual DbSet<Osiguranje> Osiguranjes { get; set; }
        public virtual DbSet<OsiguranjeIznajmljivanja> OsiguranjeIznajmljivanjas { get; set; }
        public virtual DbSet<Poduzece> Poduzeces { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<RezervacijaOpreme> RezervacijaOpremes { get; set; }
        public virtual DbSet<TipOpreme> TipOpremes { get; set; }
        public virtual DbSet<TipZaposlenika> TipZaposlenikas { get; set; }
        public virtual DbSet<Ugovor> Ugovors { get; set; }
        public virtual DbSet<Upiti> Upitis { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }
        public virtual DbSet<ZaposlenikUloge> ZaposlenikUloges { get; set; }
    }
}
