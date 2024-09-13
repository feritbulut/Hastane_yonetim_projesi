namespace Hastane_proje
{
    partial class Girisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girisler));
            this.hastagiris = new System.Windows.Forms.Button();
            this.doktorgiris = new System.Windows.Forms.Button();
            this.sekretergiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hastagiris
            // 
            this.hastagiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastagiris.BackgroundImage")));
            this.hastagiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hastagiris.Location = new System.Drawing.Point(94, 129);
            this.hastagiris.Name = "hastagiris";
            this.hastagiris.Size = new System.Drawing.Size(225, 199);
            this.hastagiris.TabIndex = 0;
            this.hastagiris.UseVisualStyleBackColor = true;
            this.hastagiris.Click += new System.EventHandler(this.hastagiris_Click);
            // 
            // doktorgiris
            // 
            this.doktorgiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorgiris.BackgroundImage")));
            this.doktorgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doktorgiris.Location = new System.Drawing.Point(335, 129);
            this.doktorgiris.Name = "doktorgiris";
            this.doktorgiris.Size = new System.Drawing.Size(225, 199);
            this.doktorgiris.TabIndex = 1;
            this.doktorgiris.UseVisualStyleBackColor = true;
            this.doktorgiris.Click += new System.EventHandler(this.doktorgiris_Click);
            // 
            // sekretergiris
            // 
            this.sekretergiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekretergiris.BackgroundImage")));
            this.sekretergiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sekretergiris.Location = new System.Drawing.Point(577, 129);
            this.sekretergiris.Name = "sekretergiris";
            this.sekretergiris.Size = new System.Drawing.Size(225, 199);
            this.sekretergiris.TabIndex = 2;
            this.sekretergiris.UseVisualStyleBackColor = true;
            this.sekretergiris.Click += new System.EventHandler(this.sekretergiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(162, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(393, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(634, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Font = new System.Drawing.Font("Century", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FloralWhite;
            this.label4.Location = new System.Drawing.Point(160, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 47);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hastane Giriş Sistemi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(891, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sekretergiris);
            this.Controls.Add(this.doktorgiris);
            this.Controls.Add(this.hastagiris);
            this.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Girisler";
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hastagiris;
        private System.Windows.Forms.Button doktorgiris;
        private System.Windows.Forms.Button sekretergiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

