using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class RotateImage
    {
        //        Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
        //Output: [[7,4,1],[8,5,2],[9,6,3]]
        public void Rotate(int[][] matrix)
        {
            //int n = matrix.Length-1;
            //int i = 0;
            //while (n >= 0 && i<matrix.Length)
            //{
            //    Console.Write(matrix[i][n]);
            //    n--;
            //    i++;
            //}

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length / 2; j++)
                {
                    int temp = 0;
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[i][matrix.Length - 1 - j];
                    matrix[i][matrix.Length - 1 - j] = temp;
                }
            }
        }

        public int[][] Merge(int[][] intervals)
        {
            //Input: intervals = [[1, 3],[2,6],[8,10],[15,18]]
            //Output: [[1,6],[8,10],[15,18]]
            //Explanation: Since intervals[1, 3] and[2, 6] overlap, merge them into[1, 6].
            int[][] result = new int[][] { };
            
            for (int i = 0; i < intervals.Length; i++)
            {

               if(intervals[i][1]>= intervals[i+1][0])
                {
                    result[i][0] = intervals[i][0];
                    result[i][1] = intervals[i + 1][1];
                }

                //result[0][1] = 1;
            }
            return result;
        }
    }
}
