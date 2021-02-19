using System;

namespace Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           // addUpdate();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Damla",
                LastName = "Dnt",
                city = "Istanbul"
            };

            Console.WriteLine(customer.Id);

            Console.WriteLine(customer.FirstName);

            Console.WriteLine(customer.LastName);

            Console.WriteLine(customer.city);
        }

        private static void addUpdate()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }
}
