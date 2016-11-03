using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up for list of primes in order to find which number prime it is
            List<long> primes = new List<long>();
            primes.Add(2);
            primes.Add(3);

            for (long i =5; i<1000000; i+=2)
            {
                bool isPrime = true;

                //checks for primailty, composite numbers have a factor <= sqrt of themselves 
                for (long j =2; j<=Math.Sqrt(i); j++)
                {
                    if (i%j ==0)
                    {
                        isPrime = false;
                        break;
                    }
                    
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
                if (primes.Count >= 10001)
                {
                    break;
                }
            }

            //displays 10001 prime
            Console.WriteLine(primes[10000]);
           
        }
    }
}
