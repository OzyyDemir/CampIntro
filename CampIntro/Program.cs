using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dont repeat yourself
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 1111;
            double faizOrani = 1.22;
            Console.WriteLine(kategoriEtiketi);
            bool girdiMi = true;
            if (girdiMi)
            {
                Console.WriteLine("Girdiniz.");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız.");
            }

        }
    }
}
