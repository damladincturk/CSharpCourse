using System;
namespace Interfaces
{
    public class PersonManager
    {
        public void Add(IPerson person) {
            Console.WriteLine(person.FirstName);

        }
    }
}
