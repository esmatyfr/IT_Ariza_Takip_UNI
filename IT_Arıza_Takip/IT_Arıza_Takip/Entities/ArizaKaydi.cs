using System;

namespace IT_Arıza_Takip.Entities
{
    public class ArizaKaydi
    {
        // Birincil anahtar
        public int ID { get; set; }

        // Kaydı açan kişi bilgisi
        public string Kayitİsim { get; set; }

        // Arıza türü (FK - Foreign Key)
        // Veritabanında int olarak tutulur, ArizaTuru tablosuna bağlanır
        public int ArizaTürü { get; set; }

        // Arıza detayı
        public string ArizaDetay { get; set; }

        // Arıza tarihi
        public DateTime ArizaTarih { get; set; }

        // Güncelleme tarihi (Nullable: Boş olabilir)
        public DateTime? GüncellemeTarih { get; set; }

        // Çözülme durumu (Enum ile yönetilir)
        // Veritabanında int olarak karşılık bulur
        public CozulmeDurumu ÇözülmeDurumu { get; set; }
    }
}
