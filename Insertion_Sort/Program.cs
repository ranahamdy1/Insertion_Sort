using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 9, 2, 0, 4, 8 };
            InsertionSort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
            }
            Console.ReadLine();
        }
        private static void InsertionSort(int[] a)
        {
            int cnt = a.Length;
            int key;
            for (int i = 0; i < cnt; i++)
            {
                key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j = j - 1;
                }
                a[j + 1] = key;
            }
        }
    }
}
