using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjesi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        // Kategori islemleri 
        private void BtnKategori_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();

        }

        // Urun Formu 
        private void BtnUrun_Click(object sender, EventArgs e)
        {
            FrmUrun frmurun = new FrmUrun();
            frmurun.Show();

        }

        // Ana Fromdan İstatistikler Formu 
        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik frmisttk = new Frmistatistik();
            frmisttk.Show();

        }
    }
}
