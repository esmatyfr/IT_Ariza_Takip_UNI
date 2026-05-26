namespace IT_Arıza_Takip.Entities
{
    public enum CozulmeDurumu
    {
        Bekliyor = 1,      // Yeni kayıt
        Incelemede = 2,    // Teknik ekip bakıyor
        Cozuldu = 3,       // İşlem tamam
        Iptal = 4          // Hatalı kayıt
    }
}
