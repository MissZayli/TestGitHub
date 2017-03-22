using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4___Loopar_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            // while (i <=20)
            while (i < 21)
            {
                Console.WriteLine($"Talet är {i++}");

                // Console.WriteLine(i);
                // i = i + 1;
                // break; för att avbryta loop
            }

            Console.Write("Skriv in ett tal mellan 1 och 100: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if(num >= 1 && num <= 100)
            {
                do
                {
                    Console.WriteLine($"Ditt tal är {num++}");
                } while (num <= 100);
            }



        }
    }
}
