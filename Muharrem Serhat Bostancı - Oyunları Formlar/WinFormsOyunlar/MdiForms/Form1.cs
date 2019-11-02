using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiForms
{
    public partial class Form1 : Form
    {
        //******MDI(Multiple Document Interface) ve MenuStrip basit örneği******

        public Form1()
        {
            InitializeComponent();
        }

        private void yeni1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni frm1 = new FormYeni();
            frm1.Show();
            frm1.MdiParent = this;
        }

        private void yeni2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni2 frm2 = new FormYeni2();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni3 frm3 = new FormYeni3();
            frm3.Show();
        }

        private void merhabaDEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
    }
}
