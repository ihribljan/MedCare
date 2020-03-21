using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class NarudzbenicaItem
    {
        public int Id { get; set; }

        [DisplayName("NAZIV")]
        public string Naziv { get; set; }

        [DisplayName("CIJENA")]
        public double Cijena { get; set; }

        [DisplayName("KOLIČINA")]
        public double Kolicina { get; set; }

        [DisplayName("IZNOS")]
        public double Iznos
        {
            get
            {
                return Cijena * Kolicina;
            }
        }
    }
}
