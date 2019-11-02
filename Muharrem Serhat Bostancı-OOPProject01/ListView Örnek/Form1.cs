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

namespace ListView_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //string humanId;
            //string humanAd;
            //string humanSoyad;

            //humanId = txtId.Text;
            //humanAd = txtAd.Text;
            //humanSoyad = txtSoyad.Text;

            //string[] row = { humanId, humanAd, humanSoyad };

            string[] row = { txtId.Text, txtAd.Text, txtSoyad.Text };

            ListViewItem satir = new ListViewItem(row);
            listView1.Items.Add(satir);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID", 70);
            listView1.Columns.Add("AD", 170);
            listView1.Columns.Add("SOYAD", 170);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            //listView1.Items.Remove(listView1.SelectedItems[0]);
            //string[] row = { txtId.Text, txtAd.Text, txtSoyad.Text };
            //ListViewItem satir = new ListViewItem(row);
            //listView1.Items.Add(satir);

            listView1.SelectedItems[0].SubItems[0].Text = txtId.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txtAd.Text;
            listView1.SelectedItems[0].SubItems[2].Text = txtSoyad.Text;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
