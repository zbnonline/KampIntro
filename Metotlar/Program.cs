using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();

            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Adı: " + urun.Adi + "\nFiyatı: " + urun.Fiyat + "\nAçıklaması: " + urun.Aciklama);
            }

            Console.WriteLine("--------Metotlar--------");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
        }
    }
}
