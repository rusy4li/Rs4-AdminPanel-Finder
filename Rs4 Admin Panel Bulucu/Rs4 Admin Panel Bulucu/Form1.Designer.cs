namespace Rs4_Admin_Panel_Bulucu
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.site_giris_text = new System.Windows.Forms.TextBox();
            this.onay_button = new System.Windows.Forms.Button();
            this.fast_radio = new System.Windows.Forms.RadioButton();
            this.full_radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.temizle_button = new System.Windows.Forms.Button();
            this.durdur_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.gecmis_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.goster_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // site_giris_text
            // 
            this.site_giris_text.Location = new System.Drawing.Point(15, 180);
            this.site_giris_text.Multiline = true;
            this.site_giris_text.Name = "site_giris_text";
            this.site_giris_text.Size = new System.Drawing.Size(325, 20);
            this.site_giris_text.TabIndex = 1;
            // 
            // onay_button
            // 
            this.onay_button.BackColor = System.Drawing.Color.White;
            this.onay_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.onay_button.Location = new System.Drawing.Point(138, 243);
            this.onay_button.Name = "onay_button";
            this.onay_button.Size = new System.Drawing.Size(75, 35);
            this.onay_button.TabIndex = 2;
            this.onay_button.Text = "Onayla";
            this.onay_button.UseVisualStyleBackColor = false;
            this.onay_button.Click += new System.EventHandler(this.onay_button_Click);
            // 
            // fast_radio
            // 
            this.fast_radio.AutoSize = true;
            this.fast_radio.Location = new System.Drawing.Point(255, 232);
            this.fast_radio.Name = "fast_radio";
            this.fast_radio.Size = new System.Drawing.Size(91, 20);
            this.fast_radio.TabIndex = 3;
            this.fast_radio.TabStop = true;
            this.fast_radio.Text = "Fast Scan";
            this.fast_radio.UseVisualStyleBackColor = true;
            // 
            // full_radio
            // 
            this.full_radio.AutoSize = true;
            this.full_radio.Location = new System.Drawing.Point(255, 206);
            this.full_radio.Name = "full_radio";
            this.full_radio.Size = new System.Drawing.Size(85, 20);
            this.full_radio.TabIndex = 4;
            this.full_radio.TabStop = true;
            this.full_radio.Text = "Full Scan";
            this.full_radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Site:";
            // 
            // temizle_button
            // 
            this.temizle_button.BackColor = System.Drawing.Color.White;
            this.temizle_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.temizle_button.Location = new System.Drawing.Point(202, 482);
            this.temizle_button.Name = "temizle_button";
            this.temizle_button.Size = new System.Drawing.Size(75, 23);
            this.temizle_button.TabIndex = 8;
            this.temizle_button.Text = "Temizle";
            this.temizle_button.UseVisualStyleBackColor = false;
            this.temizle_button.Click += new System.EventHandler(this.temizle_button_Click);
            // 
            // durdur_button
            // 
            this.durdur_button.BackColor = System.Drawing.Color.White;
            this.durdur_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.durdur_button.Location = new System.Drawing.Point(66, 482);
            this.durdur_button.Name = "durdur_button";
            this.durdur_button.Size = new System.Drawing.Size(75, 23);
            this.durdur_button.TabIndex = 9;
            this.durdur_button.Text = "Durdur";
            this.durdur_button.UseVisualStyleBackColor = false;
            this.durdur_button.Click += new System.EventHandler(this.durdur_button_Click);
            // 
            // help_button
            // 
            this.help_button.BackColor = System.Drawing.Color.White;
            this.help_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.help_button.Location = new System.Drawing.Point(135, 529);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(75, 23);
            this.help_button.TabIndex = 10;
            this.help_button.Text = "help";
            this.help_button.UseVisualStyleBackColor = false;
            this.help_button.Click += new System.EventHandler(this.help_button_Click);
            // 
            // gecmis_label
            // 
            this.gecmis_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gecmis_label.Location = new System.Drawing.Point(15, 291);
            this.gecmis_label.Name = "gecmis_label";
            this.gecmis_label.Size = new System.Drawing.Size(162, 21);
            this.gecmis_label.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // goster_textbox
            // 
            this.goster_textbox.Location = new System.Drawing.Point(15, 312);
            this.goster_textbox.Multiline = true;
            this.goster_textbox.Name = "goster_textbox";
            this.goster_textbox.ReadOnly = true;
            this.goster_textbox.Size = new System.Drawing.Size(325, 164);
            this.goster_textbox.TabIndex = 15;
            // 
            // Form
            // 
            this.AcceptButton = this.onay_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(352, 559);
            this.Controls.Add(this.goster_textbox);
            this.Controls.Add(this.gecmis_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.durdur_button);
            this.Controls.Add(this.temizle_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.full_radio);
            this.Controls.Add(this.fast_radio);
            this.Controls.Add(this.onay_button);
            this.Controls.Add(this.site_giris_text);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rs4 Admin Panel Bulucu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox site_giris_text;
        private System.Windows.Forms.Button onay_button;
        private System.Windows.Forms.RadioButton fast_radio;
        private System.Windows.Forms.RadioButton full_radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button temizle_button;
        private System.Windows.Forms.Button durdur_button;
        private System.Windows.Forms.Button help_button;
        private System.Windows.Forms.Label gecmis_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox goster_textbox;
    }
}

