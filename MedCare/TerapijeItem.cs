using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class TerapijeItem
    {
        [DisplayName("LIJEK")]
        public string ProizvodNaziv { get; set; }

        [DisplayName("DIJAGNOZA")]
        public string DijagnozaNaziv { get; set; }

        [DisplayName("PREPORUKA")]
        public string Preporuka { get; set; }
    }
}
