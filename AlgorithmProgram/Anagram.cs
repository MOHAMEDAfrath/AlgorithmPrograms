using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class Anagram
    {
        public static bool CompareTwoStrings(string string1,string string2)
        {
            bool found = true;
            
            if (string1.Length != string2.Length)
            {
                found = false;
            }
            else
            {
                char[] temp1 = string1.ToCharArray();
                char[] temp2 = string2.ToCharArray();
                Array.Sort<char>(temp1);
                Array.Sort<char>(temp2);
                for(int i = 0; i < temp1.Length; i++)
                {
                    if(temp1[i] != temp2[i])
                    {
                        found = false;
                    }
                }

            }
            return found;
        }
    }
}
