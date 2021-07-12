using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class BinarySearch
    {
        public static void Binarysearch()
        {
            string text = File.ReadAllText(@"C:\Users\afrat\source\repos\AlgorithmProgram\AlgorithmProgram\BinarySearch.txt");
            List<string> list = new List<string>(text.Split(" "));
            list.Sort();
            Console.WriteLine("Enter the word to be found");
            string key = Console.ReadLine();
           
            bool result = Search(list, 0, list.Count - 1, key);
            if (result == true)
                Console.WriteLine("Found {0}", key);
            else
                Console.WriteLine("Not Found {0}", key);

        }
        public static bool Search(List<string> list,int start,int end,string key)
        {
            bool found = false;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int res = key.CompareTo(list[mid]);
                if (res == 0)
                    found = true;
                if (res > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }    
            }
            return found;
        }
    }
}
