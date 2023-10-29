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
    public partial class Frmistatistik : Form
    {
        public Frmistatistik()
        {
            InitializeComponent();
        }
        DbEntityProductEntities dbUrunEntty = new DbEntityProductEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnXX_Click(object sender, EventArgs e)
        {
            this.Hide();   // sakla 
        }

        private void Frmistatistik_Load(object sender, EventArgs e)
        {                // Count() == sayac 
            LblCategoriSayisi.Text = dbUrunEntty.TBLCATEGORİES.Count().ToString();
            LblTotalUrunSayisi.Text = dbUrunEntty.TBLPRODUCT.Count().ToString();
            LblAktifMusteriSayisi.Text = dbUrunEntty.TBLCUSTOMER.Count(x => x.DURUM == true).ToString();
            LblPasifMusteriSayisi.Text = dbUrunEntty.TBLCUSTOMER.Count(x => x.DURUM == false).ToString();
            // (y => y.AAAAA) herhangi bir harf veya baska birsey olabilir 
           LblTotalStokSayisi.Text = dbUrunEntty.TBLPRODUCT.Sum(y => y.STOCK).ToString();
           LblTotalKasaTutari.Text = dbUrunEntty.TBLSALES.Sum(z => z.PRICE).ToString() + " TL";
            // en yuksek fiyatlı urunu bulalım  descending == büyükten küçüğe veya z'den a'ya doğru sıralamak için kullanılır. 
            LblEnYuksekPriceUrun.Text = (from x in dbUrunEntty.TBLPRODUCT orderby x.PRICE descending select x.PRODUCTNAME).FirstOrDefault();

            // ascending == küçükten büyüge  veya a'den z'ya doğru sıralamak için kullanılır. !! ToList()   olamaz butun degerler var 
            LblEnDusukPriceUrun.Text = (from x in dbUrunEntty.TBLPRODUCT orderby x.PRICE ascending select x.PRODUCTNAME).FirstOrDefault();
            LblBeyazEsyaSayisi.Text = dbUrunEntty.TBLPRODUCT.Count(p => p.CATEGORI == 1).ToString();
          LblTotalBzdlbSayisi.Text = dbUrunEntty.TBLPRODUCT.Count(x => x.PRODUCTNAME == "BUZDOLABI").ToString();
          LblTotalSehirSayisi.Text = (from x in dbUrunEntty.TBLCUSTOMER select x.CITY).Distinct().Count().ToString();
          // hata alıyorum burada 
            // LblEnFzlaUrun.Text = dbUrunEntty.BRANDGETIR().FirstOrDefault();









        }
    }
}
