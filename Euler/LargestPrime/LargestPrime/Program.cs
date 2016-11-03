using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //600851475143
            Int64 number = 600851475143;
            List<Int64> listOfFactors = new List<Int64>();

            for (Int64 i = 3; i <= number; i+=2)
            {
                if ((number % i) ==0)
                {
                    listOfFactors.Add(i);
                    number = number / i;
                }
            }

            foreach(Int64 factor in listOfFactors)
            {
                Console.WriteLine(factor);
            }
            Console.ReadLine();
            //6857
        }
    }
}
