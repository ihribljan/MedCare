using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class UpravljanjeDijagnozama
    {
        public List<DijagnozeItem> DohvatiDijagnoze(Pacijenti pacijenti)
        {
            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Dijagnoze
                           join it in db.Pacijenti on item.PacijentiId equals it.Id
                           join i in db.Bolesti on item.BolestiId equals i.Id
                           join z in db.Zaposlenici on item.ZaposleniciId equals z.Id
                           where item.PacijentiId == pacijenti.Id
                           select new DijagnozeItem()
                           {
                               Id  = item.Id,
                               Datum = item.Datum,
                               PacijentiImePrezime = it.Ime + " " + it.Prezime,
                               BolestiNaziv = i.Naziv,
                               ZaposleniciImePrezime = z.Ime + " " + z.Prezime,
                               Napomena = item.Napomena
                           };

                if (upit != null)
                {
                    foreach (var item in upit)
                    {
                        Console.WriteLine(item.Datum + " " + item.PacijentiImePrezime + " " + item.BolestiNaziv + " " + item.ZaposleniciImePrezime + " " + item.Napomena);
                    }
                    return upit.ToList<DijagnozeItem>();
                }

            }
            return new List<DijagnozeItem>();
        }

        public void DodajDijagnozu(int idPacijenta, int bolestiId, int zaposleniciId, string napomena)
        {
            Console.WriteLine(idPacijenta);
            using (var db = new MedCareEntities())
            {
                Dijagnoze dijagnoze = new Dijagnoze
                {
                    Datum = DateTime.Now,
                    PacijentiId = idPacijenta,
                    BolestiId = bolestiId,
                    ZaposleniciId = zaposleniciId,
                    Napomena = napomena
                };

                db.Dijagnoze.Add(dijagnoze);
                db.SaveChanges();
            }
        }
    }
}
