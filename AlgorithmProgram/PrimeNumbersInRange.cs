using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class PrimeNumbersInRange
    {
        //checks the prime number in range
        public static void Prime()
        {
            int count = 1;
            int flag = 1;
            int start = 0;
            int end = 1000;
            //ignores 0 and 1
            if(start == 0)
            {
                start++;
                if (start == 1)
                {
                    start++;
                }
                
               
            }
            //Include 2 as prime number
            if(start == 2)
            {
                Console.Write(start+" ");
            }
            //skip if even number
            if(start%2 == 0)
            {
                start++;
            }
            //iterate to find prime by setting flags
            for(int i = start; i <= end; i++)
            {
                flag = 1;
                for(int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if(flag == 1)
                {
                    Console.Write(i+" ");
            
                }
            }
           
           
        }
        public static int checkPrime(int number)
        {
            int flag = 1;
            if (number == 1 || number == 0) { flag = 0; }
              
            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    flag = 0;
                    break;
                }
            }
            return flag;
        }
        //finds palindrome i.e;13=31
        public static bool Palindrome(int number1)
        {
            int temp = number1;
            int result = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                result = result * 10 + rem;
                temp /= 10;
            }
            if(result == number1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        
    }
}
