using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersembeGunu17AralikUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        void Hesapla()
        {
            DegerHesapla degerHesapla = new DegerHesapla();
            degerHesapla.DaireDurumu = cbDaire.Text;
            degerHesapla.EsyaDurumu = cbEsya.Text;
            degerHesapla.KatSayisi = cbKat.SelectedIndex + 1;
            degerHesapla.Konum = cbKonum.Text;
            degerHesapla.OdaSayisi = cbOda.SelectedIndex;

            label7.Text = degerHesapla.DaireDegerHesapla().ToString();
        }
    }
}
