using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Array();

            /*Console.WriteLine("-------------------");

            string[,] regions = new string[5, 3] {

                {"İstanbul","Balıkkesir","Bursa"},
                { "Ankara","Konya","Kırıkkale"},
                { "İzmir","Manisa","Muğla"},
                { "Antalya","Adana","Mersin"},
                { "Bartın","Rize","Trabzon"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine(" ");
            }*/



        }

        private static void Array()
        {
            
            string[] students = new string[3];
            students[0] = "Damla";
            students[1] = "Hakan";
            students[2] = "Nazlı ";


            string[] students2 = new string[3] { "adem", "birgül", "ilker" };


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine("-------------------");
            foreach (var student2 in students2)
            {
                Console.WriteLine(student2);
            }
        }
    }
}
