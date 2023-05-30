using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class ValidateSequences
    {    
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            // Write your code here.
            // bool result = false;
            //array = [5,1,22,25,6,-1,8,10]
            //sequence= [1,6,-1,10]
            //output : true
            int seqStartIndex = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (seqStartIndex >= sequence.Count)
                    break;
                if (array[i] == sequence.ToArray()[seqStartIndex] && seqStartIndex <= sequence.Count - 1)
                {
                    seqStartIndex++;
                }

            }
            return seqStartIndex == sequence.Count;
        }
    }

}
