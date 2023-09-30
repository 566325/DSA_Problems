using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    internal class MergeSort
    {
        internal static void Sorting()
        {
            int[] array = {5,4,8,12,54,23,56,87,9,1};
            Console.WriteLine("Unsorted Array");
            InsertionSort.Display(array);
            Console.WriteLine("Sorted array....");
            int low = 0, high = array.Length - 1;
            MergeSorting(array, low, high);
            InsertionSort.Display(array);
        }
        public static int[] MergeSorting(int[] array, int low, int high)
        {
            int mid;
            if (low < high)
            {
                mid = low + (high - low) / 2;
                MergeSorting(array, low, mid);
                MergeSorting(array, mid + 1, high);
                Merge(array, low, mid, high);
            }
            return array;
        }
        public static int[] Merge(int[] arr, int low, int mid, int high)
        {

            int n1 = mid - low + 1;
            int n2 = high - mid;

            int[] a = new int[n1];
            int[] b = new int[n2];
            int i, j;
            for (i = 0; i < n1; i++)
            {
                a[i] = arr[low + i];
            }

            for (j = 0; j < n2; j++)
            {
                b[j] = arr[mid + 1 + j];
            }

            i = 0;
            j = 0;
            int k = low;

            while (i < n1 && j < n2)
            {
                if (a[i].CompareTo(b[j]) < 0)
                {
                    arr[k] = a[i];
                    k++; i++;
                }
                else
                {
                    arr[k] = b[j];
                    k++; j++;
                }
            }

            while (i < n1)
            {
                arr[k] = a[i];
                k++; i++;
            }
            while (j < n2)
            {
                arr[k] = b[j];
                k++; j++;
            }
            return arr;
        }
    }
}
