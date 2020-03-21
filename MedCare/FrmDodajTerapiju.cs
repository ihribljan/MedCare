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
    public partial class FrmDodajTerapiju : Form
    {
        private DijagnozeItem odabranaDijagnoza { get; set; }
        private Pacijenti odabraniPacijent { get; set; }
        UpravljanjeDijagnozama upravljanjeDijagnozama = new UpravljanjeDijagnozama();
        UpravljanjeTerapijama upravljanjeTerapijama = new UpravljanjeTerapijama();

        public FrmDodajTerapiju(DijagnozeItem dijagnoze)
        {
            InitializeComponent();
            odabranaDijagnoza = dijagnoze;
            PopuniLijekove();
            txtDijagnoza.Text = odabranaDijagnoza.BolestiNaziv;
        }

        private void FrmDodajTerapiju_Load(object sender, EventArgs e)
        {
            txtDijagnoza.Text = odabranaDijagnoza.Napomena;
        }

        public void PopuniLijekove()
        {
            using (var db = new MedCareEntities())
            {
                var upit = from item in db.Proizvodi
                           join it in db.TipProizvoda on item.TipProizvodaId equals it.Id
                           where it.Id == 3
                           select item;

                if (upit != null)
                {
                    cmbLijek.DataSource = upit.ToList<Proizvodi>();
                    cmbLijek.ValueMember = "Id";
                    cmbLijek.DisplayMember = "Naziv";
                }
            }
        }

        private void btnDodajTerapiju_Click(object sender, EventArgs e)
        {
            upravljanjeTerapijama.DodajTerapiju(((Proizvodi)cmbLijek.SelectedItem).Id, odabranaDijagnoza.Id, txtPreporuka.Text);
            MessageBox.Show("Terapija uspješno dodana!");
            this.Close();
        }
    }
}
