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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-7LO70PS;Initial Catalog=proje;Integrated Security=True");

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ibanno = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

        }
        private void görüntüleme()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from hesaplar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ibanno"].ToString();
                ekle.SubItems.Add(oku["hesapno"].ToString());
                ekle.SubItems.Add(oku["bakiye"].ToString());
                ekle.SubItems.Add(oku["doviz"].ToString());
                ekle.SubItems.Add(oku["hesaptur"].ToString());
                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        int ibanno = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //silme
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From hesaplar where ibanno =("+ibanno+")", baglanti);
            sil.ExecuteNonQuery();
            baglanti.Close();
            
            görüntüleme();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            görüntüleme();
        }

        private void Form4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
        }

        private void yenilrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            görüntüleme();
        }
    }
}
