using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            long sumSquares = 0;
            long squareSum = 0;

            //for numbers 1 through 100
            for (int i = 1; i<=100; i++)
            {
                squareSum += i;
                sumSquares += i * i;
            }

            //the sum of 1-100 squared
            squareSum = squareSum * squareSum;

            //difference between values
            long difference = squareSum - sumSquares;
            Console.WriteLine("The difference between the sum of the squares of 1-100 and the square of the sums of 1-100 is " + difference);
        }
    }
}
