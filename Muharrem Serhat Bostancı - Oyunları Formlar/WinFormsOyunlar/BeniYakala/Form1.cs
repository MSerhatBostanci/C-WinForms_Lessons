using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        private int _hamleSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnHedef_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Tebrikler {_hamleSayisi} hamlede tıkladın."); //string interpolation
            MessageBox.Show(string.Format("Tebrikler {0} hamlede tıkladın.", _hamleSayisi)); //string format
            _hamleSayisi = 0;
            Text = _hamleSayisi.ToString();
        }

        private void btnHedef_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            btnHedef.Left = rnd.Next(0, this.ClientSize.Width - btnHedef.Width);
            btnHedef.Top = rnd.Next(0, this.ClientSize.Height - btnHedef.Height);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            _hamleSayisi++;
            Text = _hamleSayisi.ToString();

        }
    }
}
