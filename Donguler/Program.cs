using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici yetiştirme kursu";
            string kurs2 = "Programlamaya giriş kursu";
            string kurs3 = "Java";

            string[] kurslar = new string[] { kurs1, kurs2, kurs3 };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


        }
    }
}
