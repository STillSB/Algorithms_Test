using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public static class Utils
    {
        public static bool Less(IComparable a, IComparable b)
        {
            return a.CompareTo(b) < 0;
        }

        public static void Print(Object obj)
        {
            Console.WriteLine(obj.ToString());
            Console.ReadKey();
        }

        public static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (Less(a[i + 1], a[i]))
                    return false;
            }
            return true;
        }

        public static void Dump(int[] a)
        {
            for (int i = 0; i < a.Length; i++ )
            {
                Console.WriteLine(string.Format("[{0}]  {1}", i, a[i]));
            }
            Console.ReadKey();
        }

        public static void Exchange(int[]a, int i, int j)
        {
            var tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
        }
    }
}
