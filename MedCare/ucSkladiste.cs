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
    public partial class ucSkladiste : UserControl
    {
        private static ucSkladiste _instance;
        
        public static ucSkladiste Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucSkladiste();
                }

                return _instance;
            }
        }

        UpravljanjeSkladistem upravljanjeSkladistem = new UpravljanjeSkladistem();

        public ucSkladiste()
        {
            InitializeComponent();
        }

        private void ucSkladiste_Load(object sender, EventArgs e)
        {
            dgvSkladiste.DataSource = null;
            dgvSkladiste.DataSource = upravljanjeSkladistem.PrikaziSkladiste();
        }

        private void btnNovaNarudzbenica_Click(object sender, EventArgs e)
        {
            FrmNarudzbenica frm = new FrmNarudzbenica();
            frm.ShowDialog();
        }
    }
}
