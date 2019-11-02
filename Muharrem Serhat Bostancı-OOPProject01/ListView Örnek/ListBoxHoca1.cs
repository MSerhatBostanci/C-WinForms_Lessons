using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView_Örnek
{
    public partial class ListBoxHoca1 : Form
    {
        List<Bilgiler> lstIsimsoisim = new List<Bilgiler>();

        public ListBoxHoca1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtAd.Text != "" && txtSoyad.Text != "")
            {
                //Bilgiler b1 = new Bilgiler();

                //b1.Ad = txtAd.Text;
                //b1.Id = txtId.Text;
                //b1.Soyad = txtSoyad.Text;

                //lstIsimSoyisim.Items.Add(b1);

                Bilgiler b1 = new Bilgiler
                {
                    Id = txtId.Text,
                    Soyad = txtSoyad.Text,
                    Ad = txtAd.Text
                };

                lstIsimsoisim.Add(b1);

                ListBoxDoldur();
            }
            else
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");

            Temizle();
        }

        private void ListBoxDoldur()
        {
            lstbox.DataSource = null;
            lstbox.DataSource = lstIsimsoisim;

            lstbox.DisplayMember = "AdSoyad";
            lstbox.ValueMember = "Id";
        }

        private void Temizle()
        {
            txtId.Text = txtAd.Text = txtSoyad.Text = string.Empty;
            txtId.Focus();
        }

        private void lstbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbox.SelectedItem != null)
            {
                Bilgiler blg = (Bilgiler)lstbox.SelectedItem;
                txtAd.Text = blg.Ad;
                txtSoyad.Text = blg.Soyad;
                txtId.Text = blg.Id;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(lstbox.SelectedValue) != "")
            {
                foreach (Bilgiler blg in lstIsimsoisim)
                {
                    if (blg.Id == Convert.ToString(lstbox.SelectedValue))
                    {
                        lstIsimsoisim.Remove(blg);
                        break;
                    }
                }
                ListBoxDoldur();
            }
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //Enesin Çözümü****
            if (lstbox.SelectedIndex >= 0)
            {
                ((Bilgiler)lstbox.SelectedItem).Id = txtId.Text;
                ((Bilgiler)lstbox.SelectedItem).Ad = txtAd.Text;
                ((Bilgiler)lstbox.SelectedItem).Soyad = txtSoyad.Text;

                ListBoxDoldur();
            }
            else
            {
                MessageBox.Show("Lütfen Değiştirmek İstediğiniz Satırı Seçiniz");
            }

            //if (Convert.ToString(lstbox.SelectedValue) != "")
            //{
            //    foreach (Bilgiler blg in lstIsimsoisim)
            //    {
            //        if (blg.Id == Convert.ToString(lstbox.SelectedValue))
            //        {
            //            lstIsimsoisim.Remove(blg);
            //            break;
            //        }
            //    }

            //    Bilgiler blgDegismis = new Bilgiler();
            //    blgDegismis.Id = txtId.Text;
            //    blgDegismis.Ad = txtAd.Text;
            //    blgDegismis.Soyad = txtSoyad.Text;

            //    lstIsimsoisim.Add(blgDegismis);

            //ListBoxDoldur();
            //}
            //else
            //{
            //    MessageBox.Show("Lütfen Değiştirmek İstediğiniz Satırı Seçiniz");
            //}
        }

        class Bilgiler
        {
            public string Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string AdSoyad
            {
                get { return Ad + " " + Soyad; }
            }
        }
    }
}
