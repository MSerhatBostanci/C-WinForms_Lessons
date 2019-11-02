namespace OOPProject03_1
{
    partial class frmOgrenciDegistir
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
            this.dtpDegistirKursBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.dtpDegistirDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboxDegistirSehir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDegistirAd = new System.Windows.Forms.TextBox();
            this.txtDegistirSoyad = new System.Windows.Forms.TextBox();
            this.txtDegistirID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDegistirKursBitisTarihi
            // 
            this.dtpDegistirKursBitisTarihi.Location = new System.Drawing.Point(107, 209);
            this.dtpDegistirKursBitisTarihi.Name = "dtpDegistirKursBitisTarihi";
            this.dtpDegistirKursBitisTarihi.Size = new System.Drawing.Size(255, 20);
            this.dtpDegistirKursBitisTarihi.TabIndex = 39;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(138, 267);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(140, 59);
            this.btnDegistir.TabIndex = 38;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // dtpDegistirDogumTarihi
            // 
            this.dtpDegistirDogumTarihi.Location = new System.Drawing.Point(108, 175);
            this.dtpDegistirDogumTarihi.Name = "dtpDegistirDogumTarihi";
            this.dtpDegistirDogumTarihi.Size = new System.Drawing.Size(255, 20);
            this.dtpDegistirDogumTarihi.TabIndex = 37;
            // 
            // comboxDegistirSehir
            // 
            this.comboxDegistirSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDegistirSehir.FormattingEnabled = true;
            this.comboxDegistirSehir.Location = new System.Drawing.Point(108, 144);
            this.comboxDegistirSehir.Name = "comboxDegistirSehir";
            this.comboxDegistirSehir.Size = new System.Drawing.Size(255, 21);
            this.comboxDegistirSehir.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Kurs Bitiş Tarihi : ";
            // 
            // txtDegistirAd
            // 
            this.txtDegistirAd.Location = new System.Drawing.Point(108, 76);
            this.txtDegistirAd.Name = "txtDegistirAd";
            this.txtDegistirAd.Size = new System.Drawing.Size(256, 20);
            this.txtDegistirAd.TabIndex = 34;
            // 
            // txtDegistirSoyad
            // 
            this.txtDegistirSoyad.Location = new System.Drawing.Point(107, 110);
            this.txtDegistirSoyad.Name = "txtDegistirSoyad";
            this.txtDegistirSoyad.Size = new System.Drawing.Size(256, 20);
            this.txtDegistirSoyad.TabIndex = 33;
            // 
            // txtDegistirID
            // 
            this.txtDegistirID.Enabled = false;
            this.txtDegistirID.Location = new System.Drawing.Point(107, 42);
            this.txtDegistirID.Name = "txtDegistirID";
            this.txtDegistirID.Size = new System.Drawing.Size(256, 20);
            this.txtDegistirID.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Doğum Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Şehir : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Soyad : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ad : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID : ";
            // 
            // frmOgrenciDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 359);
            this.Controls.Add(this.dtpDegistirKursBitisTarihi);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.dtpDegistirDogumTarihi);
            this.Controls.Add(this.comboxDegistirSehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDegistirAd);
            this.Controls.Add(this.txtDegistirSoyad);
            this.Controls.Add(this.txtDegistirID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOgrenciDegistir";
            this.Text = "Öğrenci Bilgisi Değiştirme";
            this.Load += new System.EventHandler(this.frmOgrenciDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDegistirKursBitisTarihi;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.DateTimePicker dtpDegistirDogumTarihi;
        private System.Windows.Forms.ComboBox comboxDegistirSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDegistirAd;
        private System.Windows.Forms.TextBox txtDegistirSoyad;
        private System.Windows.Forms.TextBox txtDegistirID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}