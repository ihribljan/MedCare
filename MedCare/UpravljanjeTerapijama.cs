using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class UpravljanjeTerapijama
    {
        public List<TerapijeItem> DohvatiTerapije(DijagnozeItem dijagnoze)
        {
            Console.WriteLine("DIJAAGNOZE ID: " + dijagnoze.Id);

            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Terapije
                           join it in db.Proizvodi on item.ProizvodiId equals it.Id
                           join z in db.Dijagnoze on item.DijagnozeId equals z.Id
                           where item.DijagnozeId == dijagnoze.Id
                           select new TerapijeItem()
                           {
                               ProizvodNaziv = it.Naziv,
                               DijagnozaNaziv = z.Napomena,
                               Preporuka = item.Preporuka
                           };

                if (upit != null)
                {
                    Console.WriteLine("!!!!????");
                    foreach (var item in upit)
                    {
                        Console.WriteLine("UPIT");
                        Console.WriteLine(item.ProizvodNaziv + " " + item.DijagnozaNaziv + " " + item.Preporuka);
                    }
                    return upit.ToList<TerapijeItem>();
                }
            }
            return new List<TerapijeItem>();
        }

        public void DodajTerapiju(int ProizvodId, int DijagnozaId, string preporuka)
        {
            using (var db = new MedCareEntities())
            {
                Terapije terapije = new Terapije
                {
                    ProizvodiId = ProizvodId,
                    DijagnozeId = DijagnozaId,
                    Preporuka = preporuka
                };

                db.Terapije.Add(terapije);
                db.SaveChanges();
            }
        }
    }
}
