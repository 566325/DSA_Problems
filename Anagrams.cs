using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    internal class Anagrams
    {
        public void CheckAnagrams()
        {
            Console.WriteLine("Enter first string");
            string str1=Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string str2 = Console.ReadLine();


            char[] strArr1 = str1.ToCharArray();
            char[] strArr2 = str2.ToCharArray();

            Sorting(strArr2);
            Sorting(strArr1);

            string s1 = new string(strArr1);
            string s2 = new string(strArr2);
            if (s1.Equals(s2))
            {
                Console.WriteLine("string {0} and {1} are anagram to each other ", str1, str2);
            }
            else
            {
                Console.WriteLine("string {0} and {1} are not anagram to each other ", str1, str2);
            }

        }
        public void Sorting(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = 0;j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        char temp= arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
