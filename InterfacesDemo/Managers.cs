using System;
namespace InterfacesDemo
{
    public class Managers : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Managers eat");
        }

        public void Salary()
        {
            Console.WriteLine("Managers Salary");
        }

        public void Work()
        {
            Console.WriteLine("Managers work");
        }
    }
}
