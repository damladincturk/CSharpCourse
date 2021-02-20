using System;

namespace InterfacesDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3] {
                new Workers(),
                new Managers(),
                new Robots()
            };

            IEat[] eats = new IEat[2] {
                new Managers(),
                new Workers()
            };

            ISalary[] salaries = new ISalary[2] {
                new Managers(),
                new Workers()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            foreach (var salarie in salaries)
            {
                salarie.Salary();
            }

        }
    }
}
