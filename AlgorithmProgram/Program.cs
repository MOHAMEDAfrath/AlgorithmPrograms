using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("1) Permutaions of a string");
            switch (Console.ReadLine())
            {
                case "1":
                    Permutations.GetPermutations();
                    break;
            }
           
        }
    }
}
