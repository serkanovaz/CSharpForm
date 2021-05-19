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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-7LO70PS;Initial Catalog=proje;Integrated Security=True");

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }
        private void verioku()
        {
            

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from hesaplar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listView2.Items.Clear();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ibanno"].ToString();
                ekle.SubItems.Add(oku["hesapno"].ToString());
                ekle.SubItems.Add(oku["bakiye"].ToString());
                ekle.SubItems.Add(oku["doviz"].ToString());
                ekle.SubItems.Add(oku["hesaptur"].ToString());
                listView2.Items.Add(ekle);

            }
            baglanti.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random hesap = new Random();
            int write = hesap.Next(1000000, 1000000000);
            label1.Text = write.ToString();
            
            int write1= hesap.Next(1000, 1000000);
            label2.Text = write1.ToString();

            baglanti.Open();
            SqlCommand veriekle=new SqlCommand("Insert into hesaplar(ibanno,hesapno,doviz,hesaptur) Values('" + label1.Text.ToString() + "','" + label2.Text.ToString() 
       + "','" + comboBox1.Text.ToString()+"','"+comboBox2.Text.ToString()+"')",baglanti);
            veriekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşleminiz Başarı İle Gerçekleşmiştir.");
            verioku();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verioku();
        }

        private void sayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
