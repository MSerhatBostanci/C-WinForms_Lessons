namespace WindowsFormsProject4
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
            this.pnlOlay = new System.Windows.Forms.Panel();
            this.lstBoxOlay = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlOlay
            // 
            this.pnlOlay.BackColor = System.Drawing.Color.Chocolate;
            this.pnlOlay.Location = new System.Drawing.Point(12, 12);
            this.pnlOlay.Name = "pnlOlay";
            this.pnlOlay.Size = new System.Drawing.Size(210, 122);
            this.pnlOlay.TabIndex = 0;
            this.pnlOlay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseDown);
            this.pnlOlay.MouseEnter += new System.EventHandler(this.pnlOlay_MouseEnter);
            this.pnlOlay.MouseLeave += new System.EventHandler(this.pnlOlay_MouseLeave);
            this.pnlOlay.MouseHover += new System.EventHandler(this.pnlOlay_MouseHover);
            this.pnlOlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseMove);
            this.pnlOlay.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlOlay_MouseUp);
            // 
            // lstBoxOlay
            // 
            this.lstBoxOlay.HorizontalScrollbar = true;
            this.lstBoxOlay.Location = new System.Drawing.Point(12, 151);
            this.lstBoxOlay.Name = "lstBoxOlay";
            this.lstBoxOlay.Size = new System.Drawing.Size(210, 121);
            this.lstBoxOlay.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(12, 289);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(210, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "button1";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 348);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lstBoxOlay);
            this.Controls.Add(this.pnlOlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOlay;
        private System.Windows.Forms.ListBox lstBoxOlay;
        private System.Windows.Forms.Button btnTemizle;
    }
}

