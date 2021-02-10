using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Elma";
            product1.Fiyat = 12;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Karpuz";
            product2.Fiyat = 73;
            product2.Aciklama = "Diyatbakır Karpuzu";

            Product[] products = new Product[] {product1,product2 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("************* Method ****************");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Add(product1);
            sepetmanager.Add(product2);

        }
    }
}
