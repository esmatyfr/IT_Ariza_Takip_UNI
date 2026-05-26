namespace IT_Arıza_Takip
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kayitİsim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaTürü = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaDetay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArizaTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GüncellemeTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÇözülmeDurumu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbbox_arizatür = new System.Windows.Forms.ComboBox();
            this.lbl_arizatür = new System.Windows.Forms.Label();
            this.Lbl_ToplamAriza = new System.Windows.Forms.Label();
            this.Lbl_Cozulen = new System.Windows.Forms.Label();
            this.Lbl_Bekleyen = new System.Windows.Forms.Label();
            this.Lbl_Toplamİnceleme = new System.Windows.Forms.Label();
            this.Lbl_Toplamİptal = new System.Windows.Forms.Label();
            this.Txt_İsim_Ara = new System.Windows.Forms.TextBox();
            this.Lbl_İsim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Cozum_Sure = new System.Windows.Forms.Label();
            this.Lbl_ort_yazı = new System.Windows.Forms.Label();
            this.Btn_Form2_Ac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1023, 348);
            this.listView1.TabIndex = 0;
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
            // cmbbox_arizatür
            // 
            this.cmbbox_arizatür.FormattingEnabled = true;
            this.cmbbox_arizatür.Location = new System.Drawing.Point(12, 35);
            this.cmbbox_arizatür.Name = "cmbbox_arizatür";
            this.cmbbox_arizatür.Size = new System.Drawing.Size(199, 24);
            this.cmbbox_arizatür.TabIndex = 2;
            this.cmbbox_arizatür.SelectedIndexChanged += new System.EventHandler(this.cmbbox_arizatür_SelectedIndexChanged);
            // 
            // lbl_arizatür
            // 
            this.lbl_arizatür.AutoSize = true;
            this.lbl_arizatür.Location = new System.Drawing.Point(12, 9);
            this.lbl_arizatür.Name = "lbl_arizatür";
            this.lbl_arizatür.Size = new System.Drawing.Size(67, 16);
            this.lbl_arizatür.TabIndex = 4;
            this.lbl_arizatür.Text = "Arıza Türü";
            // 
            // Lbl_ToplamAriza
            // 
            this.Lbl_ToplamAriza.AutoSize = true;
            this.Lbl_ToplamAriza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ToplamAriza.ForeColor = System.Drawing.Color.Black;
            this.Lbl_ToplamAriza.Location = new System.Drawing.Point(12, 455);
            this.Lbl_ToplamAriza.Name = "Lbl_ToplamAriza";
            this.Lbl_ToplamAriza.Size = new System.Drawing.Size(132, 20);
            this.Lbl_ToplamAriza.TabIndex = 6;
            this.Lbl_ToplamAriza.Text = "Toplam Ariza: ";
            // 
            // Lbl_Cozulen
            // 
            this.Lbl_Cozulen.AutoSize = true;
            this.Lbl_Cozulen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Cozulen.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Cozulen.Location = new System.Drawing.Point(12, 492);
            this.Lbl_Cozulen.Name = "Lbl_Cozulen";
            this.Lbl_Cozulen.Size = new System.Drawing.Size(140, 20);
            this.Lbl_Cozulen.TabIndex = 7;
            this.Lbl_Cozulen.Text = "Toplam Çözülen: ";
            // 
            // Lbl_Bekleyen
            // 
            this.Lbl_Bekleyen.AutoSize = true;
            this.Lbl_Bekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Bekleyen.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_Bekleyen.Location = new System.Drawing.Point(12, 530);
            this.Lbl_Bekleyen.Name = "Lbl_Bekleyen";
            this.Lbl_Bekleyen.Size = new System.Drawing.Size(166, 20);
            this.Lbl_Bekleyen.TabIndex = 8;
            this.Lbl_Bekleyen.Text = "Toplam Bekleyenler: ";
            // 
            // Lbl_Toplamİnceleme
            // 
            this.Lbl_Toplamİnceleme.AutoSize = true;
            this.Lbl_Toplamİnceleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Toplamİnceleme.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Toplamİnceleme.Location = new System.Drawing.Point(11, 567);
            this.Lbl_Toplamİnceleme.Name = "Lbl_Toplamİnceleme";
            this.Lbl_Toplamİnceleme.Size = new System.Drawing.Size(165, 20);
            this.Lbl_Toplamİnceleme.TabIndex = 9;
            this.Lbl_Toplamİnceleme.Text = "Toplam İncelemeler: ";
            // 
            // Lbl_Toplamİptal
            // 
            this.Lbl_Toplamİptal.AutoSize = true;
            this.Lbl_Toplamİptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Toplamİptal.ForeColor = System.Drawing.Color.DimGray;
            this.Lbl_Toplamİptal.Location = new System.Drawing.Point(8, 603);
            this.Lbl_Toplamİptal.Name = "Lbl_Toplamİptal";
            this.Lbl_Toplamİptal.Size = new System.Drawing.Size(180, 20);
            this.Lbl_Toplamİptal.TabIndex = 10;
            this.Lbl_Toplamİptal.Text = "Toplam İptal Edilenler: ";
            // 
            // Txt_İsim_Ara
            // 
            this.Txt_İsim_Ara.Location = new System.Drawing.Point(375, 36);
            this.Txt_İsim_Ara.Name = "Txt_İsim_Ara";
            this.Txt_İsim_Ara.Size = new System.Drawing.Size(226, 22);
            this.Txt_İsim_Ara.TabIndex = 11;
            this.Txt_İsim_Ara.TextChanged += new System.EventHandler(this.Txt_İsim_Ara_TextChanged);
            // 
            // Lbl_İsim
            // 
            this.Lbl_İsim.AutoSize = true;
            this.Lbl_İsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_İsim.Location = new System.Drawing.Point(372, 10);
            this.Lbl_İsim.Name = "Lbl_İsim";
            this.Lbl_İsim.Size = new System.Drawing.Size(79, 18);
            this.Lbl_İsim.TabIndex = 12;
            this.Lbl_İsim.Text = "İsim İle Ara";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Lbl_Cozum_Sure);
            this.panel1.Controls.Add(this.Lbl_ort_yazı);
            this.panel1.Location = new System.Drawing.Point(457, 452);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 168);
            this.panel1.TabIndex = 13;
            // 
            // Lbl_Cozum_Sure
            // 
            this.Lbl_Cozum_Sure.AutoSize = true;
            this.Lbl_Cozum_Sure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Cozum_Sure.ForeColor = System.Drawing.Color.White;
            this.Lbl_Cozum_Sure.Location = new System.Drawing.Point(89, 80);
            this.Lbl_Cozum_Sure.Name = "Lbl_Cozum_Sure";
            this.Lbl_Cozum_Sure.Size = new System.Drawing.Size(27, 29);
            this.Lbl_Cozum_Sure.TabIndex = 1;
            this.Lbl_Cozum_Sure.Text = "0";
            // 
            // Lbl_ort_yazı
            // 
            this.Lbl_ort_yazı.AutoSize = true;
            this.Lbl_ort_yazı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_ort_yazı.ForeColor = System.Drawing.Color.White;
            this.Lbl_ort_yazı.Location = new System.Drawing.Point(-6, 21);
            this.Lbl_ort_yazı.Name = "Lbl_ort_yazı";
            this.Lbl_ort_yazı.Size = new System.Drawing.Size(284, 29);
            this.Lbl_ort_yazı.TabIndex = 0;
            this.Lbl_ort_yazı.Text = "Ortalama Çözüm Süresi";
            // 
            // Btn_Form2_Ac
            // 
            this.Btn_Form2_Ac.Location = new System.Drawing.Point(999, 452);
            this.Btn_Form2_Ac.Name = "Btn_Form2_Ac";
            this.Btn_Form2_Ac.Size = new System.Drawing.Size(200, 98);
            this.Btn_Form2_Ac.TabIndex = 14;
            this.Btn_Form2_Ac.Text = "Ekle/Düzenle";
            this.Btn_Form2_Ac.UseVisualStyleBackColor = true;
            this.Btn_Form2_Ac.Click += new System.EventHandler(this.Btn_Form2_Ac_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(999, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Form2_Ac);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_İsim);
            this.Controls.Add(this.Txt_İsim_Ara);
            this.Controls.Add(this.Lbl_Toplamİptal);
            this.Controls.Add(this.Lbl_Toplamİnceleme);
            this.Controls.Add(this.Lbl_Bekleyen);
            this.Controls.Add(this.Lbl_Cozulen);
            this.Controls.Add(this.Lbl_ToplamAriza);
            this.Controls.Add(this.lbl_arizatür);
            this.Controls.Add(this.cmbbox_arizatür);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "IT Arıza Takip";
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
        private System.Windows.Forms.ComboBox cmbbox_arizatür;
        private System.Windows.Forms.Label lbl_arizatür;
        private System.Windows.Forms.Label Lbl_ToplamAriza;
        private System.Windows.Forms.Label Lbl_Cozulen;
        private System.Windows.Forms.Label Lbl_Bekleyen;
        private System.Windows.Forms.Label Lbl_Toplamİnceleme;
        private System.Windows.Forms.Label Lbl_Toplamİptal;
        private System.Windows.Forms.TextBox Txt_İsim_Ara;
        private System.Windows.Forms.Label Lbl_İsim;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ort_yazı;
        private System.Windows.Forms.Label Lbl_Cozum_Sure;
        private System.Windows.Forms.Button Btn_Form2_Ac;
        private System.Windows.Forms.Button button1;
    }
}

