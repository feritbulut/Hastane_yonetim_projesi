namespace Hastane_proje
{
    partial class HastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKayit));
            this.Txtsifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Msktelefon = new System.Windows.Forms.MaskedTextBox();
            this.Cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnKaydol = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtsifre
            // 
            this.Txtsifre.Location = new System.Drawing.Point(205, 324);
            this.Txtsifre.Name = "Txtsifre";
            this.Txtsifre.Size = new System.Drawing.Size(174, 40);
            this.Txtsifre.TabIndex = 10;
            this.Txtsifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(205, 232);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(174, 40);
            this.MskTC.TabIndex = 9;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(117, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(205, 186);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(174, 40);
            this.Txtsoyad.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Soyad:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(205, 140);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(174, 40);
            this.Txtad.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(143, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(83, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefon:";
            // 
            // Msktelefon
            // 
            this.Msktelefon.Location = new System.Drawing.Point(205, 278);
            this.Msktelefon.Mask = "(999) 000-0000";
            this.Msktelefon.Name = "Msktelefon";
            this.Msktelefon.Size = new System.Drawing.Size(174, 40);
            this.Msktelefon.TabIndex = 17;
            // 
            // Cmbcinsiyet
            // 
            this.Cmbcinsiyet.FormattingEnabled = true;
            this.Cmbcinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.Cmbcinsiyet.Location = new System.Drawing.Point(205, 369);
            this.Cmbcinsiyet.Name = "Cmbcinsiyet";
            this.Cmbcinsiyet.Size = new System.Drawing.Size(174, 40);
            this.Cmbcinsiyet.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(76, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Cinsiyet:";
            // 
            // BtnKaydol
            // 
            this.BtnKaydol.Location = new System.Drawing.Point(205, 437);
            this.BtnKaydol.Name = "BtnKaydol";
            this.BtnKaydol.Size = new System.Drawing.Size(174, 43);
            this.BtnKaydol.TabIndex = 20;
            this.BtnKaydol.Text = "Kaydol";
            this.BtnKaydol.UseVisualStyleBackColor = true;
            this.BtnKaydol.Click += new System.EventHandler(this.BtnKaydol_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label7.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(116, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 39);
            this.label7.TabIndex = 21;
            this.label7.Text = "Hasta Kayıt";
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(445, 527);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnKaydol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cmbcinsiyet);
            this.Controls.Add(this.Msktelefon);
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
            this.Name = "HastaKayit";
            this.Text = " Hasta Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtsifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Msktelefon;
        private System.Windows.Forms.ComboBox Cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnKaydol;
        private System.Windows.Forms.Label label7;
    }
}