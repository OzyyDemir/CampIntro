using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "Ahmet";
            int yasi = 11;

            Kurs kurs1 = new Kurs();

            kurs1.Egitmen = "Mehmet Mehmet";
            kurs1.KursAdi = "Java";
            kurs1.IzlemneOrani = 66;

            Kurs kurs2 = new Kurs();

            kurs2.Egitmen = "Ali Veli";
            kurs2.KursAdi = "C#";
            kurs2.IzlemneOrani = 87;

            Kurs kurs3 = new Kurs();

            kurs3.Egitmen = "Mehmet Mehmet";
            kurs3.KursAdi = "Algoritma";
            kurs3.IzlemneOrani = 77;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
   }


    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlemneOrani { get; set; }

    }
}
