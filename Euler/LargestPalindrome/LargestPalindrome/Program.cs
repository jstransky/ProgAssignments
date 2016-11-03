using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> palindromicProducts = new List<int>();

            //find all products of two 3 digit numbers
            for (int x=999; x>=100; x--)
            {
                for (int y=x; y>= 100; y--)
                {
                    int product = x * y;

                    //add palindroms to a list
                    if (Palindromic(product))
                        palindromicProducts.Add(product);
                }
            }

            //finds largest palindrome in list
            int maxValue = 0;
            foreach (int number in palindromicProducts)
            {
                if (number>=maxValue)
                {
                    maxValue = number;
                }
            }

            Console.WriteLine("The Largest Palindromic product of two 3 digit numbers is: " + maxValue);
            Console.ReadLine();
        }
        public static bool Palindromic(int z)
        {
            ///check if palindromic

            //Convert to string
            string palindromicCheck = z.ToString();

            //convert to charactor array
            char[] palindromicCheckArray = palindromicCheck.ToCharArray();
            Array.Reverse(palindromicCheckArray);
            string palindromicCheckReverse = new string(palindromicCheckArray);

            //Compare
            if (palindromicCheckReverse == palindromicCheck)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
