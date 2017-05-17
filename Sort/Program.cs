using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    class Program
    {
        public static void Main()
        {
            int[] a = { 10, 7, 1, 3, 2, 4, 8, 5, 6, 9, };
            new Selection().Sort(a);
            Utils.Dump(a);
        }
    }
}
