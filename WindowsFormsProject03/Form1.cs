using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject03
{
    public partial class Form1 : Form
    {
        // Project : Event Order For Keys
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBoxOlay_KeyDown(object sender, KeyEventArgs e)
        {
            Yaz("Key Down oldu");
        }

        private void txtBoxOlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Yaz("Key Press oldu");
        }

        private void txtBoxOlay_KeyUp(object sender, KeyEventArgs e)
        {
            Yaz("Key Up oldu");
        }

        private void Yaz(string OlayAdi)
        {
            // String Concatenation kullanımı
            //string str = DateTime.Now + " " + OlayAdi;
            //lstBoxOlay.Items.Add(str);

            // String Interpolation kullanımı
            //string s2 = $"{DateTime.Now} {OlayAdi}";
            //lstBoxOlay.Items.Add(s2);

            //String Class'ının Format methodununun kullanımı
            lstBoxOlay.Items.Add(string.Format("{1} {0}", OlayAdi, DateTime.Now));
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lstBoxOlay.Items.Clear();
        }
    }
}
