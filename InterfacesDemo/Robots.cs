using System;
namespace InterfacesDemo
{
    public class Robots : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot wprk");
        }
    }
}
