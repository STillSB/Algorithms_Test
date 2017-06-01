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
            IComparable[] a = { 10, 7, 1, 3, 2, 4, 8, 5, 6, 9, };
            new Insertion().Sort(a);
            float c = 312431214.99f;
            Utils.Print(c.ToString());
            Utils.Print(String.Format("{0:N0}", c));
            //Utils.Dump(a);
        }
    }
}
