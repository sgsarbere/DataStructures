using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class NextPermutation
    {

        public void GetNextPermutation(int[] nums)
        {
            int[] arr = new int[nums.Length];
            //int i = 0;
            for(int i= 0;i < nums.Length; i++){
                for(int j = i; j < nums.Length; j++)
                {
                    if(nums[i]< nums[j])
                    {

                    }
                }
            }
        }
    }
}
