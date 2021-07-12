using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class BubbleSort
    {
        public static void Bubble()
        {
            Console.WriteLine("Enter the number of elements to be inserted");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            Console.WriteLine("The elements");
            for(int i = 0; i < number; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Sort(list);
        }
        public static void Sort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i; j < list.Count; j++)
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
            }
            Console.WriteLine("After Bubble Sort:");
            Display(list);
        }
        public static void Display(List<int> list) { 
            foreach(var mem in list)
            {
                Console.Write(mem+" ");
            }
        }
    }
}
