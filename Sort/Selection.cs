using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    class Selection : ISort
    {
        /// <summary>
        /// 选择排序
        /// 
        /// 对于长度为N的数组，选择排序需要大约 N^2/2 次比较和 N次交换
        /// 证明：0 到 N-1 的任意 i 都会进行1次交换和 N-1-i 次比较
        ///       因此有 N 次交换 以及 (N-1)+(N-2) + ... + 2 + 1 ～ N^2/2 次比较
        /// </summary>
        /// <param name="a"></param>
        public void Sort(IComparable[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min_Idx = i;
                // 从当前索引右边找到最小值，和当前索引交换
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (Utils.Less(a[j], a[min_Idx]))
                        min_Idx = j;
                }
                Utils.Exchange(a, i, min_Idx);
            }
        }
    }
}
