using System;
using System.Collections.Concurrent;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace QuickSort
{
    class Program
    {
        
        public static void QuickSortNow(int[] a, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(a, start, end);
                QuickSortNow(a, start, pivot - 1);
                QuickSortNow(a, pivot + 1, end);
            }
        }

        public static int Partition(int[] a, int start, int end)
        {
            int pivot = a[end];
            int index = start;

            for (int i = start; i < end; i++)
            {
                if (a[i] <= pivot)
                {
                    int temp = a[i];
                   a[i] = a[index];
                    a[index] = temp;
                    index++;
                }
            }

            int anotherTemp = a[index];
            a[index] = a[end];
            a[end] = anotherTemp;
            return index;
        }
    

        static void Main(string[] args)
        {
            int[] iInput = {4, 5, 6, 7, 2, 1, 45, 23};
            QuickSortNow(iInput, 0, iInput.Length - 1);

            for (int i = 0; i < iInput.Length; i++)
            {
                Console.Write(iInput[i] + " ");
            }
        }
    }
}