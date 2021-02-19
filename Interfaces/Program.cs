using System;

namespace Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

       }

        interface IPerson {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get ; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }

        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName{ get ; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
             
        }
    }
}
