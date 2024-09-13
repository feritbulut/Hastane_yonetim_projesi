namespace Hastane_proje
{
    partial class Doktorbilgiduzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktorbilgiduzenle));
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btnbilgiguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(143, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ad:";
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(205, 160);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(174, 40);
            this.Txtsoyad.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Soyad:";
            // 
            // Txtsifre
            // 
            this.Txtsifre.Location = new System.Drawing.Point(205, 298);
            this.Txtsifre.Name = "Txtsifre";
            this.Txtsifre.Size = new System.Drawing.Size(174, 40);
            this.Txtsifre.TabIndex = 31;
            this.Txtsifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(205, 206);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(174, 40);
            this.MskTC.TabIndex = 30;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(118, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(11, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 28;
            this.label2.Text = "TC Kimlik No:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(205, 114);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(174, 40);
            this.Txtad.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(33, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 39);
            this.label5.TabIndex = 36;
            this.label5.Text = "Doktor Bilgi Düzenle";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(205, 252);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(174, 40);
            this.cmbbrans.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(105, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 38;
            this.label6.Text = "Branş:";
            // 
            // Btnbilgiguncelle
            // 
            this.Btnbilgiguncelle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btnbilgiguncelle.Location = new System.Drawing.Point(205, 356);
            this.Btnbilgiguncelle.Name = "Btnbilgiguncelle";
            this.Btnbilgiguncelle.Size = new System.Drawing.Size(174, 43);
            this.Btnbilgiguncelle.TabIndex = 39;
            this.Btnbilgiguncelle.Text = "Güncelle";
            this.Btnbilgiguncelle.UseVisualStyleBackColor = true;
            this.Btnbilgiguncelle.Click += new System.EventHandler(this.Btnbilgiguncelle_Click);
            // 
            // Doktorbilgiduzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(430, 425);
            this.Controls.Add(this.Btnbilgiguncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbbrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtsoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtsifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Doktorbilgiduzenle";
            this.Text = "Doktor bilgi duzenle";
            this.Load += new System.EventHandler(this.Doktorbilgiduzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btnbilgiguncelle;
    }
}