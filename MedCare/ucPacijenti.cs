using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedCare
{
    public partial class ucPacijenti : UserControl
    {
        private static ucPacijenti _instance;

        public static ucPacijenti Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucPacijenti();
                }

                return _instance;
            }
        }

        public ucPacijenti()
        {
            InitializeComponent();
        }

        UpravljanjePacijentima upravljanjePacijentima = new UpravljanjePacijentima();
        UpravljanjeRacunima upravljanjeRacunima = new UpravljanjeRacunima();
        UpravljanjeDijagnozama upravljanjeDijagnozama = new UpravljanjeDijagnozama();
        UpravljanjeTerapijama upravljanjeTerapijama = new UpravljanjeTerapijama();

        public Pacijenti selektiraniPacijent { get; set; }
        public Racuni selektiraniRacun { get; set; }
        public DijagnozeItem dijagnoze { get; set; }

        public void PrikaziListuPacijenata()
        {
            dgvListaPacijenata.DataSource = null;
            dgvListaPacijenata.AutoGenerateColumns = false;
            dgvListaPacijenata.DataSource = upravljanjePacijentima.DohvatiPacijente(FrmMain.zaposlenik);
        }

        private void ucPacijenti_Load(object sender, EventArgs e)
        {
            PrikaziListuPacijenata();
            PrikaziDijagnoze();
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            dgvListaPacijenata.AutoGenerateColumns = false;
            dgvListaPacijenata.DataSource = upravljanjePacijentima.TraziPacijenta(txtPretrazi.Text);

            if (txtPretrazi.Text == "")
            {
                PrikaziListuPacijenata();
            }
        }

        private void btnNoviPacijent_Click(object sender, EventArgs e)
        {
            FrmDodajPromijeniPacijenta frmDodajPromijeniPacijenta = new FrmDodajPromijeniPacijenta();

            frmDodajPromijeniPacijenta.Show();
        }

        private void btnObrisiPacijenta_Click(object sender, EventArgs e)
        {
            upravljanjePacijentima.ObrisiPacijenta(selektiraniPacijent);
            PrikaziListuPacijenata();
        }

        private void dgvListaPacijenata_SelectionChanged(object sender, EventArgs e)
        {
            selektiraniPacijent = dgvListaPacijenata.CurrentRow.DataBoundItem as Pacijenti;
            PrikaziDijagnoze();
        }

        public void PrikaziRacune()
        {
            dgvRacuni.DataSource = null;
            dgvRacuni.AutoGenerateColumns = false;
            dgvRacuni.DataSource = upravljanjeRacunima.DohvatiRacune(selektiraniPacijent);
        }

        public void PrikaziDijagnoze()
        {
            dgvTerapije.DataSource = null;

            dijagnoze = null;
            Console.WriteLine("broj terapija: " + dgvTerapije.RowCount);

            dgvDijagnoze.DataSource = null;
            dgvDijagnoze.AutoGenerateColumns = false;
            dgvDijagnoze.DataSource = upravljanjeDijagnozama.DohvatiDijagnoze(selektiraniPacijent);

            PrikaziTerapije();
        }

        private void dgvDijagnoze_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDijagnoze.CurrentRow != null)
            {
                dijagnoze = dgvDijagnoze.CurrentRow.DataBoundItem as DijagnozeItem;
            }
            PrikaziTerapije();
        }

        public void PrikaziTerapije()
        {
            dgvTerapije.DataSource = null;
            dgvTerapije.AutoGenerateColumns = false;
            if (dijagnoze != null)
            {
                dgvTerapije.DataSource = upravljanjeTerapijama.DohvatiTerapije(dijagnoze);
            }
        }

        private void tcPacijenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcPacijenti.SelectedTab == tcPacijenti.TabPages["tpRacuni"])
            {
                PrikaziRacune();
            }
        }

        private void btnNoviRacun_Click(object sender, EventArgs e)
        {
            FrmDodajRacun frmDodajRacun = new FrmDodajRacun();
            frmDodajRacun.Show();
        }

        private void dgvRacuni_SelectionChanged(object sender, EventArgs e)
        {
            selektiraniRacun = dgvRacuni.CurrentRow.DataBoundItem as Racuni;
        }

        private void btnObrisiRacun_Click(object sender, EventArgs e)
        {
            upravljanjeRacunima.ObrisiRacun(selektiraniRacun);
            PrikaziRacune();
        }

        private void btnGenerirajRacun_Click(object sender, EventArgs e)
        {
            FrmGeneniraniRacun frmGeneniraniRacun = new FrmGeneniraniRacun(selektiraniRacun);
            frmGeneniraniRacun.Show();
        }

        private void btnDodajDijagnozu_Click(object sender, EventArgs e)
        {
            FrmDodajDijagnozu frm = new FrmDodajDijagnozu(selektiraniPacijent);
            frm.ShowDialog();
            PrikaziDijagnoze();
        }

        private void btnDodajTerapiju_Click(object sender, EventArgs e)
        {
            FrmDodajTerapiju f = new FrmDodajTerapiju(dijagnoze);
            f.ShowDialog();
            PrikaziTerapije();
        }
    }
}