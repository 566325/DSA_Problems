using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    internal class PrimeNumbers
    {
        internal static void CheckRangePrime()
        {
            long range = 1000;
            Console.WriteLine("Prime Numbers");
            if (range <= 1)
                Console.WriteLine("Invalid Number");
            else
            {
                for (int i = 1; i <= range; i++)
                {
                    int counter = 0;
                    for (int j = i; j >= 1; j--)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
