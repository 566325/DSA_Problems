using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DSAPrablems
{
    internal class StringPermutations
    {
        //usong hashset collection for strong 
        HashSet<string> set = new HashSet<string>();
        public void Permutations()
        {
            Console.WriteLine("Enter a string");
            string str =Console.ReadLine();

            string result = "";
            permute(str, result);

            Console.WriteLine("\n Permutations of a string{0} are : \n ",str);

            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
            
        }
        public void permute(string str, string result)
        {
            if(str.Length == 0)
            {
                set.Add(result);
                return;
            }
            for(int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                string Left_subString = str.Substring(0,i);
                string right_subString = str.Substring(i+1);
                string rest = Left_subString + right_subString;
                permute(rest, result + ch);
            }

        }
    }
}
