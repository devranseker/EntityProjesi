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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityProductEntities dbEntity = new DbEntityProductEntities();   // nesne türettim 

        // Listeleme Butonu
        private void BtnList_Click(object sender, EventArgs e)
        {
            var kategoriler = dbEntity.TBLCATEGORİES.ToList();
            // kategorileri dataGridView'e atayalım 
            dataGridView1.DataSource = kategoriler;
        }

        // Ekleme metodu 
        private void BtnAdd_Click(object sender, EventArgs e)
        {  // sımdı dbEntity aracılııgıyla tablolara ulastım simdi tablodan türetttigim nesneden 
            // tablo icerisndeki sütüna ulastım
            TBLCATEGORİES tbl = new TBLCATEGORİES();
            tbl.NAME = TxtCatogoriName.Text;
            dbEntity.TBLCATEGORİES.Add(tbl);
            dbEntity.SaveChanges();    // ==  ExecuteNonQuery();
            MessageBox.Show("Kategori eklendi.");
        }
        // Silme Butonu Delete == Remove
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCatogoriID.Text);
            var ktgr = dbEntity.TBLCATEGORİES.Find(x);
            dbEntity.TBLCATEGORİES.Remove(ktgr);
            // nasil ki Sql komutlarda parametre atamasından sonra =>  komut.ExecuteNonQuery(); unutmamız gerekiyordu burda da
            //  dbEntity.SaveChanges(); 'i unutmamız gerekiyor 
            dbEntity.SaveChanges();
            MessageBox.Show("Kategori Silindi.");
        }
        // Update butonu 

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtCatogoriID.Text);
            var ktgr = dbEntity.TBLCATEGORİES.Find(x);
            ktgr.NAME = TxtCatogoriName.Text;
            dbEntity.SaveChanges();
            MessageBox.Show("Güncelleme Yapıldı.");

        }

       
    }
}
