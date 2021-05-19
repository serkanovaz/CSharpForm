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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection yenibaglanti = new SqlConnection(@"Data Source=DESKTOP-7LO70PS;Initial Catalog=proje;Integrated Security=True");
        
        
        private void Form7_Load(object sender, EventArgs e)
        {
            Random security = new Random();
            int write = security.Next(1000, 10001);
            label4.Text = write.ToString();
            göster();
            tarihgöster();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void temizlik()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            
            
        }
        private void tarihekle()
        {
            string tarih = dateTimePicker1.Value.ToString();
            yenibaglanti.Open();
            SqlCommand asama = new SqlCommand("INSERT INTO şifretarih (tarih) values('" + tarih + "')", yenibaglanti);

            asama.ExecuteNonQuery();
            yenibaglanti.Close();
            
        }
        private void tarihgöster()
        {
            yenibaglanti.Open();
            SqlCommand asama = new SqlCommand("select *from şifretarih", yenibaglanti);
            SqlDataReader read = asama.ExecuteReader();
            while (read.Read())
            {
                ListViewItem görüntüle = new ListViewItem();
                görüntüle.Text = read["tarih"].ToString();
                listView1.Items.Add(görüntüle);

            }
            yenibaglanti.Close();
        }
        private void göster()
        {
            yenibaglanti.Open();
            SqlCommand yapım = new SqlCommand("select *from girispaneli", yenibaglanti);
            SqlDataReader read = yapım.ExecuteReader();
            while (read.Read())
            {
                ListViewItem görüntüle = new ListViewItem();
                görüntüle.Text = read["sıra"].ToString();
                görüntüle.SubItems.Add(read["nickname"].ToString());
                görüntüle.SubItems.Add(read["password"].ToString());
                
                listView2.Items.Add(görüntüle);

            }
            yenibaglanti.Close();
        }
        int sıra = 0;
        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            
            if (textBox2.Text == textBox3.Text && textBox1.Text == label4.Text && checkBox1.Checked != false)
            {
                
                yenibaglanti.Open();
                SqlCommand yapım = new SqlCommand("update girispaneli set password='" + textBox2.Text.ToString() + "'where sıra=" + sıra + "", yenibaglanti);
                yapım.ExecuteNonQuery();
                yenibaglanti.Close();
                MessageBox.Show("İşleminiz Başarı İle Gerçekleşmiştir");
                temizlik();
                tarihekle();
            }
            else
                MessageBox.Show("Bilgilerinizi Kontrol Ediniz...");



        }

        private void Form7_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sıra = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
            

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            tarihgöster();
        }
    }
}
