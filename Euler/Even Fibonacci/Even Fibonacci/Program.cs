using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Fibonacci
{
    class Program
    {
        static void Main()
        {
            double even = 0;
            double a = 0;
            double b = 1;
            //interates through 4mil numbers
            for (double i = 0; i <4000000; i++)
            {
                double fibonaaci = a;

                //checking if each fibonaaci is even
                if (fibonaaci % 2 == 0)
                {
                    even = even + fibonaaci;
                }

                a = b;
                b = fibonaaci + b;
                //stop if over 4 mil
                if (fibonaaci > 3999999)
                {
                    break;
                }

            }

            Console.WriteLine("Result of even Fibonaacis " + even);
            Console.ReadLine();
    
        }
    }
}
