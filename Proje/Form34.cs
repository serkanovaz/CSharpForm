using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form34 : Form
    {
        public Form34()
        {
            InitializeComponent();
        }

        private void Form34_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.ziraat.com.tr/tr/diger/HesaplamaAraclari/Pages/KrediHesaplama.aspx");
        }
    }
}
