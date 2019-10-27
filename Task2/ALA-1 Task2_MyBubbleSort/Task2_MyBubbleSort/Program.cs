// Copyright (c) EPAM
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Task2_MyBubbleSort
{
    using System;

    /// <summary>
    /// Our class
    /// </summary>
    public class Program
    {
        public delegate void Bubble_Sort(ref int[] a);
        public delegate void ArrayMan(int[][] array);
        /// <summary>
        /// Our method outputs the same array but sorted
        /// </summary>
        public static void Bubble_Sort_Ascending(ref int[] a)
        {
            int a_size = a.Length;
            Console.Write("Bubble Sort Ascending:\t");
            if (a_size == 0)
            {
                OutputArray(a);
            }

            int i = 0;
            int swap = 0;
            int buf;
            while (i < a_size)
            {
                if (i + 1 != a_size && a[i] > a[i + 1])
                {
                    swap = 1;
                    buf = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = buf;
                }

                i++;
                if (i == a_size && swap == 1)
                {
                    swap = 0;
                    i = 0;
                }
            }

            OutputArray(a);
        }

        /// <summary>
        /// Our method outputs the same array but sorted
        /// </summary>
        public static void Bubble_Sort_Descending(ref int[] a)
        {
            int a_size = a.Length;
            Console.Write("Bubble Sort Descending:\t");
            if (a_size == 0)
            {
                OutputArray(a);
            }

            int i = 0;
            int swap = 0;
            int buf;
            while (i < a_size)
            {
                if (i + 1 != a_size && a[i] < a[i + 1])
                {
                    swap = 1;
                    buf = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = buf;
                }

                i++;
                if (i == a_size && swap == 1)
                {
                    swap = 0;
                    i = 0;
                }
            }

            OutputArray(a);
        }

        /// <summary>
        /// Our method that sums elements in array
        /// </summary>
        public static void OutputArray(int[] a)
        {
            foreach (var element in a)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Our method that sums elements in array
        /// </summary>
        public static int SumArray(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            return sum;
        }

        /// <summary>
        /// Our method that sorts among sums of array elements
        /// </summary>
        public static void SortArraySums(int[][] array)
        {
            int[] new_a = new int[array.Length];
            for (int k = 0; k < array.Length; k++)
            {
                new_a[k] = SumArray(array[k]);
            }
                
            Console.Write("\nArray of Sums:\t\t");
            OutputArray(new_a);
            Bubble_Sort BSort;
            BSort = Bubble_Sort_Ascending;
            BSort += Bubble_Sort_Descending;
            BSort(ref new_a);
        }

        /// <summary>
        /// Our method that find max elements in array
        /// </summary>
        public static int FindMaxmInArray(int[] a)
        {
            int max_v = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max_v)
                {
                    max_v = a[i];
                }
            }

            return max_v;
        }

        /// <summary>
        /// Our method that sorts among max of array elements
        /// </summary>
        public static void SortArrayMaxs(int[][] array)
        {
            int[] new_a = new int[array.Length];
            for (int k = 0; k < array.Length; k++)
            {
                new_a[k] = FindMaxmInArray(array[k]);
            }

            Console.Write("\nArray of Maximums:\t");
            OutputArray(new_a);

            Bubble_Sort BSort;
            BSort = Bubble_Sort_Ascending;
            BSort += Bubble_Sort_Descending;
            BSort(ref new_a);
        }

        /// <summary>
        /// Our method that find min elements in array
        /// </summary>
        public static int FindMinInArray(int[] a)
        {
            int min_v = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min_v)
                {
                    min_v = a[i];
                }
            }

            return min_v;
        }

        /// <summary>
        /// Our method that sorts among max of array elements
        /// </summary>
        public static void SortArrayMins(int[][] array)
        {
            int[] new_a = new int[array.Length];
            for (int k = 0; k < array.Length; k++)
            {
                new_a[k] = FindMinInArray(array[k]);
            }

            Console.Write("\nArray of Minimums:\t");
            OutputArray(new_a);
            Bubble_Sort BSort;
            BSort = Bubble_Sort_Ascending;
            BSort += Bubble_Sort_Descending;
            BSort(ref new_a);
        }

        /// <summary>
        /// Our Main where we give some values and call Bubble_Sort method
        /// </summary>
        private static void Main(string[] args)
        {
            int[][] jagged_arr = new int[4][];
            jagged_arr[0] = new int[] { 1, 2, 3, 5 };
            jagged_arr[1] = new int[] { 0 };
            jagged_arr[2] = new int[] { 101, -1, 0, 53, 3, -23, 111, 5934, 33 };
            jagged_arr[3] = new int[] { -1 };

            ArrayMan ArrayManipulation;
            ArrayManipulation = SortArraySums;
            ArrayManipulation += SortArrayMaxs;
            ArrayManipulation += SortArrayMins;

            ArrayManipulation(jagged_arr);
        }
    }
}
