using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Costumer added :" +customer.Name);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Costumer updated :" + customer.Name);

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Costumer deleted :" + customer.Name);

        }
    }
}
