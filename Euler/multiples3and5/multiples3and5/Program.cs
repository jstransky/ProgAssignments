using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiples3and5
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            //Incriments by 1 from 0 to 1000
            for (int i = 0; i <1000; i++)
            {
                //if the remainder of dividing the number by 3 or 5 is 0
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
       
            }
            Console.WriteLine("The sum of all multiples of 3 or 5 between 0 and 1000 is " + sum);
            Console.ReadLine();

        }
    }

}
