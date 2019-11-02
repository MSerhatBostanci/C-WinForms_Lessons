namespace ZarOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSalla = new System.Windows.Forms.Button();
            this.lblZar1 = new System.Windows.Forms.Label();
            this.lblZar2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnSalla
            // 
            this.btnSalla.BackColor = System.Drawing.Color.Olive;
            this.btnSalla.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSalla.Location = new System.Drawing.Point(93, 197);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(148, 65);
            this.btnSalla.TabIndex = 0;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseVisualStyleBackColor = false;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // lblZar1
            // 
            this.lblZar1.ImageIndex = 0;
            this.lblZar1.ImageList = this.ımageList1;
            this.lblZar1.Location = new System.Drawing.Point(14, 9);
            this.lblZar1.Name = "lblZar1";
            this.lblZar1.Size = new System.Drawing.Size(120, 120);
            this.lblZar1.TabIndex = 1;
            // 
            // lblZar2
            // 
            this.lblZar2.ImageIndex = 0;
            this.lblZar2.ImageList = this.ımageList1;
            this.lblZar2.Location = new System.Drawing.Point(200, 9);
            this.lblZar2.Name = "lblZar2";
            this.lblZar2.Size = new System.Drawing.Size(120, 120);
            this.lblZar2.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Zar1.png");
            this.ımageList1.Images.SetKeyName(1, "Zar2.png");
            this.ımageList1.Images.SetKeyName(2, "Zar3.png");
            this.ımageList1.Images.SetKeyName(3, "Zar4.png");
            this.ımageList1.Images.SetKeyName(4, "Zar5.jpg");
            this.ımageList1.Images.SetKeyName(5, "Zar6.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(334, 280);
            this.Controls.Add(this.lblZar2);
            this.Controls.Add(this.lblZar1);
            this.Controls.Add(this.btnSalla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Label lblZar1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblZar2;
        private System.Windows.Forms.Timer timer1;
    }
}

