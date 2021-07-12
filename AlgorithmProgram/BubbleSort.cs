using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class BubbleSort<T> where T:IComparable
    {
        public static void Bubble()
        {
            Console.WriteLine("Enter the number of elements to be inserted");
            int number =Convert.ToInt32(Console.ReadLine());
            List<T> list = new List<T>();
            Console.WriteLine("The elements");
            for(int i = 0; i<number; i++)
            {
                list.Add((T)Convert.ChangeType(Console.ReadLine(),typeof(T)));
            }
            Sort(list);
        }
        public static void Sort(List<T> list)
        { 
            for (int i = 0; i < list.Count; i++)
            {
                
                for (int j = i; j < list.Count; j++)
                    
                    if (list[i].CompareTo(list[j])>0)
                    {
                        T temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
            }
            Console.WriteLine("After Bubble Sort:");
            Display(list);
        }
        public static void Display(List<T> list) { 
            foreach(var mem in list)
            {
                Console.Write(mem+" ");
            }
        }
    }
}
