using System;

namespace AlgorithmProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Algorithm Programs");
                Console.WriteLine("1) Permutaions of a string");
                Console.WriteLine("2) Binary Search");
                Console.WriteLine("3) Insertion Sort");
                Console.WriteLine("4) Bubble Sort");
                Console.WriteLine("5) Merge Sort");
                Console.WriteLine("6) Anagram");
                Console.WriteLine("7) Prime number between 0 and 1000");
                Console.WriteLine("8) Prime number anagram and palindrome");
                Console.WriteLine("9) Guess my number");
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
                        InsertionSort<int>.InsertionSortOperation();
                        Console.WriteLine(" ");
                        break;
                    case "4":
                        Console.WriteLine("***Bubble Sort***");
                        BubbleSort<int>.Bubble();
                        Console.WriteLine(" ");
                        break;
                    case "5":
                        Console.WriteLine("***Merge Sort***");
                        MergeSort<int>.MergeSorting();
                        Console.WriteLine(" ");
                        break;
                    case "6":
                        Console.WriteLine("***Anagram***");
                        Console.WriteLine("Enter the two strings to compare:");
                        string string1 = Console.ReadLine();
                        string string2 = Console.ReadLine();
                        bool result = Anagram.CompareTwoStrings(string1, string2);
                        if (result)
                        {
                            Console.WriteLine("Yes it is a anagram");
                        }
                        else
                        {
                            Console.WriteLine("Not an anagram");
                        }
                        break;
                    case "7":
                        Console.WriteLine("***Prime Between 0 and 1000***");
                        PrimeNumbersInRange.Prime();
                        Console.WriteLine(" ");
                        break;
                    case "8":
                        Console.WriteLine("***Anagram and Palindrome***");
                        Console.WriteLine("Enter the two numbers");
                        string number1 = Console.ReadLine();
                        string number2 = Console.ReadLine();
                        int num1result = PrimeNumbersInRange.checkPrime(Convert.ToInt32(number1));
                        int num2result = PrimeNumbersInRange.checkPrime(Convert.ToInt32(number2));
                        if (num1result == 1 && num2result == 1)
                        {
                            bool resultA = Anagram.CompareTwoStrings(number1, number2);
                            bool resultP = PrimeNumbersInRange.Palindrome(Convert.ToInt32(number1));
                            if (resultA)
                            {
                                Console.WriteLine("Yes it is a anagram");
                            }
                            else
                            {
                                Console.WriteLine("Not an anagram");
                            }
                            if (resultP)
                            {
                                Console.WriteLine("Yes it is a Palindrome");
                            }
                            else
                            {
                                Console.WriteLine("Not a Palindrome");
                            }
                        }
                        else
                        {

                            Console.WriteLine("Not a Prime Number");
                        }
                        break;
                    case "9":
                        QuestionGuessing.ThinkNumber();
                        break;
                    case "10":
                        return;



                }
            }

           
        }
    }
}
