using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-10 multiplied together
            long min = 2520;

            //goes through every number and checks for divisibility
            for (long i =min; i<= 1000000000; i+=20)
            {
                bool success = true;

                //if something is divisible by 11-20 it is divisible by 1-10
                for (int j =11; j<20; j++)
                    if (i%j!=0)
                    {
                        success = false;
                        break;
                    }
                if (success)
                {
                    Console.WriteLine(i + " is divisible by all numbers between 1-20");
                }
                
             }
            Console.ReadLine();
        }
    }
}
