using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject5_benim_metinli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String renk = textBox1.Text;

            try
            {
                BackColor = Color.FromName(renk);
                this.BackColor = DefaultBackColor;
            }
            catch
            {
                MessageBox.Show("Girdiğiniz renk bulunamadı");
                textBox1.Clear();
                return;
            }

            Form1 frm1 = new Form1(renk);

            frm1.Show();

            this.Hide();

        }
    }
}
