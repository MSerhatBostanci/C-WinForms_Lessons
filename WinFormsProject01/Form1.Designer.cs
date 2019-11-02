namespace WinFormsProject01
{
    partial class frmDonguler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonguler));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.listBoxDoWhile = new System.Windows.Forms.ListBox();
            this.listBoxIEnum = new System.Windows.Forms.ListBox();
            this.listBoxForEach = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnIEnum = new System.Windows.Forms.Button();
            this.btnForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar = {10, 20, 25, 28, 34} kümesinin içindeki sayıları ve en altına bu sayıla" +
    "rın toplamını gösterecek döngü kodlarını yazınız.\r\n";
            // 
            // listBoxFor
            // 
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.ItemHeight = 15;
            this.listBoxFor.Location = new System.Drawing.Point(14, 71);
            this.listBoxFor.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(157, 379);
            this.listBoxFor.TabIndex = 1;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.ItemHeight = 15;
            this.listBoxWhile.Location = new System.Drawing.Point(210, 71);
            this.listBoxWhile.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(157, 379);
            this.listBoxWhile.TabIndex = 2;
            // 
            // listBoxDoWhile
            // 
            this.listBoxDoWhile.FormattingEnabled = true;
            this.listBoxDoWhile.ItemHeight = 15;
            this.listBoxDoWhile.Location = new System.Drawing.Point(406, 71);
            this.listBoxDoWhile.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDoWhile.Name = "listBoxDoWhile";
            this.listBoxDoWhile.Size = new System.Drawing.Size(157, 379);
            this.listBoxDoWhile.TabIndex = 3;
            // 
            // listBoxIEnum
            // 
            this.listBoxIEnum.FormattingEnabled = true;
            this.listBoxIEnum.ItemHeight = 15;
            this.listBoxIEnum.Location = new System.Drawing.Point(602, 71);
            this.listBoxIEnum.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxIEnum.Name = "listBoxIEnum";
            this.listBoxIEnum.Size = new System.Drawing.Size(157, 379);
            this.listBoxIEnum.TabIndex = 4;
            // 
            // listBoxForEach
            // 
            this.listBoxForEach.FormattingEnabled = true;
            this.listBoxForEach.ItemHeight = 15;
            this.listBoxForEach.Location = new System.Drawing.Point(798, 71);
            this.listBoxForEach.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxForEach.Name = "listBoxForEach";
            this.listBoxForEach.Size = new System.Drawing.Size(157, 379);
            this.listBoxForEach.TabIndex = 5;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFor.Location = new System.Drawing.Point(14, 458);
            this.btnFor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(158, 38);
            this.btnFor.TabIndex = 6;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWhile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnWhile.Location = new System.Drawing.Point(210, 458);
            this.btnWhile.Margin = new System.Windows.Forms.Padding(4);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(158, 38);
            this.btnWhile.TabIndex = 7;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDoWhile.Location = new System.Drawing.Point(406, 458);
            this.btnDoWhile.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(158, 38);
            this.btnDoWhile.TabIndex = 8;
            this.btnDoWhile.Text = "DoWhile";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnIEnum
            // 
            this.btnIEnum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnIEnum.Location = new System.Drawing.Point(602, 458);
            this.btnIEnum.Margin = new System.Windows.Forms.Padding(4);
            this.btnIEnum.Name = "btnIEnum";
            this.btnIEnum.Size = new System.Drawing.Size(158, 38);
            this.btnIEnum.TabIndex = 9;
            this.btnIEnum.Text = "IEnum";
            this.btnIEnum.UseVisualStyleBackColor = true;
            this.btnIEnum.Click += new System.EventHandler(this.btnIEnum_Click);
            // 
            // btnForEach
            // 
            this.btnForEach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnForEach.Location = new System.Drawing.Point(798, 458);
            this.btnForEach.Margin = new System.Windows.Forms.Padding(4);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(158, 38);
            this.btnForEach.TabIndex = 10;
            this.btnForEach.Text = "ForEach";
            this.btnForEach.UseVisualStyleBackColor = true;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // frmDonguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(972, 519);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.btnIEnum);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.listBoxForEach);
            this.Controls.Add(this.listBoxIEnum);
            this.Controls.Add(this.listBoxDoWhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.listBoxFor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonguler";
            this.Text = "Döngüler ve Listbox Formu";
            this.Load += new System.EventHandler(this.frmDonguler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.ListBox listBoxDoWhile;
        private System.Windows.Forms.ListBox listBoxIEnum;
        private System.Windows.Forms.ListBox listBoxForEach;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnIEnum;
        private System.Windows.Forms.Button btnForEach;
    }
}

