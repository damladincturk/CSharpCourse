using System;

namespace IsPrime
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            bool result = isPrime(7);
            if (result==true)
            {
                Console.WriteLine("Number is prime.");
            }
            else
            {
                Console.WriteLine("Number is not prime.");
            }

            
        }
        private static bool isPrime(int number) {

            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                }
            }


            return result;


        }
    }
}
