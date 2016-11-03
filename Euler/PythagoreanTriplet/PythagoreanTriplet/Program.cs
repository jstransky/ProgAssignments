using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            double c = 0;
            int sum = 1000;

            //check values for a
            for (a=1; a<sum; a++ )
            {
                //check values for b
                for (b=1; b<sum; b++)
                {
                    //evaluate if desired pythagorian triple
                    c = Math.Sqrt(a * a + b * b);
                    if (a+b+c==1000)
                    {
                        Console.WriteLine(" " + a + " " + b + " " + c);
                        Console.WriteLine(a * b * c);
                    }
                }
            }

        }
    }
}
