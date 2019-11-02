using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject02
{
    // Project : Textbox'a yalnız Sayı yada yalnız Karakter girme
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_YalnizKarakter_KeyPress(object sender, KeyPressEventArgs e)
        {
            //eğer girilen şey karakter, kontrol ve seperator değilse komutudur. Sistem handle ediyor. ekrana yazdırılmasını engelliyor.
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

            //if (e.KeyChar == '1')
            //    txt_YalnizKarakter.Text += "bir";           //deneme amaçlı eklenmişti incele
            //if (e.KeyChar == 'a')
            //    txt_YalnizKarakter.Text += "a'ya bastınız";

            //((TextBox)sender).Text += "bir";
        }

        private void txt_YalnizSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_CharacterCastingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            txt_CharacterCastingToUpper.CharacterCasing = CharacterCasing.Upper;
        }

        private void txt_CharacterCastingToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
            txt_CharacterCastingToLower.CharacterCasing = CharacterCasing.Lower;
        }

        Color defaultBackColor;
        private void txt_YalnizKarakter_MouseEnter(object sender, EventArgs e)
        {
            defaultBackColor = txt_YalnizKarakter.BackColor;
            txt_YalnizKarakter.BackColor = Color.Red;
        }

        private void txt_YalnizKarakter_MouseLeave(object sender, EventArgs e)
        {
            txt_YalnizKarakter.BackColor = defaultBackColor;
            //txt_YalnizKarakter.BackColor = DefaultBackColor;
        }
    }
}
