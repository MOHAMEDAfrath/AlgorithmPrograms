using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    //finds the number quessed by user by using binary search
    class QuestionGuessing
    {
        static int start = 1, end = 100, found = 0, foundNumber = 0;
        public static void CheckGuessNumber(int middle)
        {
            Console.WriteLine("Enter 1 if this is your number {0}", middle);
            Console.WriteLine("Enter 2 if your number is less than {0}", middle);
            Console.WriteLine("Enter 3 if your number is more than {0}", middle);
            switch (Console.ReadLine())
            {
                case "1":
                    foundNumber = middle;
                    found = 1;
                    break;
                case "2":
                    end = middle - 1;
                    break;
                case "3":
                    start = middle + 1;
                    break;
            }
        
           
        }
        public static void ThinkNumber()
        {
            Console.WriteLine("Think of a number between 1 and 100");
            while (start <= end && found != 1)
            {
                int middle = start + (end - start) / 2;
                CheckGuessNumber(middle);
            }
            if(found == 1)
            {
                Console.WriteLine("Your number is {0}",foundNumber);
            }
            
            
        }
    }
}
