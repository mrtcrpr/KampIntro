namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123";
            musteri1.Adi = "Murat";
            musteri1.Soyadi = "Çarpar";
            musteri1.TcNo = "10101011010";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "45678";
            musteri2.SirketAdi = "MRTCRPR LTD";
            musteri2.VergiNo = "456781234";

            MusteriManager musteriManager = new MusteriManager();   
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}