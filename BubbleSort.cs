using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    public class BubbleSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;
            for (int firstItr = 0; firstItr < length; firstItr++)
            {
                //flag to check if any swapping is done.
                int flag = 0;
                for (int secondItr = 0; secondItr < length - 1 - firstItr; secondItr++)
                {
                    if (array[secondItr] > array[secondItr + 1])
                    {
                        int temp = array[secondItr];
                        array[secondItr] = array[secondItr + 1];
                        array[secondItr + 1] = temp;
                        flag++;
                    }
                }
                //if no swap is done then array is sorted.
                if (flag == 0)
                {
                    break;
                }
            }
            return array;
        }
        
        public static void Display(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }


    }
}
