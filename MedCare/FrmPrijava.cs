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
    public partial class FrmPrijava : Form
    {
        Prijava prijava = new Prijava();

        public FrmPrijava()
        {
            InitializeComponent();
            this.ActiveControl = txtKorisnickoIme;
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            Zaposlenici prijavljeniZaposlenik = prijava.ProvjeraZaposlenika(txtKorisnickoIme.Text, txtLozinka.Text);

            if(prijavljeniZaposlenik != null)
            {
                FrmMain frmMain = new FrmMain(prijavljeniZaposlenik);
                frmMain.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!");
            }
        }

        private void FrmPrijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnPrijava.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
