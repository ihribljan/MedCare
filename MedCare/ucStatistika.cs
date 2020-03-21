using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MedCare
{
    public partial class ucStatistika : UserControl
    {
        List<decimal> lista = new List<decimal>();
        decimal ukupanPrihod = 0m;
        decimal ukupanRashod = 0m;
        string datumOd, datumDo, dan = String.Empty;
        DateTime a, b;

        public DateTime dateOd;
        public DateTime dateDo;

        public DateTime dateToday = DateTime.Now;

        List<decimal> listaPrihoda = new List<decimal>();
        List<decimal> listaRashoda = new List<decimal>();

        private static ucStatistika _instance;

        public static ucStatistika Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucStatistika();
                }

                return _instance;
            }
        }

        public ucStatistika()
        {
            InitializeComponent();

            Console.WriteLine("TEST :" + datumOd + " " + datumDo);
            Console.WriteLine(dateToday.ToShortDateString());
            AzurirajDatumeRacuna();
            AzurirajDatumeNarudzbenica();
        }

        private void ucStatistika_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;

            chart1.Titles.Add("Prihod i rashod razdoblja");
            chart2.Titles.Add("Prihod i rashod razdoblja");

            chart1.Series["Prihod"].IsValueShownAsLabel = true;
            chart1.Series["Rashod"].IsValueShownAsLabel = true;

            chart2.Series["Prihod"].IsValueShownAsLabel = true;
            chart2.Series["Rashod"].IsValueShownAsLabel = true;

            chart1.AlignDataPointsByAxisLabel();
            chart2.AlignDataPointsByAxisLabel();

            dtpOd.MinDate = new DateTime(2019, 8, 19);
            dtpDo.MaxDate = DateTime.Today;
        }

        public DateTime dateMinRacuni;
        public DateTime dateMaxRacuni;
        public DateTime dateMinNarudzbenice;
        public DateTime dateMaxNarudzbenice;

        public void AzurirajDatumeRacuna()
        {
            using (var db = new MedCareEntities())
            {
                var upitMaxRacuni = (from item in db.Racuni
                                     select item).Max(x => x.Datum);

                var upitDanasRacuni = DateTime.Now;

                dateMinRacuni = upitMaxRacuni;
                dateMaxRacuni = upitDanasRacuni;
                DateTime sljedeci = dateMinRacuni;

                do
                {
                    Console.WriteLine(sljedeci);

                    if (db.Racuni.Any(x => x.Datum == sljedeci))
                    {
                        Console.WriteLine("Postoji!" + sljedeci);
                    }
                    else
                    {
                        Racuni racuni = new Racuni
                        {
                            Datum = sljedeci,
                            PacijentiId = 23,
                            ZaposleniciId = 7,
                            Iznos = 0
                        };

                        db.Racuni.Add(racuni);
                        db.SaveChanges();

                        Console.WriteLine(sljedeci + " AA");
                    }

                    sljedeci = sljedeci.AddDays(1);
                }
                while (sljedeci < dateMaxRacuni);
            }
        }

        public void AzurirajDatumeNarudzbenica()
        {
            using (var db = new MedCareEntities())
            {
                var upitMinNarudzbenice = (from item in db.Narudžbenice
                                           select item).Max(x => x.Datum);

                var upitMaxNarudzbenice = DateTime.Now;

                dateMinNarudzbenice = upitMinNarudzbenice;
                dateMaxNarudzbenice = upitMaxNarudzbenice;
                DateTime sljedeci = dateMinNarudzbenice.AddDays(1);

                do
                {
                    sljedeci = sljedeci.AddDays(1);

                    Console.WriteLine(sljedeci);

                    if (db.Narudžbenice.Any(x => x.Datum == sljedeci))
                    {
                        Console.WriteLine("Postoji! " + sljedeci);
                    }
                    else
                    {
                        Narudžbenice narudžbenice = new Narudžbenice
                        {
                            Datum = sljedeci,
                            PoslovniPartneriId = 4,
                            ZaposleniciId = 7,
                            Iznos = 0
                        };

                        db.Narudžbenice.Add(narudžbenice);
                        db.SaveChanges();

                        Console.WriteLine(sljedeci + " AA");
                    }
                }
                while (sljedeci < dateMaxNarudzbenice);
            }
        }

        private void btnStupcasti_Click(object sender, EventArgs e)
        {
            btnStupcasti.BackColor = Color.DarkGray;
            btnLinijski.BackColor = System.Drawing.SystemColors.Control;
            chart2.SendToBack();
        }

        private void btnLinijski_Click(object sender, EventArgs e)
        {
            LinijskiGrafikon();
            chart1.SendToBack();
            btnLinijski.BackColor = Color.DarkGray;
            Console.WriteLine("datumi a: " + a + " " + b);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            StupcastiGrafikon();
        }

        public void StupcastiGrafikon()
        {
            chart2.SendToBack();
            btnLinijski.BackColor = System.Drawing.SystemColors.Control;

            dtpOd.Format = DateTimePickerFormat.Custom;
            dtpOd.CustomFormat = "yyyy-MM-dd";
            datumOd = dtpOd.Value.ToString("yyyy-MM-dd");

            dtpDo.Format = DateTimePickerFormat.Custom;
            dtpDo.CustomFormat = "yyyy-MM-dd";
            datumDo = dtpDo.Value.ToString("yyyy-MM-dd");

            a = DateTime.Parse(datumOd);
            b = DateTime.Parse(datumDo);

            Console.WriteLine("PROBA: " + dtpOd.Value.ToShortDateString() + " " + a.ToShortDateString());
            Console.WriteLine("PROBA: " + dtpDo.Value.ToShortDateString() + " " + b.ToShortDateString());

            ukupanPrihod = 0m;
            ukupanRashod = 0m;

            using (var db = new MedCareEntities())
            {
                var prihod = from p in db.Racuni
                             where p.Datum >= a && p.Datum < b
                             select p;

                if (prihod != null && prihod.Count() > 0)
                {
                    ukupanPrihod = prihod.Sum(x => x.Iznos);
                }

                Console.WriteLine("PRIHOD TEST: " + ukupanPrihod);

                var rashod = from p in db.Narudžbenice
                             where p.Datum >= a && p.Datum < b
                             select p;

                if (rashod != null && rashod.Count() > 0)
                {
                    ukupanRashod = (decimal)rashod.Sum(y => y.Iznos);
                }

                Console.WriteLine("RASHOD TEST: " + ukupanRashod);

                foreach (var series in chart1.Series)
                {
                    series.Points.Clear();
                }

                dateOd = DateTime.Parse(dtpOd.Value.ToString("yyyy-MM-dd"));
                dateDo = DateTime.Parse(dtpDo.Value.ToString("yyyy-MM-dd"));

                dan = dateOd.ToShortDateString();

                chart1.Series["Prihod"].Points.AddXY(dan, ukupanPrihod);
                chart1.Series["Rashod"].Points.AddXY(dan, ukupanRashod);

                label6.Text = "kn";

                if (ukupanPrihod >= ukupanRashod)
                {
                    label2.Text = "Prihod razdoblja:";
                    label3.Text = (ukupanPrihod - ukupanRashod).ToString();
                    label3.ForeColor = Color.FromArgb(46, 213, 115);
                }
                else
                {
                    label2.Text = "Gubitak razdoblja:";
                    label3.Text = (ukupanPrihod - ukupanRashod).ToString();
                    label3.ForeColor = Color.Red;
                }
            }
        }

        private void dtpOd_ValueChanged(object sender, EventArgs e)
        {
            dtpDo.Value = dtpOd.Value.AddDays(1);
        }

        public void LinijskiGrafikon()
        {
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }

            btnLinijski.BackColor = System.Drawing.SystemColors.Control;
            btnStupcasti.BackColor = System.Drawing.SystemColors.Control;

            Console.WriteLine("TEST DATUMA: " + datumOd + " " + datumDo);

            using (var db = new MedCareEntities())
            {
                var prihod = from item in db.Racuni
                             where item.Datum >= a && item.Datum <= b
                             group item by item.Datum into g
                             select new
                             {
                                 Iznos = g.Sum(x => x.Iznos)
                             };

                var rashod = from it in db.Narudžbenice
                             where it.Datum >= a && it.Datum <= b
                             group it by it.Datum into h
                             select new
                             {
                                 Iznos = h.Sum(y => y.Iznos)
                             };

                if (prihod != null && prihod.Count() > 0)
                {
                    foreach (var it in prihod)
                    {
                        listaPrihoda.Add((decimal)it.Iznos);
                        Console.WriteLine("PRIHOD::: " + it.Iznos);
                        datumOd = dateOd.ToShortDateString();
                        chart2.Series["Prihod"].Points.AddXY(datumOd, (decimal)it.Iznos);
                        dateOd = dateOd.AddDays(1);
                    }
                }

                if (rashod != null && rashod.Count() > 0)
                {
                    foreach (var i in rashod)
                    {
                        listaRashoda.Add((decimal)i.Iznos);
                        Console.WriteLine("RASHOD::: " + i.Iznos);
                        chart2.Series["Rashod"].Points.AddY((decimal)i.Iznos);
                    }
                }
            }
        }
    }
}
