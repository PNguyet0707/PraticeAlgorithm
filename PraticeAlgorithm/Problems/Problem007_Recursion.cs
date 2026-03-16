using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticeAlgorithm.Problems
{
    public static class Problem007_Recursion
    {
        public static int SumUseRecursion(int n)
        {
            int last = ((n - 1) / 3) * 3 + 1;
            return SumBack(last);
        }

        private static int SumBack(int x)
        {
            if (x < 1)
                return 0;

            return x + SumBack(x - 3);
        }
        public static int SumUseLoop(int n)
        {
            int total = 0;
            for(int i = 1; i <= n; i+=3)
            {
                total += i;
            }
            return total;
        }
        //public static int SumUseRecursion(int n)
        //{
        //    return SumHelper(1, n);
        //}

        //private static int SumHelper(int current, int n)
        //{
        //    if (current > n)
        //        return 0;

        //    return current + SumHelper(current + 3, n);
        //}

    }
}
