using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsOyunlar
{
    public partial class Form1 : Form
    {
        int orgX1Value, orgX2Value, orgY1Value, orgY2Value;

        private void btnYenidenBasla_Click(object sender, EventArgs e)
        {
            pictureGoku.Top = orgY1Value;
            pictureGoku.Left = orgX1Value;

            pictureKakashi.Top = orgY2Value;
            pictureKakashi.Left = orgX2Value;
        }

        public Form1()
        {
            InitializeComponent();
            orgX1Value = pictureGoku.Location.X;
            orgY1Value = pictureGoku.Location.Y;
            orgX2Value = pictureKakashi.Location.X;
            orgY2Value = pictureKakashi.Location.Y;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureGoku.Left += rnd.Next(0, 15);
            pictureKakashi.Left += rnd.Next(0, 15);

            //picturebox'lardan herhangi birinin Right özelliği, bitiş panelinin solundan büyük
            //veya eşit ise timer durdurulur.

            if(pictureGoku.Right >= panelBitis.Left || pictureKakashi.Right >= panelBitis.Left)
            {
                timer1.Stop();
                string kazanan;
                if (pictureGoku.Right >= pictureKakashi.Right)
                {
                    kazanan = "Goku";
                }
                else
                {
                    kazanan = "Kakashi";
                }
                timer1.Stop();
                MessageBox.Show(string.Format("{0} Kazandı !!", kazanan));
            }
        }
    }
}
