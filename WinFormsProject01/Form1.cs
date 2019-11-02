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

namespace WinFormsProject01
{
    // Project : Döngüler
    public partial class frmDonguler : Form
    {

        int[] Dizi = { 10, 20, 25, 28, 34 };
        int Toplam;

        public frmDonguler()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            listBoxFor.Items.Clear();
            Temizle();
            for (int i = 0; i < Dizi.Length; i++)
            {
                Toplam = Toplam + Dizi[i];
                listBoxFor.Items.Add(Dizi[i]);
            }
            listBoxFor.Items.Add("Toplam Değer = " + Toplam);
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            listBoxForEach.Items.Clear();
            Temizle();
            foreach (int d in Dizi)
            {
                Toplam = Toplam + d;
                listBoxForEach.Items.Add(d);
            }
            listBoxForEach.Items.Add("Toplam Değer = " + Toplam);
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            listBoxWhile.Items.Clear();
            Temizle();
            int a = 0;
            while (a < Dizi.Length)
            {
                listBoxWhile.Items.Add(Dizi[a]);
                Toplam = Toplam + Dizi[a];
                a++;
            }
            listBoxWhile.Items.Add("Toplam Değer = " + Toplam);
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            Temizle();
            listBoxDoWhile.Items.Clear();
            int a = 0;
            do
            {
                listBoxDoWhile.Items.Add(Dizi[a]);
                Toplam = Toplam + Dizi[a];
                a++;
            }
            while (a < Dizi.Length);

            listBoxDoWhile.Items.Add("Toplam Değeri = " + Toplam);
        }

        public void Temizle()
        {
            Toplam = 0;
        }
        //enum ToplanacakDegerler
        //{
        //    bir = 10,
        //    iki = 20,
        //    uc = 25,
        //    dort = 28,
        //    bes = 34
        //}
        private void btnIEnum_Click(object sender, EventArgs e)
        {
            Temizle();
            IENumDongu();

            //foreach (int enumDgskn in Enum.GetValues(typeof(ToplanacakDegerler)))
            //{
            //    listBoxIEnum.Items.Add(enumDgskn);
            //    Toplam += enumDgskn;
            //}
            listBoxIEnum.Items.Add("Toplam Değeri = " + Toplam);
        }
        public void IENumDongu()
        {
            listBoxIEnum.Items.Clear();
            //i = 0;
            IEnumerator IENum = Dizi.GetEnumerator();
            while(IENum.MoveNext())
            {
                listBoxIEnum.Items.Add(IENum.Current);
                //Toplam += Dizi[i];
                //i++;
                Toplam += (int)IENum.Current;
            }
        }

        private void frmDonguler_Load(object sender, EventArgs e)
        {
            MessageBox.Show("!! DÜNYAYA HOŞGELDİN !!");
        }
    }
}
