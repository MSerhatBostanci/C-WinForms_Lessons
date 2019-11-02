namespace OOPProject03_1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUretveDoldur = new System.Windows.Forms.Button();
            this.btnVeriDetay = new System.Windows.Forms.Button();
            this.btnVeriEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnCokluSil = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.btnLogListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(685, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnUretveDoldur
            // 
            this.btnUretveDoldur.Location = new System.Drawing.Point(732, 20);
            this.btnUretveDoldur.Name = "btnUretveDoldur";
            this.btnUretveDoldur.Size = new System.Drawing.Size(177, 44);
            this.btnUretveDoldur.TabIndex = 1;
            this.btnUretveDoldur.Text = "Üret ve Doldur";
            this.btnUretveDoldur.UseVisualStyleBackColor = true;
            this.btnUretveDoldur.Click += new System.EventHandler(this.btnUretveDoldur_Click);
            // 
            // btnVeriDetay
            // 
            this.btnVeriDetay.Location = new System.Drawing.Point(732, 77);
            this.btnVeriDetay.Name = "btnVeriDetay";
            this.btnVeriDetay.Size = new System.Drawing.Size(177, 44);
            this.btnVeriDetay.TabIndex = 2;
            this.btnVeriDetay.Text = "Detaylandır";
            this.btnVeriDetay.UseVisualStyleBackColor = true;
            this.btnVeriDetay.Click += new System.EventHandler(this.btnVeriDetay_Click);
            // 
            // btnVeriEkle
            // 
            this.btnVeriEkle.Location = new System.Drawing.Point(732, 134);
            this.btnVeriEkle.Name = "btnVeriEkle";
            this.btnVeriEkle.Size = new System.Drawing.Size(177, 44);
            this.btnVeriEkle.TabIndex = 3;
            this.btnVeriEkle.Text = "Ekle";
            this.btnVeriEkle.UseVisualStyleBackColor = true;
            this.btnVeriEkle.Click += new System.EventHandler(this.btnVeriEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(732, 248);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(177, 44);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(732, 191);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(177, 44);
            this.btnDegistir.TabIndex = 5;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnCokluSil
            // 
            this.btnCokluSil.Location = new System.Drawing.Point(732, 305);
            this.btnCokluSil.Name = "btnCokluSil";
            this.btnCokluSil.Size = new System.Drawing.Size(177, 44);
            this.btnCokluSil.TabIndex = 6;
            this.btnCokluSil.Text = "Çoklu Silme";
            this.btnCokluSil.UseVisualStyleBackColor = true;
            this.btnCokluSil.Click += new System.EventHandler(this.btnCokluSil_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(732, 362);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(177, 44);
            this.btnGeriAl.TabIndex = 7;
            this.btnGeriAl.Text = "Geri Al";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // btnLogListele
            // 
            this.btnLogListele.Location = new System.Drawing.Point(732, 419);
            this.btnLogListele.Name = "btnLogListele";
            this.btnLogListele.Size = new System.Drawing.Size(177, 44);
            this.btnLogListele.TabIndex = 8;
            this.btnLogListele.Text = "Log Kayıtlarını Listele";
            this.btnLogListele.UseVisualStyleBackColor = true;
            this.btnLogListele.Click += new System.EventHandler(this.btnLogListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 487);
            this.Controls.Add(this.btnLogListele);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnCokluSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnVeriEkle);
            this.Controls.Add(this.btnVeriDetay);
            this.Controls.Add(this.btnUretveDoldur);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Verileri Otomatik Üret ve Doldur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUretveDoldur;
        private System.Windows.Forms.Button btnVeriDetay;
        private System.Windows.Forms.Button btnVeriEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnCokluSil;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.Button btnLogListele;
    }
}

