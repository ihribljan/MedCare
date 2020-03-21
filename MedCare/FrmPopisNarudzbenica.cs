using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class FrmPopisNarudzbenica : Form
    {
        public Narudžbenice odabranaNarudzbenica = new Narudžbenice();
        int id = 0;
   
        public FrmPopisNarudzbenica()
        { 
            InitializeComponent();
        }

        private void FrmSveNarudzbenice_Load(object sender, EventArgs e)
        {
            PrikaziNarudzbenice();
        }

        public List<Narudžbenice> PrikaziNarudzbenice()
        {
            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Narudžbenice
                           join it in db.PoslovniPartneri on item.PoslovniPartneriId equals it.Id
                           join z in db.Zaposlenici on item.ZaposleniciId equals z.Id
                           where item.Iznos != 0
                           orderby item.Id descending
                           select new
                           {
                               Id = item.Id,
                               Datum = item.Datum,
                               PoslovniPartner = it.Naziv,
                               Zaposlenik = z.Ime + " " + z.Prezime,
                               Iznos = item.Iznos
                           };

                if(upit != null)
                {
                    dgvSveNarudzbenice.DataSource = upit.ToList();
                }

                return new List<Narudžbenice>();
            }
        }

        private void dgvSveNarudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSveNarudzbenice.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvSveNarudzbenice.CurrentRow.Cells[0].Value);
                Console.WriteLine("test: " + id);
                odabranaNarudzbenica.Id = id;
            }
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            FrmIspisiNarudzbenicu f = new FrmIspisiNarudzbenicu(odabranaNarudzbenica);
            Console.WriteLine("AAA: " + odabranaNarudzbenica.Id);
            f.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
