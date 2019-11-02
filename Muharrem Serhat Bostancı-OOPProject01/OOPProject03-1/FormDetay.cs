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
    public partial class FormDetay : Form
    {
        public Ogrenci seciliOgrBilgileri = new Ogrenci();

        public FormDetay()
        {
            InitializeComponent();
        }

        private void FormDetay_Load(object sender, EventArgs e)
        {
            timer1.Interval = 400;
            timer1.Start();
             
            this.txtID.Text = seciliOgrBilgileri.Id.ToString();
            this.txtAd.Text = seciliOgrBilgileri.Ad;
            this.txtSoyad.Text = seciliOgrBilgileri.Soyad;
            this.cmbSehir.Text = seciliOgrBilgileri.DogumYeri;
            this.txtYas.Text = Convert.ToString(DateTime.Now.Year - seciliOgrBilgileri.DogumTarihi.Year);

            this.txtToplamGun.Text = (DateTime.Now - seciliOgrBilgileri.DogumTarihi).TotalDays.ToString();
            this.txtToplamSaat.Text = (DateTime.Now - seciliOgrBilgileri.DogumTarihi).TotalHours.ToString();
            this.txtToplamDakika.Text = (DateTime.Now - seciliOgrBilgileri.DogumTarihi).TotalMinutes.ToString();
            this.txtToplamSaniye.Text = (DateTime.Now - seciliOgrBilgileri.DogumTarihi).TotalSeconds.ToString();
            this.txtToplamMilisaniye.Text = (DateTime.Now - seciliOgrBilgileri.DogumTarihi).TotalMilliseconds.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (lblYasasin.Visible)
            //{
            //    lblYasasin.Visible = false;
            //}
            //else
            //{
            //    lblYasasin.Visible = true;
            //}

            //Ternary Operator ile tek satırda yazmak =
            var res = lblYasasin.Visible ? lblYasasin.Visible = false : lblYasasin.Visible = true ; 


        }
    }
}
