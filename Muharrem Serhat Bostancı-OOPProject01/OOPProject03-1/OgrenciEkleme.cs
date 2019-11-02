using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPProject03;

namespace OOPProject03_1
{
    public partial class OgrenciEkleme : Form
    {
        public Ogrenci YeniOgrBilgileri = new Ogrenci();
        private int enBüyükID;
        public OgrenciEkleme(int n)
        {
            enBüyükID = n;
            InitializeComponent();
        }
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Ad = txtYeniAd.Text;
            ogr.Soyad = txtYeniSoyad.Text;
            //ogr.Id = Convert.ToInt32(txtYeniID.Text);
            ogr.Id = enBüyükID+1;
            ogr.DogumYeri = comboxYeniSehir.SelectedItem.ToString();
            //ogr.DogumTarihi = Convert.ToDateTime(dtpYeniDogumTarihi.Text);
            ogr.DogumTarihi = dtpYeniDogumTarihi.Value;
            //ogr.KursBitisTarihi = Convert.ToDateTime(dtpYeniKursBitisTarihi.Text);
            ogr.KursBitisTarihi = dtpYeniKursBitisTarihi.Value;

            YeniOgrBilgileri = ogr;

            this.Hide();
        }
        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {
            this.txtYeniID.Text = (enBüyükID + 1).ToString();
            ComboSehirDoldur();
            this.comboxYeniSehir.SelectedIndex = 0;
        }
        private void ComboSehirDoldur()
        {
            this.comboxYeniSehir.Items.Clear();
            BAU cls = new BAU();

            comboxYeniSehir.Items.AddRange(cls.SehirlerArray);

            //foreach (var item in cls.SehirlerArray)
            //{
            //    comboxYeniSehir.Items.Add(item);
            //}
        }
    }
}
