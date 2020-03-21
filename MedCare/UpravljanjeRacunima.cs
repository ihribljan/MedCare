using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public class UpravljanjeRacunima
    {
        public List<Racuni> DohvatiRacune(Pacijenti selektiraniPacijent)
        {
            List<Racuni> sviRacuni = new List<Racuni>();
            try
            {
                using (var db = new MedCareEntities())
                {
                    var querySviRacuni = from r in db.Racuni
                                         where r.PacijentiId == selektiraniPacijent.Id
                                         select r;

                    sviRacuni = querySviRacuni.ToList();
                }

                return sviRacuni;
            }
            catch(Exception e)
            {
                MessageBox.Show("Trenutni doktor nema dodanih pacijenata!" + "\nError: " + e.Message);
            }
            return sviRacuni;
            
        }

        public List<Proizvodi> DohvatiSveProizvode()
        {
            List<Proizvodi> sviProizvodi = new List<Proizvodi>();
            using (var db = new MedCareEntities())
            {
                var querySviProizvodi = from p in db.Proizvodi
                                        select p;

                sviProizvodi = querySviProizvodi.ToList();
            }

            return sviProizvodi;
        }

        public void ObrisiRacun(Racuni selektiraniRacun)
        {
            if (selektiraniRacun != null)
            {
                using (var db = new MedCareEntities())
                {
                    db.Racuni.Attach(selektiraniRacun);
                    db.Racuni.Remove(selektiraniRacun);
                    db.SaveChanges();
                }
            }
        }

        public void KreirajNoviRacun(Pacijenti izdajeSePacijentu, Zaposlenici izdajeLijecnik, decimal ukupanIznos, List<Proizvodi> oznaceniProizvodi)
        {
            using (var db = new MedCareEntities())
            {
                Racuni noviRacun = new Racuni
                {
                    Datum = DateTime.Parse(DateTime.Now.ToShortDateString()),
                    PacijentiId = izdajeSePacijentu.Id,
                    ZaposleniciId = izdajeLijecnik.Id,
                    Iznos = ukupanIznos
                };

                db.Racuni.Add(noviRacun);
                db.SaveChanges();

                foreach (var proizvod in oznaceniProizvodi)
                {
                    StavkeRacuna novaStavka = new StavkeRacuna
                    {
                        RačuniId = noviRacun.Id,
                        ProizvodiId = proizvod.Id
                    };

                    db.StavkeRacuna.Add(novaStavka);
                    db.SaveChanges();
                }
            }

            ucPacijenti.Instance.PrikaziRacune();
        }
    }
}
