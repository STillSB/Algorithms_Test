using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Shell : ISort
    {
        /// <summary>
        /// 希尔排序
        /// 
        /// 是一种基于插入排序的算法，但是使用了不同增量，权衡了子数组的规模和有序性
        /// 希尔排序的思想是使数组中任意间隔为h的元素都是有序的。
        /// 这样的数组被成为h有序数组，换句话说，一个h有序数组就是
        /// h 个互相独立的有序数组编织在一起组成的数组。
        /// </summary>
        /// <param name="a"></param>
        public void Sort(IComparable[] a)
        {
            int N = a.Length;
            // 增量：从大到小，单调单调递减，最后一次是1即可
            int h = 1;
            // 1， 4， 13， 40， 121， 364， 1093 。。。
            while (h < N / 3)
                h = 3 * h + 1;
            while (h >= 1)
            {
                // 用插入排序的方法，变为一个 h 有序序列
                // 当 h 为 1 时，排序完成
                for (int i = 1; i < N; i++)
                {
                    for (int j = i; j >= h && Utils.Less(a[j], a[j - h]); j -= h)
                        Utils.Exchange(a, j, j - h);
                }
                h = h / 3;
            }
        }
    }
}
