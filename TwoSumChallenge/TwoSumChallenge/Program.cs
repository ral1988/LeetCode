using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSumChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[] {2, 7, 11, 15};
            int target = 9;

            TwoSum(test, target);


        }
        public static int[] TwoSum(int[] nums, int target) 
        {
            var dict = new Dictionary<int, int>(nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (dict.TryGetValue(num, out int index))
                {
                    return new int[] {index, i};
                }
                else
                {
                    if (!dict.ContainsKey(num))
                    {
                        dict.Add(num, i);
                    }

                }
            } 
            return null;
        }
    }
}


   
    
    



//need to loop through each entry of the array to know the numbers
//Test the sum of two of those numbers to match the specific int
//return new array that will have the numbers to meet the target

