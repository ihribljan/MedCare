//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class vStavkeNarudzbenice
    {
        public int Id { get; set; }
        public int NarudžbeniceId { get; set; }
        public string Naziv { get; set; }
        public int Količina { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public Nullable<decimal> IznosStavke { get; set; }
        public Nullable<decimal> Iznos { get; set; }
    }
}
