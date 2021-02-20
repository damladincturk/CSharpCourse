using System;

namespace Inheritances
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[3] { new Customer() { FirstName ="Damla"}, new Student() { FirstName="Hakan"}, new Person() { FirstName="Adem"} };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            
        }

        class Person {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

        }

        class Customer : Person {

            public string City { get; set; }


        }
        class Student : Person
        {

            public string Depertman { get; set; }


        }

    }
}
