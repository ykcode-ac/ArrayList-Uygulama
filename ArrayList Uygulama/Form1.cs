using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayList_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList ogrenciler=new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnEkle;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            ogrenciler.Add(txtOgrenci.Text);
            txtOgrenci.Clear();
            Listele();
        }

        private void Listele()
        {
            lstOgrenciler.Items.Clear();

            foreach (string ogrenci in ogrenciler)
            {
                lstOgrenciler.Items.Add(ogrenci);
            }
        }

        private void btnArayaEkle_Click(object sender, EventArgs e)
        {
            int indexNo=lstOgrenciler.SelectedIndex;
            ogrenciler.Insert(indexNo, txtOgrenci.Text);
            txtOgrenci.Clear();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int indexNo = lstOgrenciler.SelectedIndex;
            ogrenciler[indexNo] = txtOgrenci.Text;
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int indexNo = lstOgrenciler.SelectedIndex;
            ogrenciler.RemoveAt(indexNo);
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string ogrenciAd=txtOgrenci.Text;
            if (ogrenciler.Contains(ogrenciAd))
            {
                lblDurum.Text = "Aranan Öğrenci Bulundu";
                lstOgrenciler.SelectedIndex=ogrenciler.IndexOf(ogrenciAd);
            }
            else
            {
                lblDurum.Text = "Aranan Öğrenci Bulunamadı";
            }
        }
    }
}
