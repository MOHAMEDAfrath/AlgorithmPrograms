using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("1) Permutaions of a string");
            Console.WriteLine("2) Binary Search");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("***Permutations of string***");
                    Permutations.GetPermutations();
                    break;
                case "2":
                    Console.WriteLine("***Binary Search***");
                    BinarySearch.Binarysearch();
                    break;
            
            }

           
        }
    }
}
