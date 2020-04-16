//Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal to the product of all the elements of nums except nums[i].
//
//Example:
//
//Input:  [1,2,3,4]
//Output: [24,12,8,6]
//Constraint: It's guaranteed that the product of the elements of any prefix or suffix of the array (including the whole array) fits in a 32 bit integer.
//
//Note: Please solve it without division and in O(n).
//
//Follow up:
//Could you solve it with constant space complexity? (The output array does not count as extra space for the purpose of space complexity analysis.)



using System;

namespace Product_of_Array_Except_Self
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {1, 2, 3, 4};

            ProductExceptSelf(nums);
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            //output array
            var outputArr = new int[nums.Length];

            var lengthOfNumsArr = nums.Length;

            //Two arrays to gather numbers from either side of the location
            var numsRightOfNum = new int[lengthOfNumsArr];
            var numsLeftofNum = new int[lengthOfNumsArr];

            //From the left
            
            numsLeftofNum[0] = 1;

            for (int i = 1; i < lengthOfNumsArr; i++)
            {
                numsLeftofNum[i] = numsLeftofNum[i - 1] * nums[i - 1];
            }

            //From the right

            numsRightOfNum[lengthOfNumsArr - 1] = 1;
            for (int i = lengthOfNumsArr - 2; i >= 0; i--)
            {
                numsRightOfNum[i] = numsRightOfNum[i + 1] * nums[i + 1];
            }

            //Making the product and populating it into the outputArr
            for (int i = 0; i < lengthOfNumsArr; i++)
            {
                outputArr[i] = numsLeftofNum[i] * numsRightOfNum[i];
            }

            return outputArr;
        }
    }
}

