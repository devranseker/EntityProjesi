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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        // Login Butonu 
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            DbEntityProductEntities dbAdmin = new DbEntityProductEntities();
            var query = from x in dbAdmin.TBLADMİN where x.USER == TxtUserName.Text && x.PASSWORD == TxtUserPassword.Text select x;
            // Admin girisi if-else 
            if (query.Any())
            {
                FrmAnaForm frmAnafrm = new FrmAnaForm();
                frmAnafrm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Giriş");

            }
        }
    }
}
