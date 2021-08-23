using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int output = reverse("ada is ap mama");

            Console.WriteLine(output);

            
        }

        public static int reverse(string ab)
        {
            //string ab = "aba
            int count = 0;
            foreach (var item in ab.Split(' '))
            {
                string newline = "";
                for (int i = 0; i < item.Length; i++)
                {

                    newline += item[item.Length - 1 - i];
                }
                //return newline;

                if(newline == item)
                {
                    count += 1;
                }
            }

            return count;
            

           
        }
    }
}
