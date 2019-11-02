namespace WindowsFormsProject02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txt_CharacterCastingToLower = new System.Windows.Forms.TextBox();
            this.txt_CharacterCastingToUpper = new System.Windows.Forms.TextBox();
            this.txt_YalnizSayi = new System.Windows.Forms.TextBox();
            this.txt_YalnizKarakter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.txt_CharacterCastingToLower);
            this.panel1.Controls.Add(this.txt_CharacterCastingToUpper);
            this.panel1.Controls.Add(this.txt_YalnizSayi);
            this.panel1.Controls.Add(this.txt_YalnizKarakter);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 232);
            this.panel1.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(141, 159);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 20);
            this.textBox5.TabIndex = 9;
            // 
            // txt_CharacterCastingToLower
            // 
            this.txt_CharacterCastingToLower.Location = new System.Drawing.Point(141, 126);
            this.txt_CharacterCastingToLower.Name = "txt_CharacterCastingToLower";
            this.txt_CharacterCastingToLower.Size = new System.Drawing.Size(130, 20);
            this.txt_CharacterCastingToLower.TabIndex = 8;
            this.txt_CharacterCastingToLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCastingToLower_KeyPress);
            // 
            // txt_CharacterCastingToUpper
            // 
            this.txt_CharacterCastingToUpper.Location = new System.Drawing.Point(141, 93);
            this.txt_CharacterCastingToUpper.Name = "txt_CharacterCastingToUpper";
            this.txt_CharacterCastingToUpper.Size = new System.Drawing.Size(130, 20);
            this.txt_CharacterCastingToUpper.TabIndex = 7;
            this.txt_CharacterCastingToUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CharacterCastingToUpper_KeyPress);
            // 
            // txt_YalnizSayi
            // 
            this.txt_YalnizSayi.Location = new System.Drawing.Point(141, 60);
            this.txt_YalnizSayi.Name = "txt_YalnizSayi";
            this.txt_YalnizSayi.Size = new System.Drawing.Size(130, 20);
            this.txt_YalnizSayi.TabIndex = 6;
            this.txt_YalnizSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizSayi_KeyPress);
            // 
            // txt_YalnizKarakter
            // 
            this.txt_YalnizKarakter.Location = new System.Drawing.Point(141, 27);
            this.txt_YalnizKarakter.Name = "txt_YalnizKarakter";
            this.txt_YalnizKarakter.Size = new System.Drawing.Size(130, 20);
            this.txt_YalnizKarakter.TabIndex = 5;
            this.txt_YalnizKarakter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_YalnizKarakter_KeyPress);
            this.txt_YalnizKarakter.MouseEnter += new System.EventHandler(this.txt_YalnizKarakter_MouseEnter);
            this.txt_YalnizKarakter.MouseLeave += new System.EventHandler(this.txt_YalnizKarakter_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Boş Yap";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Karakter Küçültme : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Karakter Büyütme : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sayı Gir ;";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Karakter Gir : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 260);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txt_CharacterCastingToLower;
        private System.Windows.Forms.TextBox txt_CharacterCastingToUpper;
        private System.Windows.Forms.TextBox txt_YalnizSayi;
        private System.Windows.Forms.TextBox txt_YalnizKarakter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

