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
    public partial class FrmNarudzbenica : Form
    {
        UpravljanjeSkladistem UpravljanjeSkladistem = new UpravljanjeSkladistem();
        NarudzbenicaItem narudzbenicaItem = new NarudzbenicaItem();

        public FrmNarudzbenica()
        {
            InitializeComponent();
            this.ActiveControl = cmbPoslovniPartner;
        }

        private void FrmNarudzbenica_Load(object sender, EventArgs e)
        {
            cmbProizvod.DataSource = null;
            PopuniPartnere();
            txtZaposlenik.Text = Session.PrijavljeniZaposlenik.Ime + " " + Session.PrijavljeniZaposlenik.Prezime;
        }

        public void PopuniPartnere()
        {
            using (var db = new MedCareEntities())
            {
                var upit = (from item in db.PoslovniPartneri
                            orderby item.Naziv ascending
                            where item.Id != 3 && item.Id != 4
                            select item.Naziv).ToList();

                if(upit != null)
                {
                    cmbPoslovniPartner.DataSource = null;
                    cmbPoslovniPartner.DataSource = upit;
                }
            }
        }

        int brojStavke = 1;

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int d;

            if (!int.TryParse(txtKolicina.Text, out d))
            {
                MessageBox.Show("Pogrešan unos količine!");
                txtKolicina.Clear();
                return;
            }

            dgvNarudzbenica.Rows.Add(brojStavke, cmbProizvod.Text, txtKolicina.Text, txtCijena.Text);
            brojStavke++;

            txtKolicina.Clear();
        }

        private void cmbPoslovniPartner_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new MedCareEntities())
            {
                int id = 0;

                var upit = from item in db.PoslovniPartneri
                           where cmbPoslovniPartner.Text == item.Naziv
                           select item;

                if(upit != null)
                {
                    PoslovniPartneri poslovniPartneri = upit.First();
                    txtAdresa.Text = poslovniPartneri.Adresa;
                    txtEmail.Text = poslovniPartneri.Email;
                    txtKontakt.Text = poslovniPartneri.Kontakt;

                    id = poslovniPartneri.TipProizvodaId;
                    Console.WriteLine("ID: " + id);
                }
                
                var query = (from it in db.Proizvodi
                             where it.TipProizvodaId == id
                             orderby it.Naziv ascending
                             select it.Naziv).ToList();

                if(query != null)
                {
                    cmbProizvod.DataSource = null;
                    cmbProizvod.DataSource = query;
                }

                var cijena = (from itt in db.Proizvodi
                              where itt.Naziv == cmbProizvod.Text
                              select itt).ToList<Proizvodi>();

                Proizvodi proizvodi = cijena.FirstOrDefault();

                if(cijena != null)
                {
                    txtCijena.Text = proizvodi.Cijena.ToString();
                }
            }
        }

        private void cmbProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProizvod.SelectedIndex == -1)
            {
                txtCijena.Text = "0.00";
            }
            else
            {
                using (var db = new MedCareEntities())
                {
                    var upit = (from item in db.Proizvodi
                                where item.Naziv == cmbProizvod.Text
                                select item).ToList<Proizvodi>();

                    Proizvodi proizvodi = upit.FirstOrDefault();

                    if (upit != null)
                    {
                        txtCijena.Text = proizvodi.Cijena.ToString();
                    }
                }
            }
        }

        private void txtKolicina_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnDodaj.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        int stavka = 0;

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvNarudzbenica.SelectedRows)
            {
                stavka = item.Index;
                Console.WriteLine("STAVKA BROJ " + stavka);

                dgvNarudzbenica.Rows.RemoveAt(item.Index);
            }
        }

        private void btnZakljuciNarudzbenicu_Click(object sender, EventArgs e)
        {
            decimal iznos = 0;
            int r = 0;

            string kol = string.Empty;
            string cij = string.Empty;

            dgvNarudzbenica.Enabled = false;
            dgvNarudzbenica.RowsDefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvNarudzbenica.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewRow row in dgvNarudzbenica.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
                cij = dgvNarudzbenica.Rows[r].Cells["CIJENA"].Value.ToString();
                kol = dgvNarudzbenica.Rows[r].Cells["KOLICINA"].Value.ToString();

                iznos += decimal.Parse(cij) * decimal.Parse(kol);
                r++;

                Console.WriteLine("UKUPAN IZNOS NARUDŽBENICE: " + iznos);
            }

            cmbProizvod.Enabled = false;
            cmbPoslovniPartner.Enabled = false;
            btnDodaj.Enabled = false;
            btnObrisi.Enabled = false;
            txtKolicina.Enabled = false;
            txtCijena.Enabled = false;
            txtAdresa.Enabled = false;
            txtKontakt.Enabled = false;
            txtEmail.Enabled = false;

            Console.WriteLine("PP i ZAP " + cmbPoslovniPartner.Text + txtZaposlenik.Text);
            UpravljanjeSkladistem.DodajNarudžbenicu(cmbPoslovniPartner.Text, txtZaposlenik.Text, iznos);

            string proizvod = string.Empty;
            string kolicina = string.Empty;

            int red = 0;

            foreach (DataGridViewRow row in dgvNarudzbenica.Rows)
            {
                proizvod = dgvNarudzbenica.Rows[red].Cells["NAZIV"].Value.ToString();
                kolicina = dgvNarudzbenica.Rows[red].Cells["KOLICINA"].Value.ToString();

                red++;

                Console.WriteLine("NAZIV I KOLIČINA: " + proizvod + kolicina);

                UpravljanjeSkladistem.DodajStavku(proizvod, Convert.ToInt32(kolicina));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmNarudzbenica frm = new FrmNarudzbenica();
            frm.Show();
            this.Dispose(false);
        }

        private void btnGenerairajNarudžbenicu_Click(object sender, EventArgs e)
        {
            FrmPopisNarudzbenica f = new FrmPopisNarudzbenica();
            f.ShowDialog();
        }
    }
}