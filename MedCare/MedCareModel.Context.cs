﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedCare
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedCareEntities : DbContext
    {
        public MedCareEntities()
            : base("name=MedCareEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bolesti> Bolesti { get; set; }
        public virtual DbSet<Dijagnoze> Dijagnoze { get; set; }
        public virtual DbSet<Narudžbe> Narudžbe { get; set; }
        public virtual DbSet<NarudžbenicaStavke> NarudžbenicaStavke { get; set; }
        public virtual DbSet<Narudžbenice> Narudžbenice { get; set; }
        public virtual DbSet<Pacijenti> Pacijenti { get; set; }
        public virtual DbSet<PoslovniPartneri> PoslovniPartneri { get; set; }
        public virtual DbSet<Proizvodi> Proizvodi { get; set; }
        public virtual DbSet<Racuni> Racuni { get; set; }
        public virtual DbSet<RadnoMjesto> RadnoMjesto { get; set; }
        public virtual DbSet<Recepti> Recepti { get; set; }
        public virtual DbSet<StavkeRacuna> StavkeRacuna { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Terapije> Terapije { get; set; }
        public virtual DbSet<TipProizvoda> TipProizvoda { get; set; }
        public virtual DbSet<TipZaposlenika> TipZaposlenika { get; set; }
        public virtual DbSet<Zaposlenici> Zaposlenici { get; set; }
        public virtual DbSet<vStavkeNarudzbenice> vStavkeNarudzbenice { get; set; }
    }
}