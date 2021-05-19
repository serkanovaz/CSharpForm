using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7LO70PS;Initial Catalog=proje;Integrated Security=True");
        private void oku()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from hesaplar", baglanti);//komut değişkeni oluşturdum ve tablomu ilişkilendirdim.
        SqlDataReader oku = komut.ExecuteReader();//okuma yapmam için oku değişkenini oluşturdum ve çekilen verilerin veri akışını sağladım.
            while (oku.Read())//döngü ile oku işleminin sürekliliği sağlandı.
            {
                
                ListViewItem ekle = new ListViewItem();//ekle değişkeni sağlandı.
                ekle.Text = oku["ibanno"].ToString();//ekle komutu ile veri tabanı alanı ilişkilendirildi.
                ekle.SubItems.Add(oku["hesapno"].ToString());//ekle komutu ile veri tabanı alanı ilişkilendirildi.
                ekle.SubItems.Add(oku["bakiye"].ToString());//ekle komutu ile veri tabanı alanı ilişkilendirildi.
                ekle.SubItems.Add(oku["doviz"].ToString());//ekle komutu ile veri tabanı alanı ilişkilendirildi.
                ekle.SubItems.Add(oku["hesaptur"].ToString());//ekle komutu ile veri tabanı alanı ilişkilendirildi.
                listView1.Items.Add(ekle);//Ekleme işlemi gerçekleştirildi.

            }
    baglanti.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            oku();            
            zaman();

        }

        private void faturalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newform2 = new Form4();
            newform2.Show();
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ürünVeBaşvurularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void faturaÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void krediKartlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newform4 = new Form6();
            newform4.Show();
        }

        private void güvenliÇıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarılı Bir Çıkış İşlemi Gerçekleşmiştir... ");

            Application.Exit();

        }

        private void vadesizHesapToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void güvenliÇıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarılı Bir Çıkış İşlemi Gerçekleşmiştir... ");

            Application.Exit();
        }

        private void şifreDeğişikliğiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 newform6 = new Form7();
            newform6.Show();
        }

        private void bilgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Şubelerimize Başvurunuz.");
        }

        private void vadeliHesapToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hesapAçılışıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newform9 = new Form9();
            newform9.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            oku();
            zaman();
        }
        private void zaman()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from giriştarih", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["tarih"].ToString();
                listView2.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void faturaÖdemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form23 gsm = new Form23();
            gsm.Show();
        }

        private void sanalKartlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 sanal = new Form11();
            sanal.Show();
        }

        private void kendiKrediKartlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 kködeme = new Form12();
            kködeme.Show();
        }

        private void krediKartımaOtomatikÖdemeTalimatıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 okködeme = new Form13();
            okködeme.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 şifreişlemleri = new Form14();
            şifreişlemleri.Show();
        }

        private void puanİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Puanlarınızı TL karşılığında anlaşmalı kurumlarda kullanabilirsiniz.");
        }

        private void limitİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 limit = new Form15();
            limit.Show();

        }

        private void krediKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form16 başvuru = new Form16();
            başvuru.Show();
        }

        private void sanalKartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form17 skart = new Form17();
            skart.Show();
        }

        private void kendiHesabımaHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form18 khavale = new Form18();
            khavale.Show();
        }

        private void başkaHesabaHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 bhavale = new Form19();
            bhavale.Show();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO giriştarih (tarih) values('" + tarih + "')", baglanti);

            komut.ExecuteNonQuery();
            baglanti.Close();
            listView2.Items.Clear();
            zaman();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void başkaKartlarımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newform3 = new Form5();
            newform3.Show();
        }

        private void hesabaEFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newform5 = new Form3();
            newform5.Show();
        }

        private void krediKartımaEFTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 karteft = new Form20();
            karteft.Show();
        }

        private void paraGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form21 wupgönder = new Form21();
            wupgönder.Show();
        }

        private void gSMTLPaketYüklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form24 fatura = new Form24();
            fatura.Show();
        }

        private void paraALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form22 wual = new Form22();
            wual.Show();
        }

        private void krediHesaplamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form25 khesap = new Form25();
            khesap.Show();
        }

        private void kredilerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form26 ktakip = new Form26();
            ktakip.Show();
        }

        private void başvuruİzlemeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form27 izle = new Form27();
            izle.Show();
        }

        private void krediKartBaşvurusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form28 talep1 = new Form28();
            talep1.Show();
        }

        private void krediKartEkBaşvurusuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form29 ekb = new Form29();
            ekb.Show();
        }

        private void bankaKartBaşvurusuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form30 bsvr = new Form30();
            bsvr.Show();
        }

        private void başvuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form31 bsvrusgrt = new Form31();
            bsvrusgrt.Show();
        }

        private void poliçemToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show("Poliçeniz için lütfen şubemize başvurunuz.");
        }

        private void bireyselİhtiyaçKredisiBaşvuruKullanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form33 birey = new Form33();
            birey.Show();
        }

        private void konutKredisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form34 kntkredi = new Form34();
            kntkredi.Show();
        }

        private void başvuruİzlemeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form35 b35 = new Form35();
            b35.Show();
        }

        private void bESSözleşmesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form36 bes1 = new Form36();
            bes1.Show();
        }

        private void başvuruToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form37 bes2 = new Form37();
            bes2.Show();

        }

        private void başvuruİzlemeToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form38 bes3 = new Form38();
            bes3.Show();

        }

        private void motorluTaşıtlarVergisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form39 mtv = new Form39();
            mtv.Show();
        }

        private void trafikCezasıİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form40 trfk = new Form40();
            trfk.Show();
        }

        private void yıllıkGelirVergisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form41 yv = new Form41();
            yv.Show();

        }

        private void gayriMenkulSermayeVergisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form42 gmsv = new Form42();
            gmsv.Show();
            MessageBox.Show("Ödeme için lütfen vergi dairenize başvurunuz.Bu özellik yapım aşamasındadır.");

        }

        private void diğerVergilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form43 dv = new Form43();
            dv.Show();
            MessageBox.Show("Ödeme için lütfen vergi dairenize başvurunuz.Bu özellik yapım aşamasındadır.");
        }

        private void sGKÖdemesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form44 sgk = new Form44();
            sgk.Show();
        }

        private void hGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form45 hgs = new Form45();
            hgs.Show();
        }

        private void okulÖdemeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form46 okul = new Form46();
            okul.Show();
        }

        private void üniversiteÖdemeleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form47 üni = new Form47();
            üni.Show();

        }

        private void üniversiteÖdemeleriİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form48 üniiptal = new Form48();
            üniiptal.Show();

        }

        private void bireyselİhtiyaçKredisiBaşvrusuKullanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Şubelerimize Başvurunuz.");
        }

        private void konutKredisiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void faturalarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Şubelerimize Başvurunuz.");
        }

        private void kredilerimToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void konutKredisiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form34 kntkredi = new Form34();
            kntkredi.Show();
        }
    }
}
