﻿using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs");
            Console.WriteLine("1) Permutaions of a string");
            Console.WriteLine("2) Binary Search");
            Console.WriteLine("3) Insertion Sort");
            Console.WriteLine("4) Bubble Sort");
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
                case "3":
                    Console.WriteLine("***Insertion Sort***");
                    InsertionSort.InsertionSortOperation();
                    break;
                case "4":
                    Console.WriteLine("***Bubble Sort***");
                    BubbleSort.Bubble();
                    break;
                



            }

           
        }
    }
}
