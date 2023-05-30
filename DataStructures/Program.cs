using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //RotateImage rt = new RotateImage();
            //int[][] matrix = new int[][] {1,2,3  };
            //{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //rt.Rotate(matrix);
            Console.WriteLine(Calc(2, 1, 2, new List<int> { 2, 2 }, 2, new List<int> { 2, 2 }));
            Console.Read();
        }

        static int Calc(int N, int L, int R,List<int> A, int Q, List<int> B)
        {
            int gcdOfA = GcdN(A.ToArray(),A.Count);
            int[] arr = B.ToArray();
            //int range= L R
            int count = 0;
            for(int i = 0; i < B.Count; i++)
            {
                if(gcdOfA == arr[i])// one more condition needed
                {
                    //is in good terms
                    count++;

                }
            }
            return count;
        }

        static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return gcd(b, a % b);
        }
        static int GcdN(int[] arr, int n)
        {
            if (n <= 1)
                return arr[0];
            int temp = arr[0];
            for (int i = 1; i < n; i++)
            {
                temp = gcd(temp, arr[i]);
            }
            return temp;
        }

        int IsArrayBeauty(int[] arr)
        {
            List<string> strList = new List<string>();
            Dictionary<int, int> dict= new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                //convert int to binary string
                string str = Convert.ToString(arr[i], 2);
                int countOfMostFrequentBit = GetCountOfMacFreuentBit(str);
                int val;
                if(!dict.TryGetValue(countOfMostFrequentBit,out val))
                {
                    dict.Add(countOfMostFrequentBit, 1);
                }
                else
                {
                    dict[countOfMostFrequentBit] = dict[countOfMostFrequentBit] + 1;
                }
                
            }

            return dict.Values.Max();
        }

        private int GetCountOfMacFreuentBit(string str)
        {
            int countOf1 = 0;
            int countOf0 = 0;
            foreach (Char c in str)
            {
                if (c == '1')
                {
                    countOf1++;
                }
                else
                {
                    countOf0++;
                }
            }
            return Math.Max(countOf0, countOf1);
        }
    }
}
