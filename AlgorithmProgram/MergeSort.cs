using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram
{
    class MergeSort<T> where T:IComparable
    {
        public static void MergeSorting()
        {
            Console.WriteLine("Enter the number of elements to be inserted");
            int number = Convert.ToInt32(Console.ReadLine());
            List<T> list = new List<T>();
            Console.WriteLine("The elements");
            for (int i = 0; i < number; i++)
            {
                list.Add((T)Convert.ChangeType(Console.ReadLine(), typeof(T)));
            }
            Console.WriteLine("After Merge sort");
            Sort(list, 0, list.Count - 1);
            Display(list);
            Console.WriteLine(" ");


        }
        public static void merge(List<T> arr, int l, int m, int r)
        {
            int left = m - l + 1;
            int right = r - m;
            T[] Left = new T[left];
            T[] Right = new T[right];
            int i, j;
            for (i = 0; i < left; ++i)
            {
                Left[i] = arr[l + i];
            }
            for (j = 0; j < right; ++j)
            {
                Right[j] = arr[m + 1 + j];
            }
           i = 0;
           j = 0;
           int k = l;
            while (i < left && j < right)
            {
                if (Left[i].CompareTo(Right[j])<0 || Left[i].CompareTo(Right[j]) == 0)
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }

            while (i < left)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }

            while (j < right)
            {
                arr[k] = Right[j];
                j++;
                k++;
            }
            
        }
        public static void Sort(List<T> list,int start,int end)
        {
            if (start < end)
            {
                int middle = start + (end - start) / 2;
                Sort(list, start, middle);
                Sort(list, middle + 1, end);
                merge(list, start, middle, end);

            }

        }
        public static void Display(List<T> list)
        {
            foreach (var mem in list)
            {
                Console.Write(mem + " ");
            }
        }

    }
}
