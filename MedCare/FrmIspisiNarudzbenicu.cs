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
    public partial class FrmIspisiNarudzbenicu : Form
    {
        public Narudžbenice narudzbenice { get; set; }

        public FrmIspisiNarudzbenicu(Narudžbenice _odabranaNarudzbenica)
        {
            InitializeComponent();
            this.narudzbenice = _odabranaNarudzbenica;
        }

        public string eks = "";
        public string path = @"C:\Users\Ivan\Desktop\";

        public void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("narudzbenica: " + narudzbenice.Id + " " + narudzbenice.Datum + " " + narudzbenice.Iznos);
            Console.WriteLine("id pp: " + narudzbenice.PoslovniPartneriId);

            using (var context = new MedCareEntities())
            {
                var load = from z in context.Narudžbenice
                           where z.Id == narudzbenice.Id
                           select z;

                narudzbenice = load.First();

                eks = narudzbenice.PoslovniPartneri.Naziv + " - " + narudzbenice.Datum.ToShortDateString();
                path += eks + ".pdf";

                Console.WriteLine("narudzbenica: " + narudzbenice.Id + " " + narudzbenice.Datum + " " + narudzbenice.Iznos);
                Console.WriteLine("id pp: " + narudzbenice.PoslovniPartneriId);

                var upitZaposlenici = from item in context.Zaposlenici
                                      join i in context.Narudžbenice on item.Id equals i.ZaposleniciId
                                      select item;

                Zaposlenici zaposlenici = upitZaposlenici.FirstOrDefault();
                zaposleniciBindingSource.DataSource = zaposlenici;

                var upitPoslovniPartneri = from it in context.PoslovniPartneri
                                           where it.Id == narudzbenice.PoslovniPartneriId
                                           select it;

                PoslovniPartneri poslovniPartneri = upitPoslovniPartneri.FirstOrDefault();
                poslovniPartneriBindingSource.DataSource = poslovniPartneri;
                
                var upitNarudzbenice = from o in context.Narudžbenice
                                       where o.Id == narudzbenice.Id
                                       select o;

                if (upitNarudzbenice != null)
                {
                    Narudžbenice narudžbenice = upitNarudzbenice.FirstOrDefault();
                    narudžbeniceBindingSource.DataSource = narudžbenice;
                }

                var upitNarudzbeniceStavke = from t in context.NarudžbenicaStavke
                                             join tt in context.Proizvodi on t.ProizvodiId equals tt.Id
                                             join z in context.Narudžbenice on t.NarudžbeniceId equals z.Id
                                             where z.Id == narudzbenice.Id
                                             select t;

                List<NarudžbenicaStavke> sveStavke = upitNarudzbeniceStavke.ToList();
                narudžbenicaStavkeBindingSource.DataSource = sveStavke;

                var upitProizvodi = from w in context.Proizvodi
                                    join ww in context.NarudžbenicaStavke on w.Id equals ww.ProizvodiId
                                    where ww.NarudžbeniceId == narudzbenice.Id
                                    select w;

                List <Proizvodi> sviProizvodi = upitProizvodi.ToList();
                proizvodiBindingSource.DataSource = sviProizvodi;
            }

            this.reportViewer1.RefreshReport();

            SavePDF(reportViewer1, path);
        }
    }
}
