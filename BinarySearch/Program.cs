using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // 默认a已经是从小到大排好序的
            int[] a = { 0, 1, 2, 3, 4, 5, 8, 9, 11, 20, 45, 78 };
            int key = 9;
            int idx = BinarySearch(key, a);

            Console.WriteLine(idx);
            Console.ReadKey();
        }

        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="key"></param>
        /// <param name="a">a必须是一个排好序的数组</param>
        /// <returns></returns>
        private static int BinarySearch(int key, int[] a)
        {
            int start_Idx = 0;
            int end_Idx = a.Length - 1;
            while (start_Idx <= end_Idx)
            {
                int mid_Idx = start_Idx + (end_Idx - start_Idx) / 2;
                if (key < a[mid_Idx])
                    end_Idx = mid_Idx - 1;
                else if (key > a[mid_Idx])
                    start_Idx = mid_Idx + 1;
                else
                    return mid_Idx;
            }
            return -1;
        }
    }
}
