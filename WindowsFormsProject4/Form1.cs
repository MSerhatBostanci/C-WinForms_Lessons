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

namespace WindowsFormsProject4
{
    // Project : Event Order for Mouse Movements
    public partial class Form1 : Form
    {
        //public string strButtonTemizleText;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string s)
        {
            InitializeComponent();
            btnTemizle.Text = s;
        }

        private void pnlOlay_MouseDown(object sender, MouseEventArgs e)
        {
            //mouse down enent'i gerçekleştiğinde bu metot tetiklenecek
            //Bu bilgi Form1.Designer.cs dosyasında belirtiliyor.
            //Bu metot kendi içerisinde Yaz() metounu çağırıyor.
            //Yaz metodu tek parametre alıyor(1 adet stringtipinde parametre)
            Yaz("Mouse Down");
            //Yaz("Mouse Down" + e.Button.ToString());
        }

        private void pnlOlay_MouseEnter(object sender, EventArgs e)
        {
            Yaz("Mouse Enter");
        }

        private void pnlOlay_MouseHover(object sender, EventArgs e)
        {
            Yaz("Mouse Hover");
        }

        private void pnlOlay_MouseLeave(object sender, EventArgs e)
        {
            Yaz("Mouse Leave");
        }

        private void pnlOlay_MouseMove(object sender, MouseEventArgs e)
        {
            Yaz("Mouse Move");
        }

        private void pnlOlay_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("Mouse Up");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //btnTemizle.Text = strButtonTemizleText;
        }
        private void Yaz(string EventAdi)
        {
            lstBoxOlay.Items.Add(string.Format("{1} {0}", EventAdi, DateTime.Now));
            this.lstBoxOlay.SelectedIndex = this.lstBoxOlay.Items.Count - 1;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstBoxOlay.Items.Clear();
        }
    }
}
