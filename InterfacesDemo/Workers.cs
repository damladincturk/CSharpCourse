using System;
namespace InterfacesDemo
{
    public class Workers : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker eat");
        }

        public void Salary()
        {
            Console.WriteLine("Worker salary");
        }

        public void Work()
        {
            Console.WriteLine("Worker work");
        }
    }
}
