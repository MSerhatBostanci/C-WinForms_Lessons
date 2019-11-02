namespace WinFormsOyunlar
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelBitis = new System.Windows.Forms.Panel();
            this.pictureKakashi = new System.Windows.Forms.PictureBox();
            this.pictureGoku = new System.Windows.Forms.PictureBox();
            this.btnYenidenBasla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureKakashi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoku)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 394);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Başla";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelBitis
            // 
            this.panelBitis.BackColor = System.Drawing.Color.Red;
            this.panelBitis.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBitis.Location = new System.Drawing.Point(1201, 0);
            this.panelBitis.Margin = new System.Windows.Forms.Padding(4);
            this.panelBitis.Name = "panelBitis";
            this.panelBitis.Size = new System.Drawing.Size(60, 453);
            this.panelBitis.TabIndex = 2;
            // 
            // pictureKakashi
            // 
            this.pictureKakashi.Image = global::WinFormsOyunlar.Properties.Resources.kakash_son;
            this.pictureKakashi.Location = new System.Drawing.Point(-71, 186);
            this.pictureKakashi.Name = "pictureKakashi";
            this.pictureKakashi.Size = new System.Drawing.Size(270, 193);
            this.pictureKakashi.TabIndex = 1;
            this.pictureKakashi.TabStop = false;
            // 
            // pictureGoku
            // 
            this.pictureGoku.Image = global::WinFormsOyunlar.Properties.Resources.gokuson;
            this.pictureGoku.Location = new System.Drawing.Point(3, 12);
            this.pictureGoku.Name = "pictureGoku";
            this.pictureGoku.Size = new System.Drawing.Size(196, 168);
            this.pictureGoku.TabIndex = 0;
            this.pictureGoku.TabStop = false;
            // 
            // btnYenidenBasla
            // 
            this.btnYenidenBasla.Location = new System.Drawing.Point(1007, 394);
            this.btnYenidenBasla.Name = "btnYenidenBasla";
            this.btnYenidenBasla.Size = new System.Drawing.Size(187, 32);
            this.btnYenidenBasla.TabIndex = 4;
            this.btnYenidenBasla.Text = "Yeniden Başla";
            this.btnYenidenBasla.UseVisualStyleBackColor = true;
            this.btnYenidenBasla.Click += new System.EventHandler(this.btnYenidenBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 453);
            this.Controls.Add(this.btnYenidenBasla);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelBitis);
            this.Controls.Add(this.pictureKakashi);
            this.Controls.Add(this.pictureGoku);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureKakashi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGoku)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureGoku;
        private System.Windows.Forms.PictureBox pictureKakashi;
        private System.Windows.Forms.Panel panelBitis;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnYenidenBasla;
    }
}

