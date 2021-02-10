using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.CustomerNo = 123123;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Merve";
            customer2.CustomerNo = 123134;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Murat";
            customer3.CustomerNo = 131131;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Update(customer1);
            customerManager.Delete(customer1);

        }
    }
}
