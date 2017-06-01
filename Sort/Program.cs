using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorting
{
    class Program
    {
        public static void Main()
        {
            IComparable[] a = GetRandomArray(30);
            new Shell().Sort(a);
            Utils.Dump(a);
        }

        public static IComparable[] GetRandomArray(int maxCount)
        {
            IComparable[] ret = new IComparable[maxCount];
            for (int i = 0; i < maxCount; i++)
                ret[i] = i;
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < maxCount; i++)
                Utils.Exchange(ret, i, rand.Next(0, maxCount));
            return ret;
        }
    }
}
