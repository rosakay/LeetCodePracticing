//238. Product of Array ExceptSelf

using System;

internal partial class Program
{
    // 沒有符合時間複雜度 O(n)
    //public int[] ProductOfArrayExceptSelf(int[] nums)
    //{
    //    int n = 1;
    //    int[] ans = new int[nums.Length];
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        for (int j = 0; j < nums.Length; j++)
    //        {
    //            if (j != i)
    //                n *= nums[j];
    //        }
    //        ans[i] = n;
    //        n = 1;
    //    }
    //    return ans;
    //}
    public int[] ProductOfArrayExceptSelf(int[] nums)
    {
        int len = nums.Length;
        int[] left = new int[len];
        Array.Fill(left, 1);
        int[] right = new int[len];
        Array.Fill(right, 1);
        for (int i = 1; i < len; i++)
        {
            left[i] = left[i - 1] * nums[i - 1];
        }
        for (int i = len - 2; i >= 0; i--)
        {
            right[i] = right[i + 1] * nums[i + 1];
        }
        int[] ans = new int[len];
        for (int i = 0; i < len; i++)
        {
            ans[i] = left[i] * right[i];
        }
        return ans;
    }
}