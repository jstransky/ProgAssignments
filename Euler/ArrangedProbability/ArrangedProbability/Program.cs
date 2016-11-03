using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrangedProbability
{
    class Program
    {
        static void Main(string[] args)
        {

            for (float y = 1000000000000; y < 2000000000000; y++)
            {
                // 15/21 x 14/20 = 1/2
                //85/120 x 84/119 =1/2
                //y*(x-1)+(y-1)x =1/2
                //-y+2yx-x=1/2 
                for (float x = 1; x < y; x++)
                {
                    if (2*y*x-y-x==.5f)
                    {
                        Console.WriteLine(x);
                    }
                }
             }
           
        }
    }
}
