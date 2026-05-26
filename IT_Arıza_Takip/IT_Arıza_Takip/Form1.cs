using IT_Arıza_Takip.Entities;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IT_Arıza_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            cmbbox_arizatür.SelectedIndexChanged += cmbbox_arizatür_SelectedIndexChanged;
        }

        // Veritabanı bağlantısı
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=IT_Arıza_Takip; Integrated Security=True");

        // Verileri listeleme metodu 
        private void verileriGoster(string filtreSql = "")
        {
            listView1.Items.Clear(); // Önce listeyi temizle 
            if (baglan.State == ConnectionState.Closed)
                baglan.Open(); // Bağlantıyı aç

            // Eğer filtre yoksa hepsini getir, varsa filtreli sorguyu çalıştır
            string sql =
                "SELECT ak.ID, ak.Kayitİsim, at.TurAd, ak.ArizaDetay, ak.ArizaTarih, ak.GüncellemeTarih, ak.ÇözülmeDurumu " +
                "FROM ArizaKaydi ak LEFT JOIN ArizaTurleri at ON at.ID = ak.ArizaTürü " + filtreSql;

            SqlCommand komut = new SqlCommand(sql, baglan); // Sorguyu hazırla 
            SqlDataReader oku = komut.ExecuteReader(); // Verileri oku 

            int ordArizaTarih = oku.GetOrdinal("ArizaTarih");
            int ordGuncellemeTarih = oku.GetOrdinal("GüncellemeTarih");

            while (oku.Read()) // Okunacak veri olduğu sürece dön 
            {
                ListViewItem ekle = new ListViewItem(oku["ID"].ToString()); // İlk sütun 
                ekle.SubItems.Add(oku["Kayitİsim"].ToString());
                ekle.SubItems.Add(oku["TurAd"].ToString());
                ekle.SubItems.Add(oku["ArizaDetay"].ToString());

                ekle.SubItems.Add(oku.IsDBNull(ordArizaTarih) ? "" : oku.GetDateTime(ordArizaTarih).ToShortDateString());
                ekle.SubItems.Add(oku.IsDBNull(ordGuncellemeTarih) ? "" : oku.GetDateTime(ordGuncellemeTarih).ToShortDateString());
                int durumSayi = Convert.ToInt32(oku["ÇözülmeDurumu"]);
                string durumIsmi = ((CozulmeDurumu)durumSayi).ToString();
                ekle.SubItems.Add(durumIsmi);
                listView1.Items.Add(ekle); // Satırı ListView'e ekle
            }
            oku.Close();
            baglan.Close(); // Bağlantıyı kapat 
        }

        // Bu metot sadece renklendirme ve sayım yapar
        private void DurumlariRenklendirVeSay()
        {
            int toplamAriza = listView1.Items.Count;
            int cozulen = 0;
            int bekleyen = 0;
            int incelemede = 0;
            int iptal = 0;

            listView1.BeginUpdate(); // Performans için başlat

            foreach (ListViewItem item in listView1.Items)
            {
                // Eğer 6. sütun boş gelirse hata vermesin diye kontrol ekleyelim
                if (item.SubItems.Count <= 6) continue;

                string durum = item.SubItems[6].Text;

                item.UseItemStyleForSubItems = true; // Tüm satırı boya

                if (durum == "Cozuldu" || durum == "3")
                {
                    cozulen++;
                    item.BackColor = Color.LightGreen;
                    item.ForeColor = Color.Black;
                }
                else if (durum == "Bekliyor" || durum == "1")
                {
                    bekleyen++;
                    item.BackColor = Color.Orange;
                    item.ForeColor = Color.White;
                }
                else if (durum == "Incelemede" || durum == "2")
                {
                    incelemede++;
                    item.BackColor = Color.LightSkyBlue;
                    item.ForeColor = Color.Black;
                }
                else
                {
                    iptal++;
                    item.BackColor = Color.LightGray;
                    item.ForeColor = Color.DarkRed;
                }
            }

            listView1.EndUpdate(); // Çizimi bitir

            // Label'ları güncelle
            Lbl_ToplamAriza.Text = "Toplam Arıza: " + toplamAriza;
            Lbl_Cozulen.Text = "Çözülen: " + cozulen;
            Lbl_Bekleyen.Text = "Bekleyen: " + bekleyen;
            Lbl_Toplamİnceleme.Text = "İncelemede: " + incelemede;
            Lbl_Toplamİptal.Text = "İptal: " + iptal;
        }

        // Ortalama çözülme süresi metodu 
        private void OrtalamaCozulmeSuresi()
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            string sql = "SELECT ArizaTarih, GüncellemeTarih FROM ArizaKaydi WHERE ÇözülmeDurumu = 3";
            SqlCommand komut = new SqlCommand(sql, baglan);
            SqlDataReader oku = komut.ExecuteReader();

            double toplamDakika = 0;
            int sayac = 0;
            while (oku.Read())
            {
                DateTime başlangic = Convert.ToDateTime(oku["ArizaTarih"]);
                DateTime bitis = Convert.ToDateTime(oku["GüncellemeTarih"]);
                // iki tarih arasındaki farkı buluyoruz
                TimeSpan fark = bitis - başlangic;
                toplamDakika += fark.TotalDays; // toplam dakikaya ekle
                sayac++;
            }
            if(sayac > 0)
            {
                double ortalama = toplamDakika / sayac;
                Lbl_Cozum_Sure.Text = Math.Round(ortalama, 1).ToString() + " / Gün";
            }
            else
            {
                Lbl_Cozum_Sure.Text = "0";
            }
            oku.Close();
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Arıza türlerini ComboBox'a doldur
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT ID, TurAd FROM ArizaTurleri", baglan);
            SqlDataReader oku = komut.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(oku);

            // "Tümü" seçeneği ekleme 
            DataRow satir = dt.NewRow();
            satir["ID"] = 0;
            satir["TurAd"] = "Tümü";
            dt.Rows.InsertAt(satir, 0);

            cmbbox_arizatür.DataSource = dt;
            cmbbox_arizatür.DisplayMember = "TurAd";
            cmbbox_arizatür.ValueMember = "ID";

            oku.Close();
            baglan.Close();

            verileriGoster(); // İlk açılışta verileri listele
            DurumlariRenklendirVeSay(); // Renkleri ve sayımları yap
            OrtalamaCozulmeSuresi(); // Ortalama çözülme süresini hesapla
        }

        private void cmbbox_arizatür_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbox_arizatür.SelectedIndex == 0) // "Tümü" seçildiyse
            {
                verileriGoster();
                DurumlariRenklendirVeSay();
            }
            else // Belirli bir tür seçildiyse
            {
                string id = cmbbox_arizatür.SelectedValue.ToString();
                verileriGoster("WHERE ak.ArizaTürü = " + id);
                DurumlariRenklendirVeSay();
            }
        }

        private void Txt_İsim_Ara_TextChanged(object sender, EventArgs e)
        {
            string aranan = Txt_İsim_Ara.Text.Trim();
            if (string.IsNullOrEmpty(aranan))
            {
                verileriGoster();
            }
            else
            {
                verileriGoster("WHERE ak.Kayitİsim LIKE '%" + aranan + "%'");
            }
            DurumlariRenklendirVeSay();
        }

        private void Btn_Form2_Ac_Click(object sender, EventArgs e)
        {
            // Yeni arıza kaydı ekleme/ silme formunu aç
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Uygulamadan çıkış
            Application.Exit();
        }
    }
}