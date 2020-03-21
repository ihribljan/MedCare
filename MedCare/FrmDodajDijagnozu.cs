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
    public partial class FrmDodajDijagnozu : Form
    {
        private Pacijenti odabraniPacijent { get; set; }
        UpravljanjeDijagnozama upravljanjeDijagnozama = new UpravljanjeDijagnozama();

        public FrmDodajDijagnozu(Pacijenti pacijenti)
        {
            InitializeComponent();
            odabraniPacijent = pacijenti;
            PopuniBolesti();
        }

        private void FrmDodajDijagnozu_Load(object sender, EventArgs e)
        {
            PopuniBolesti();
            txtImePacijenta.Text = odabraniPacijent.Ime + " " + odabraniPacijent.Prezime;
            txtLijecnik.Text = Session.PrijavljeniZaposlenik.Ime + " " + Session.PrijavljeniZaposlenik.Prezime;
            Console.WriteLine("AAA" + txtLijecnik.Text);
        }

        public void PopuniBolesti()
        {
            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Bolesti
                           select item;

                if (upit != null)
                {
                    cmbBolest.DataSource = upit.ToList<Bolesti>();
                    cmbBolest.ValueMember = "Id";
                    cmbBolest.DisplayMember = "Naziv";
                }
            }
        }

        private void btnDodajDijagnozu_Click(object sender, EventArgs e)
        {
            upravljanjeDijagnozama.DodajDijagnozu(odabraniPacijent.Id, Convert.ToInt32(cmbBolest.SelectedValue), Session.PrijavljeniZaposlenik.Id, txtNapomena.Text);
            MessageBox.Show("Dijagnoza uspješno dodana!");
            this.Close();

        }
    }
}
