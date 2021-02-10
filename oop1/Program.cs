using System;

namespace Oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Table";
            product1.UnitPrice = 44;
            product1.UnitsInStock = 33;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInStock = 55,
                UnitPrice = 12,
                ProductName = "Pencil"
            };

            ProductManager productManager = new ProductManager();

            productManager.Add(product2);

        }
    }
}
