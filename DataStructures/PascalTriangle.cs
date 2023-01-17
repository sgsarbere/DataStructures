using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PascalTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> list = new List<int>();
                if (i == 0 | i == 1)
                {
                    list.Add(1);
                }
                else
                {

                }
                result.Add(list);

            }
            return result;
        }

        //7C3 would be  (7*6*5)/(3*2*1) 
        //private int nCr(int n, int r)
        //{
        //    int result = 1;
        //    int numerator = 1;
        //    for (int i = n; i > n - r; i--)
        //    {
        //        numerator *= 1;
        //    }
        //}

        private int BinomialCoeff(int n, int k)
        {
            int res = 1;

            if (k > n - k)
                k = n - k;

            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }
            return res;
        }
    }
}
