using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ömer Zabunoğlu
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.FirstName = "Ömer";
            musteri1.LastName = "Zabunoğlu";
            musteri1.MusteriNo = "6161616161";
            musteri1.TcNo = "12345678910";

            // Weonsoft
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.SirketAdi = "Weonsoft";
            musteri2.VergiNo = "61616161";
            musteri2.MusteriNo = "1357902468";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
        }
    }
}
