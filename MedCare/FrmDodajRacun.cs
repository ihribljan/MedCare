using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class FrmDodajRacun : Form
    {

        private Pacijenti izdajeSePacijentu { get; set; }
        private Zaposlenici izdajeLijecnik { get; set; }

        UpravljanjeRacunima upravljanjeRacunima = new UpravljanjeRacunima();

        public FrmDodajRacun()
        {
            InitializeComponent();
            izdajeSePacijentu = ucPacijenti.Instance.selektiraniPacijent;
            izdajeLijecnik = FrmMain.zaposlenik;
        }

        private void FrmDodajRacun_Load(object sender, EventArgs e)
        {
            lblTrenutniDatumRacuna.Text = DateTime.Now.ToShortDateString();
            lblIzdaoLijecnik.Text = izdajeLijecnik.Ime + " " + izdajeLijecnik.Prezime;
            lblIzdajePacijentu.Text = izdajeSePacijentu.Ime + " " + izdajeSePacijentu.Prezime;

            PopuniProizvode();
        }

        private void PopuniProizvode()
        {
            dgvProizvodi.DataSource = null;
            dgvProizvodi.AutoGenerateColumns = false;
            dgvProizvodi.DataSource = upravljanjeRacunima.DohvatiSveProizvode();
        }

        private void btnSpremiRacun_Click(object sender, EventArgs e)
        {
            decimal ukupanIznos = 0;
            List<Proizvodi> oznaceniProizvodi = new List<Proizvodi>();
            List<decimal> kolicinaProizvoda = new List<decimal>();

            foreach (DataGridViewRow row in dgvProizvodi.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells["Dodaj"];
                var trenutniProizvod = row.DataBoundItem as Proizvodi;

                 decimal cijena = Convert.ToDecimal(row.Cells[2].Value);
                 decimal kolicina = Convert.ToDecimal(row.Cells[3].Value);
                 ukupanIznos += cijena * kolicina;
                 oznaceniProizvodi.Add(trenutniProizvod);
                 kolicinaProizvoda.Add(kolicina);

                lblTrenutniIznos.Text = ukupanIznos.ToString();
            }

            upravljanjeRacunima.KreirajNoviRacun(izdajeSePacijentu, izdajeLijecnik, ukupanIznos, oznaceniProizvodi);

            this.Close();
        }
    }
}