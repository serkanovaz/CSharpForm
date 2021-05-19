using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//veritabanı kütüphanesi

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {   //rastgele sayı üretimi
            Random security = new Random();
            int write = security.Next(1000, 10001);
            label1.Text = write.ToString();
        }
        
        
        SqlConnection bg=new SqlConnection("Data Source=DESKTOP-7LO70PS;Initial Catalog=proje;Integrated Security=True");//veritabanına bağlanma
        private void buttonok_Click(object sender, EventArgs e)
        {
            try
            {
                bg.Open();//bağlantımı açtım
                string sql = "Select *From girispaneli where nickname=@adi AND password=@sifre";// tablo bağlantısı ve geçici değişken oluşumu
                SqlParameter ilksorgu = new SqlParameter("adi", textBox1.Text.Trim());//parametre oluşu
                SqlParameter ikincisorgu = new SqlParameter("sifre", textBox2.Text.Trim());//paramatre oluşumu
                SqlCommand asama = new SqlCommand(sql, bg);// komut başlangıcı
                asama.Parameters.Add(ilksorgu);//komut
                asama.Parameters.Add(ikincisorgu);//komut
                DataTable tablo = new DataTable();// sanal tablo oluşumu
                SqlDataAdapter adapter = new SqlDataAdapter(asama);
                adapter.Fill(tablo);
                if (tablo.Rows.Count > 0)//kullanıcı verigişiri ve veritabanı verilerin kıyaslanması
                {
                   if (textBox3.Text == label1.Text && checkBox1.Checked != false)//güvenlik resmi ve kontrol aracımın doğrulun sorgulanması
                    {
                        Form2 newform = new Form2();//yeni form geçişi
                        newform.Show();
                        this.Hide();
                    }
                    

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
                bg.Close();///bağlantı kapama
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {   //tasarım ve gelişme aşamasında panelde kontrola her seferinde takılmamak için geçeçi direk geçiş sağladım.Proje sonu kaldırılacak.
            Form2 newform = new Form2();
            newform.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            this.Hide();
        }
    }
}
