using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class DijagnozeItem
    {
        public int Id { get; set; }

        [DisplayName("DATUM")]
        public DateTime Datum { get; set; }

        [DisplayName("PACIJENT")]
        public string PacijentiImePrezime { get; set; }

        [DisplayName("BOLEST")]
        public string BolestiNaziv { get; set; }

        [DisplayName("ZAPOSLENIK")]
        public string ZaposleniciImePrezime { get; set; }

        [DisplayName("NAPOMENA")]
        public string Napomena { get; set; }
    }
}
