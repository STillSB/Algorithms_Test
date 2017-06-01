using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Insertion : ISort
    {
        /// <summary>
        /// 插入排序
        /// 
        /// 对于随机排列的长度为 N 的不重复数组
        /// 平均情况下插入排序需要 ～N^2/4 次比较和 ～N^2/4次交换
        /// 最坏情况下需要～N^2/2 次比较和 ～N^2/2次交换
        /// 最好情况需要 N-1 次比较和 0 次交换
        /// 
        /// 证明：比较的总次数是交换的次数加上一个额外的项，该项为（ N - 被插入元素正好是已知的最小元素的次数）
        ///       最坏情况下（逆序数组）这一项相对于总数可以忽略不计
        ///       在最好情况下（数组已经有序），这一项等于 N-1
        /// </summary>
        /// <param name="a"></param>
        public void Sort(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                // 始终保持索引左边的所有元素是有序的
                for (int j = i; j > 0 && Utils.Less(a[j], a[j-1]); j--)
                {
                    Utils.Exchange(a, j, j - 1);
                }
            }
        }
    }
}
