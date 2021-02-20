using System;
using Interfaces;

namespace Interfacess
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //NewMethod();

            // Intro();

            ICustomerDal[] customerDals = new ICustomerDal[] {

                new SqlServerCustomerDal(),
                new OracleServerCustomerDal()
            };

            foreach (var customer in customerDals)
            {
                customer.Add();
            }

        }

        private static void Intro()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void NewMethod()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, FirstName = "Damla", LastName = "Dnt", Adress = "Istanbul" };
            Student student = new Student { Id = 2, FirstName = "Hakan", LastName = "Dnt", Department = "Conputer" };
            personManager.Add(student);
        }
    }


}
