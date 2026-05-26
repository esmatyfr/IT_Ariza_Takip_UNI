namespace IT_Arıza_Takip.Entities
{
    public class ArizaTuru
    {
        public int ID { get; set; }     // ArizaKaydi tablosundaki ArizaTürü ile ilişkilendirilir
        public string TurAd { get; set; } // Örn: Yazılım, Donanım, Network
    }
}
