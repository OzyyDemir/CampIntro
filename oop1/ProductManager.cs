using System;
using System.Collections.Generic;
using System.Text;

namespace Oop1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Product added : "+product.ProductName);
        }

        public void Update(Product product)
        {
            Console.WriteLine("Product updated : " + product.ProductName);
        }

        public void Delete(Product product)
        {
            Console.WriteLine("Product deleted : " + product.ProductName);
        }

    }
}
