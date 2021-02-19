using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //strings();
            string phrase = "My name is Damla";
            var result = phrase.EndsWith("d"); //la phrase fini-t-il avec d?
            Console.WriteLine(result);
            var result2 = phrase.StartsWith("My");
            Console.WriteLine(result2);
            var result3 = phrase.IndexOf("My");
            Console.WriteLine(result3);
            var result4 = phrase.Replace(" ","-");
            Console.WriteLine(result4);
            var result5 = phrase.Remove(2,3);
            Console.WriteLine(result5);

        }

        private static void strings()
        {
            string city = "Istanbul";
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Bartın";

            Console.Write(String.Format("{0} {1}", city, city2));

            string trying = String.Format("{0} {1}", city, city2);

            Console.WriteLine(trying);
        }
    }
}

