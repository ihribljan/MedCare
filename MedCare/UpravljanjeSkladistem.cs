using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedCare
{
    public class UpravljanjeSkladistem
    {
        public List<SkladisteItem> PrikaziSkladiste()
        {
            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Proizvodi
                           join it in db.TipProizvoda on item.TipProizvodaId equals it.Id
                           orderby item.Naziv ascending
                           where item.TipProizvodaId == 3 || item.TipProizvodaId == 8 
                           select new SkladisteItem
                           {
                               Naziv = item.Naziv,
                               KolicinaSkladiste = item.KolicinaSkladiste
                           };

                if(upit != null)
                {
                    return upit.ToList<SkladisteItem>();
                }
            }

            return new List<SkladisteItem>();
        }

        public void DodajNarudžbenicu(string poslovniPartner, string zaposlenik, decimal ukupanIznos)
        { 
            int id = 0;

            using (var db = new MedCareEntities())
            {
                id = db.Narudžbenice.Max(o => o.Id) + 1;

                var upit = (from item in db.PoslovniPartneri
                            where poslovniPartner == item.Naziv
                            select item.Id).Max();

                var zap = (from it in db.Zaposlenici
                           where it.Ime + " " + it.Prezime == zaposlenik
                           select it.Id).Max();

                Narudžbenice narudžbenice = new Narudžbenice
                {
                    Datum = DateTime.Now,
                    PoslovniPartneriId = upit,
                    ZaposleniciId = zap,
                    Iznos = (decimal)ukupanIznos
                };

                Console.WriteLine("NARUDŽBENICA UNOS: " + upit + zap);

                db.Narudžbenice.Add(narudžbenice);
                db.SaveChanges();
            }
        }

        public void DodajStavku(string naziv, int kolicina)
        {
            /* za svaki red u dgvu: -> uzmi max id narudžbenice + 1
             *                      -> uzmi naziv proizvoda, join s proizvoda i vrati idProizvoda
             *                      -> uzmi količinu iz txtKolicina
             *                      -> u sumu += stavljaj kol * cijena (iznos narudžbenice)
             * 
             * prije toga napravi novu narudžbenicu
             * */

            int idProizvoda = 0;
            int idNarudzbenice = 0;

            using (var db = new MedCareEntities())
            {
                idNarudzbenice = db.Narudžbenice.Max(p => p.Id);

                var upit = (from item in db.Proizvodi
                            where item.Naziv == naziv
                            select item.Id).Max();

                idProizvoda = upit;

                Console.WriteLine("UNOS: " + idNarudzbenice + " " + idProizvoda + " " + kolicina);

                NarudžbenicaStavke narudžbenicaStavke = new NarudžbenicaStavke
                {
                    NarudžbeniceId = idNarudzbenice,
                    ProizvodiId = idProizvoda,
                    Količina = kolicina
                };

                db.NarudžbenicaStavke.Add(narudžbenicaStavke);
                db.SaveChanges();
            }
        }
    }
}
