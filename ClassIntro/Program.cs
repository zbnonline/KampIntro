using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Anıl Zabunoğlu";
            kurs2.KursAdi = "Java";
            kurs2.İzlenmeOrani = 61;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Fatih Zabunoğlu";
            kurs3.KursAdi = "Python";
            kurs3.İzlenmeOrani = 80;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
