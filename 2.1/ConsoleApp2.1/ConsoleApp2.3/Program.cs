using System;

class Program
{
    public static bool RepeatNums(int[] nums) 
    {
        Array.Sort(nums);
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                return true;
            }
        }
        
        return false;
    }

    static void Main()
    {
        int[] nums1 = {1, 2, 3, 4};
        Console.WriteLine(RepeatNums(nums1));

        int[] nums2 = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
        Console.WriteLine(RepeatNums(nums2));

        int[] nums3 = {1, 2, 3, 1};
        Console.WriteLine(RepeatNums(nums3));
    }
}