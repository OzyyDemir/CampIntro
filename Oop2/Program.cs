using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "111";
            customer1.Name = "Ali";
            customer1.Surname = "Mert";
            customer1.TcNo = "33333333";


            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "213124";
            customer2.CompanyName = "AliExpres";
            customer2.VergiNo = "234355";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer3);


        }
    }
}
