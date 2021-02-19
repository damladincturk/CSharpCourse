 using System;
using System.Linq;

namespace Methods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = Add2(3,5);
            Console.WriteLine(result);
            
        }

        static int Add2(int number1,params int[] number2) {
            int result = number2.Sum();
            return result;
         }
    }
}
