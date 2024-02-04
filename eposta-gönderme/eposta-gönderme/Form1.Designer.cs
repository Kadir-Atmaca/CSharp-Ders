namespace eposta_gönderme
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Konu = new System.Windows.Forms.TextBox();
            this.altBaslik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 201);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Konu
            // 
            this.Konu.Location = new System.Drawing.Point(12, 219);
            this.Konu.Multiline = true;
            this.Konu.Name = "Konu";
            this.Konu.Size = new System.Drawing.Size(775, 69);
            this.Konu.TabIndex = 1;
            // 
            // altBaslik
            // 
            this.altBaslik.Location = new System.Drawing.Point(13, 294);
            this.altBaslik.Multiline = true;
            this.altBaslik.Name = "altBaslik";
            this.altBaslik.Size = new System.Drawing.Size(775, 72);
            this.altBaslik.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "https://www.youtube.com/@kadiratmaca1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altBaslik);
            this.Controls.Add(this.Konu);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Konu;
        private System.Windows.Forms.TextBox altBaslik;
        private System.Windows.Forms.Label label1;
    }
}

