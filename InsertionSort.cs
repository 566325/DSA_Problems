using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    internal class InsertionSort
    {
        public static int[] InsertSort(int[] array)
        {
            for (int secondElement = 1; secondElement < array.Length; secondElement++)
            {
                int temp = array[secondElement];
                int prevElement = secondElement - 1;
                while (prevElement >= 0 && array[prevElement].CompareTo(temp) > 0)
                {
                    array[prevElement + 1] = array[prevElement];
                    prevElement--;
                }
                array[prevElement + 1] = temp;
            }
            return array;
        }
        public static void Display(int[] Array)
        {
            foreach (int item in Array)
            {
                Console.WriteLine(item);
            }
        }
    }

}
