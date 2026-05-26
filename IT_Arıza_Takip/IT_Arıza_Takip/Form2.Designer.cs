namespace IT_Arıza_Takip
{
    partial class Form2
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kayitİsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaDetay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GüncellemeTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÇözülmeDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Güncelleme_Tarih = new System.Windows.Forms.TextBox();
            this.Txt_Ariza_Tarih = new System.Windows.Forms.TextBox();
            this.Cmb_Cozülme_durum = new System.Windows.Forms.ComboBox();
            this.Btn_Ekle = new System.Windows.Forms.Button();
            this.Btn_Sil = new System.Windows.Forms.Button();
            this.Lbl_Cozülme_Durum = new System.Windows.Forms.Label();
            this.Lbl_Güncelleme_Trh = new System.Windows.Forms.Label();
            this.Lbl_Arz_Trh = new System.Windows.Forms.Label();
            this.Txt_Detay = new System.Windows.Forms.TextBox();
            this.Lbl_Detay = new System.Windows.Forms.Label();
            this.Cmb_Tür = new System.Windows.Forms.ComboBox();
            this.Lbl_Tür = new System.Windows.Forms.Label();
            this.Txt_İsim = new System.Windows.Forms.TextBox();
            this.Lbl_İsim = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Btn_Gorüntüle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Kayitİsim,
            this.ArizaTürü,
            this.ArizaDetay,
            this.ArizaTarih,
            this.GüncellemeTarih,
            this.ÇözülmeDurumu});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1023, 348);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Kayitİsim
            // 
            this.Kayitİsim.Text = "Kayitİsim";
            this.Kayitİsim.Width = 103;
            // 
            // ArizaTürü
            // 
            this.ArizaTürü.Text = "ArizaTürü";
            this.ArizaTürü.Width = 103;
            // 
            // ArizaDetay
            // 
            this.ArizaDetay.Text = "ArizaDetay";
            this.ArizaDetay.Width = 148;
            // 
            // ArizaTarih
            // 
            this.ArizaTarih.Text = "ArizaTarih";
            this.ArizaTarih.Width = 119;
            // 
            // GüncellemeTarih
            // 
            this.GüncellemeTarih.Text = "GüncellemeTarih";
            this.GüncellemeTarih.Width = 139;
            // 
            // ÇözülmeDurumu
            // 
            this.ÇözülmeDurumu.Text = "ÇözülmeDurumu";
            this.ÇözülmeDurumu.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Txt_Güncelleme_Tarih);
            this.panel1.Controls.Add(this.Txt_Ariza_Tarih);
            this.panel1.Controls.Add(this.Cmb_Cozülme_durum);
            this.panel1.Controls.Add(this.Btn_Ekle);
            this.panel1.Controls.Add(this.Btn_Sil);
            this.panel1.Controls.Add(this.Lbl_Cozülme_Durum);
            this.panel1.Controls.Add(this.Lbl_Güncelleme_Trh);
            this.panel1.Controls.Add(this.Lbl_Arz_Trh);
            this.panel1.Controls.Add(this.Txt_Detay);
            this.panel1.Controls.Add(this.Lbl_Detay);
            this.panel1.Controls.Add(this.Cmb_Tür);
            this.panel1.Controls.Add(this.Lbl_Tür);
            this.panel1.Controls.Add(this.Txt_İsim);
            this.panel1.Controls.Add(this.Lbl_İsim);
            this.panel1.Location = new System.Drawing.Point(12, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1023, 272);
            this.panel1.TabIndex = 2;
            // 
            // Txt_Güncelleme_Tarih
            // 
            this.Txt_Güncelleme_Tarih.Location = new System.Drawing.Point(547, 58);
            this.Txt_Güncelleme_Tarih.Name = "Txt_Güncelleme_Tarih";
            this.Txt_Güncelleme_Tarih.Size = new System.Drawing.Size(189, 22);
            this.Txt_Güncelleme_Tarih.TabIndex = 22;
            // 
            // Txt_Ariza_Tarih
            // 
            this.Txt_Ariza_Tarih.Location = new System.Drawing.Point(547, 12);
            this.Txt_Ariza_Tarih.Name = "Txt_Ariza_Tarih";
            this.Txt_Ariza_Tarih.Size = new System.Drawing.Size(189, 22);
            this.Txt_Ariza_Tarih.TabIndex = 21;
            // 
            // Cmb_Cozülme_durum
            // 
            this.Cmb_Cozülme_durum.FormattingEnabled = true;
            this.Cmb_Cozülme_durum.Items.AddRange(new object[] {
            "Bekliyor - 1",
            "İncelemede - 2",
            "Çözüldü - 3",
            "İptal Edildi - 4  "});
            this.Cmb_Cozülme_durum.Location = new System.Drawing.Point(547, 99);
            this.Cmb_Cozülme_durum.Name = "Cmb_Cozülme_durum";
            this.Cmb_Cozülme_durum.Size = new System.Drawing.Size(189, 24);
            this.Cmb_Cozülme_durum.TabIndex = 20;
            // 
            // Btn_Ekle
            // 
            this.Btn_Ekle.Location = new System.Drawing.Point(847, 56);
            this.Btn_Ekle.Name = "Btn_Ekle";
            this.Btn_Ekle.Size = new System.Drawing.Size(168, 62);
            this.Btn_Ekle.TabIndex = 19;
            this.Btn_Ekle.Text = "Ekle";
            this.Btn_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Ekle.Click += new System.EventHandler(this.Btn_Ekle_Click);
            // 
            // Btn_Sil
            // 
            this.Btn_Sil.Location = new System.Drawing.Point(847, 130);
            this.Btn_Sil.Name = "Btn_Sil";
            this.Btn_Sil.Size = new System.Drawing.Size(168, 62);
            this.Btn_Sil.TabIndex = 18;
            this.Btn_Sil.Text = "Sil";
            this.Btn_Sil.UseVisualStyleBackColor = true;
            this.Btn_Sil.Click += new System.EventHandler(this.Btn_Sil_Click);
            // 
            // Lbl_Cozülme_Durum
            // 
            this.Lbl_Cozülme_Durum.AutoSize = true;
            this.Lbl_Cozülme_Durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Cozülme_Durum.Location = new System.Drawing.Point(371, 101);
            this.Lbl_Cozülme_Durum.Name = "Lbl_Cozülme_Durum";
            this.Lbl_Cozülme_Durum.Size = new System.Drawing.Size(140, 20);
            this.Lbl_Cozülme_Durum.TabIndex = 11;
            this.Lbl_Cozülme_Durum.Text = "Cözülme Durumu";
            // 
            // Lbl_Güncelleme_Trh
            // 
            this.Lbl_Güncelleme_Trh.AutoSize = true;
            this.Lbl_Güncelleme_Trh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Güncelleme_Trh.Location = new System.Drawing.Point(371, 56);
            this.Lbl_Güncelleme_Trh.Name = "Lbl_Güncelleme_Trh";
            this.Lbl_Güncelleme_Trh.Size = new System.Drawing.Size(145, 20);
            this.Lbl_Güncelleme_Trh.TabIndex = 9;
            this.Lbl_Güncelleme_Trh.Text = "Güncelleme Tarihi";
            // 
            // Lbl_Arz_Trh
            // 
            this.Lbl_Arz_Trh.AutoSize = true;
            this.Lbl_Arz_Trh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Arz_Trh.Location = new System.Drawing.Point(371, 13);
            this.Lbl_Arz_Trh.Name = "Lbl_Arz_Trh";
            this.Lbl_Arz_Trh.Size = new System.Drawing.Size(95, 20);
            this.Lbl_Arz_Trh.TabIndex = 8;
            this.Lbl_Arz_Trh.Text = "Arıza Tarihi";
            // 
            // Txt_Detay
            // 
            this.Txt_Detay.Location = new System.Drawing.Point(137, 101);
            this.Txt_Detay.Multiline = true;
            this.Txt_Detay.Name = "Txt_Detay";
            this.Txt_Detay.Size = new System.Drawing.Size(189, 153);
            this.Txt_Detay.TabIndex = 6;
            // 
            // Lbl_Detay
            // 
            this.Lbl_Detay.AutoSize = true;
            this.Lbl_Detay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Detay.Location = new System.Drawing.Point(15, 98);
            this.Lbl_Detay.Name = "Lbl_Detay";
            this.Lbl_Detay.Size = new System.Drawing.Size(97, 20);
            this.Lbl_Detay.TabIndex = 5;
            this.Lbl_Detay.Text = "Arıza Detay";
            // 
            // Cmb_Tür
            // 
            this.Cmb_Tür.FormattingEnabled = true;
            this.Cmb_Tür.Items.AddRange(new object[] {
            "1- Yazılım",
            "2 - Donanım",
            "3- Network",
            "4- Güvenlik"});
            this.Cmb_Tür.Location = new System.Drawing.Point(137, 56);
            this.Cmb_Tür.Name = "Cmb_Tür";
            this.Cmb_Tür.Size = new System.Drawing.Size(189, 24);
            this.Cmb_Tür.TabIndex = 4;
            // 
            // Lbl_Tür
            // 
            this.Lbl_Tür.AutoSize = true;
            this.Lbl_Tür.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Tür.Location = new System.Drawing.Point(14, 56);
            this.Lbl_Tür.Name = "Lbl_Tür";
            this.Lbl_Tür.Size = new System.Drawing.Size(87, 20);
            this.Lbl_Tür.TabIndex = 2;
            this.Lbl_Tür.Text = "Arıza Türü";
            // 
            // Txt_İsim
            // 
            this.Txt_İsim.Location = new System.Drawing.Point(137, 11);
            this.Txt_İsim.Name = "Txt_İsim";
            this.Txt_İsim.Size = new System.Drawing.Size(189, 22);
            this.Txt_İsim.TabIndex = 1;
            // 
            // Lbl_İsim
            // 
            this.Lbl_İsim.AutoSize = true;
            this.Lbl_İsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_İsim.Location = new System.Drawing.Point(15, 13);
            this.Lbl_İsim.Name = "Lbl_İsim";
            this.Lbl_İsim.Size = new System.Drawing.Size(82, 20);
            this.Lbl_İsim.TabIndex = 0;
            this.Lbl_İsim.Text = "Kayıt İsim";
            // 
            // Btn_Gorüntüle
            // 
            this.Btn_Gorüntüle.Location = new System.Drawing.Point(1054, 33);
            this.Btn_Gorüntüle.Name = "Btn_Gorüntüle";
            this.Btn_Gorüntüle.Size = new System.Drawing.Size(243, 47);
            this.Btn_Gorüntüle.TabIndex = 20;
            this.Btn_Gorüntüle.Text = "Görüntüle";
            this.Btn_Gorüntüle.UseVisualStyleBackColor = true;
            this.Btn_Gorüntüle.Click += new System.EventHandler(this.Btn_Gorüntüle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1078, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "1- Yazılım";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1078, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "2- Donanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1078, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "3- Network";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1078, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "4- Güvenlik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1055, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Arıza Türleri ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1145, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 85);
            this.button1.TabIndex = 26;
            this.button1.Text = "Düzenlemeden Çık";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1145, 600);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 85);
            this.button2.TabIndex = 27;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 710);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Gorüntüle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form2";
            this.Text = "Düzenle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Kayitİsim;
        private System.Windows.Forms.ColumnHeader ArizaTürü;
        private System.Windows.Forms.ColumnHeader ArizaDetay;
        private System.Windows.Forms.ColumnHeader ArizaTarih;
        private System.Windows.Forms.ColumnHeader GüncellemeTarih;
        private System.Windows.Forms.ColumnHeader ÇözülmeDurumu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_İsim;
        private System.Windows.Forms.ComboBox Cmb_Tür;
        private System.Windows.Forms.Label Lbl_Tür;
        private System.Windows.Forms.TextBox Txt_İsim;
        private System.Windows.Forms.TextBox Txt_Detay;
        private System.Windows.Forms.Label Lbl_Detay;
        private System.Windows.Forms.Label Lbl_Arz_Trh;
        private System.Windows.Forms.Label Lbl_Güncelleme_Trh;
        private System.Windows.Forms.Label Lbl_Cozülme_Durum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Btn_Ekle;
        private System.Windows.Forms.Button Btn_Sil;
        private System.Windows.Forms.Button Btn_Gorüntüle;
        private System.Windows.Forms.ComboBox Cmb_Cozülme_durum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Güncelleme_Tarih;
        private System.Windows.Forms.TextBox Txt_Ariza_Tarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}