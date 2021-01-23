using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gürkan Altunok
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Gürkan";
            customer1.LastName = "Altunok";
            customer1.TcNo = "123456789123";

            //Kodlama.io
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567";
            customer1.CustomerNumber = "532785";

            //SOLID

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);



        }
    }
}
