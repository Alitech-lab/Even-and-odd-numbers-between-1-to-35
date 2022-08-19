using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_odd_numbers_between_1_to_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd number from 1 to 35");
            for (int i = 1; i <= 35; i++)
            {
                if (i % 2 != 0)

                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Even number from 1 to 35");
            for (int i = 1; i <= 35; i++)
            {
                if (i % 2 == 0)

                {
                    Console.WriteLine(i);

                }
            }

            Console.ReadKey();



        }
    }
}
