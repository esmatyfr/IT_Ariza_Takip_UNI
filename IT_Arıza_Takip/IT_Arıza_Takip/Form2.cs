using IT_Arıza_Takip.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IT_Arıza_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=IT_Arıza_Takip; Integrated Security=True");

        // Verileri listeleme 
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

            while (oku.Read()) // Okunacak veri olduğu sürece dön 
            {
                ListViewItem ekle = new ListViewItem(oku["ID"].ToString()); // İlk sütun 
                ekle.SubItems.Add(oku["Kayitİsim"].ToString());
                ekle.SubItems.Add(oku["TurAd"].ToString());
                ekle.SubItems.Add(oku["ArizaDetay"].ToString());

                ekle.SubItems.Add(oku["ArizaTarih"].ToString());
                ekle.SubItems.Add(oku["GüncellemeTarih"].ToString());
                int durumSayi = Convert.ToInt32(oku["ÇözülmeDurumu"]);
                string durumIsmi = ((CozulmeDurumu)durumSayi).ToString();
                ekle.SubItems.Add(durumIsmi);
                listView1.Items.Add(ekle); // Satırı ListView'e ekle
            }
            oku.Close();
            baglan.Close(); // Bağlantıyı kapat 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            verileriGoster(); // İlk açılışta verileri listele
        }
        // Verileri yenilemek için kullanılabilir
        private void Btn_Gorüntüle_Click(object sender, EventArgs e)
        {
            verileriGoster(); // Butona tıklanınca verileri listele
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into ArizaKaydi (Kayitİsim, ArizaTürü, ArizaDetay, ArizaTarih, GüncellemeTarih, ÇözülmeDurumu) " +
                "values ('" + Txt_İsim.Text + "', '" +
                (Cmb_Tür.SelectedIndex + 1 ) + "', '" +
                Txt_Detay.Text + "', '" +
                Convert.ToDateTime(Txt_Ariza_Tarih.Text).ToString("yyyy-MM-dd") + "', '" +
                Convert.ToDateTime(Txt_Güncelleme_Tarih.Text).ToString("yyyy-MM-dd") + "', '" +
                (Cmb_Cozülme_durum.SelectedIndex + 1) + "')", baglan);
            komut.ExecuteNonQuery(); // veriler değiştiriği için ExecuteNonQuery kullanılır
            baglan.Close();
            verileriGoster(); // Verileri tekrar listele
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            // ListView'de seçili olan öğeleri sil
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int id = Convert.ToInt32(item.SubItems[0].Text); // ID sütunu
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM ArizaKaydi WHERE ID = " + id, baglan);
                komut.ExecuteNonQuery();  // veriler değiştiriği için ExecuteNonQuery kullanılır
                baglan.Close();
            }
            Btn_Gorüntüle.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Uygulamayı kapat
            Application.Exit();
        }
    }
}
