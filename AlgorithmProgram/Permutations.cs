using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class Permutations
    {
        public static void GetPermutations()
        {
            Console.WriteLine("Enter the string to print its permutations:");
            string input = Console.ReadLine();
            int length = input.Length;
            Console.WriteLine("Enter 1 for recursion");
            Console.WriteLine("Enter 2 for iteration");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Using Recursion:");
                    RecursionPermut(input, 0, length - 1);
                    break;
                case "2":
                    IterationPermut(input);
                    break;

            }
            

        }
        public static int factorial(int n)
        {
            int val = 1;
            for(int i = 2; i <= n; i++)
            {
                val *= i;
            }
            return val;
        }
        //Here permutation takes place using factorial and iterative method
        public static void IterationPermut(string input)
        {
            Console.WriteLine("Using Iteration");
            string[] arr = new string[input.Length];
            for(int i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToString(input[i]);
            }
            int noOfpermutations = factorial(input.Length);
            
            for (int i = 0; i < noOfpermutations; i++)
            {
                int temp = i;
                List<string> list = arr.ToList();
                for (int div = input.Length; div >=1; div--)
                {
                    int q = temp / div;
                    int r = temp % div;
                    Console.Write(list[r]);
                    list.RemoveAt(r);
                  
                }
                Console.Write(" ");

            }
       


        }
        //Recursive method is used to find permuted string
        public static void RecursionPermut(string input,int start,int end)
        {
            if(start == end)
            {
                Console.Write(input);
                Console.Write(" ");
            }
            for(int i = start; i <= end; i++)
            {
                input = Swap(input, start, i);
                RecursionPermut(input,start+1,end);
                input = Swap(input,start,i);
            }

        }
        public static string Swap(string input, int i, int j)
        {
            char temp;
            char[] charArray = input.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string result = new string(charArray);
            return result;
           

        }
    }
}
