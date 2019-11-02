using OOPProject03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject03_1
{
    public partial class frmOgrenciDegistir : Form
    {
        public Ogrenci DegisecekOgrBilgileri = new Ogrenci();

        public frmOgrenciDegistir()
        {
            InitializeComponent();
        }


        private void ComboSehirDoldur()
        {
            this.comboxDegistirSehir.Items.Clear();
            BAU cls = new BAU();

            comboxDegistirSehir.Items.AddRange(cls.SehirlerArray);

            //foreach (var item in cls.SehirlerArray)
            //{
            //    comboxYeniSehir.Items.Add(item);
            //}
        }

        private void frmOgrenciDegistir_Load(object sender, EventArgs e)
        {
            ComboSehirDoldur();

            this.txtDegistirID.Text = DegisecekOgrBilgileri.Id.ToString();
            this.txtDegistirAd.Text = DegisecekOgrBilgileri.Ad;
            this.txtDegistirSoyad.Text = DegisecekOgrBilgileri.Soyad;
            this.comboxDegistirSehir.Text = DegisecekOgrBilgileri.DogumYeri;
            this.dtpDegistirDogumTarihi.Value = DegisecekOgrBilgileri.DogumTarihi;
            this.dtpDegistirKursBitisTarihi.Value = DegisecekOgrBilgileri.KursBitisTarihi;


        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Ad = txtDegistirAd.Text;
            ogr.Soyad = txtDegistirSoyad.Text;
            ogr.Id = Convert.ToInt32(txtDegistirID.Text);
            ogr.DogumYeri = comboxDegistirSehir.SelectedItem.ToString();
            //ogr.DogumTarihi = Convert.ToDateTime(dtpYeniDogumTarihi.Text);
            ogr.DogumTarihi = dtpDegistirDogumTarihi.Value;
            //ogr.KursBitisTarihi = Convert.ToDateTime(dtpYeniKursBitisTarihi.Text);
            ogr.KursBitisTarihi = dtpDegistirKursBitisTarihi.Value;

            DegisecekOgrBilgileri = ogr;

            this.Hide();
        }
    }
}
