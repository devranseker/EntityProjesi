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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        // Global alan 
        // Burada product clasına ulatım dbEntty ile 
        DbEntityProductEntities dbEntty = new DbEntityProductEntities();

        // pictureBox  Saklama
        private void BtnXX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // List Butonu 
        private void BtnList_Click(object sender, EventArgs e)
        {
            //dbEntty nesnesi ile TBLPRODUCT.ToList();  listeleyip dataGridview'e atadik 

            // from x in foreach dongusu gibi dusun dbEntty nesnesi ile  TBLPRODUCT tablosuna
            // ulastık and icerisinde degerleri bize listelemesini istedik
            // 
            dataGridView1.DataSource = (from x in dbEntty.TBLPRODUCT
                                        select new
                                        {
                                            x.PRODUCTID,
                                            x.PRODUCTNAME,
                                            x.BRAND,
                                            x.STOCK,
                                            x.PRICE,
                                            x.TBLCATEGORİES.NAME,      // ID degilde normal adını getirsin bize diye x'in bagli oldugu tablonun 
                                            x.DURUM                  // adını yani categorinin  bagli oldugu tablonun adını getirsin 
                                        }
            ).ToList();

        }

        // Ekleme Butonu 
        private void BtnAdd_Click(object sender, EventArgs e)
        {    // tbUrun nesnesi ile TBLPRODUCT tablosuna eristim 
            TBLPRODUCT tbUrun = new TBLPRODUCT();
            // simdi Tablo sutunlarına ekleme yapalım 
            tbUrun.PRODUCTNAME = TxtUrunName.Text;
            tbUrun.BRAND = TxtUrunBrand.Text;
            tbUrun.STOCK = short.Parse(TxtUrunStock.Text);
            tbUrun.CATEGORI = int.Parse(CmbCategori.SelectedValue.ToString());
            tbUrun.PRICE = decimal.Parse(TxtUrunPrice.Text);
            tbUrun.DURUM = true;
            // Simdi bunların hepsini tbUrun tablosuna ekleyelim 
            dbEntty.TBLPRODUCT.Add(tbUrun);
            dbEntty.SaveChanges();
            MessageBox.Show("Ürün Ekleme İşlemi Yapıldı.");

        }
        

        // Silme Butonu 
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtUrunID.Text);      // ID'yi int cevirdik 
            var urun = dbEntty.TBLPRODUCT.Find(x);   // dbEntty nesnesi ile TBLPRODUCT ulastık ve bulma islemi
                                                // Find(x) ile bulup  urun degiskenine atadı
            dbEntty.TBLPRODUCT.Remove(urun);   // sonra Remove 
            dbEntty.SaveChanges();
            MessageBox.Show("Ürün Silindi.");

        }
        // Guncelleme Butonu 
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtUrunID.Text);      // ID'yi int cevirdik 
            var urun = dbEntty.TBLPRODUCT.Find(x);   // dbEntty nesnesi ile TBLPRODUCT ulastık ve bulma islemi
            urun.PRODUCTNAME = TxtUrunName.Text;                                         // Find(x) ile bulup  urun degiskenine atadı
            urun.STOCK = short.Parse(TxtUrunStock.Text);
            urun.BRAND = TxtUrunBrand.Text;
            urun.PRICE = Decimal.Parse(TxtUrunPrice.Text);
            dbEntty.SaveChanges();
            MessageBox.Show("Ürün Güncellendi.");
        }

        // FORM
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategori = (from x in dbEntty.TBLCATEGORİES
                            select new
                            {
                                x.ID,
                                x.NAME 
                            }
                            ).ToList();
            CmbCategori.ValueMember = "ID";      //ValueMember arka planda calısacak deger 
            CmbCategori.DisplayMember = "Name";   // DisplayMember ekranda gorunecek deger 
            CmbCategori.DataSource = kategori;

        }

        // Temizle Butonu 
        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtUrunName.Text = CmbCategori.SelectedValue.ToString();

        }
    }
}
