using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class Selection : ISort
    {
        /// <summary>
        /// 选择排序
        /// </summary>
        /// <param name="a"></param>
        public void Sort(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min_Idx = i;
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
