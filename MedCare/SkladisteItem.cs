using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class SkladisteItem
    {
        [DisplayName("NAZIV")]
        public string Naziv { get; set; }

        [DisplayName("KOLIČINA")]
        public int KolicinaSkladiste { get; set; }
    }
}
