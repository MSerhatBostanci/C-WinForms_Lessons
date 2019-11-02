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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string a)
        {
            InitializeComponent();

            BackColor = Color.FromName(a);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frmrenksorgusugecis = new Form2();

            frmrenksorgusugecis.Show();

            this.Hide();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Environment.Exit(2);
        }
    }
}
