//53. Maximum Subarray


internal partial class Program
{
    // 時間複雜度過高 O(N2)
    public int MaximumSubarray(int[] nums)
    {
        int len = nums.Length;
        int maxi = int.MinValue;
        for (int i = 0; i < len; i++)
        {
            int sum = 0; // 從 i 開頭的子數組
            for (int j = i; j < len; j++)
            {
                // current subarray = nums[i.....j]

                //add the current element nums[j]
                // to the sum i.e. sum of nums[i...j-1]
                sum += nums[j];

                maxi = Math.Max(maxi, sum); // getting the maximum
            }
        }
        return maxi;
    }

    public int MaxSubArray(int[] nums)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
            }
        }

        return maxSum;
    }
    public int maxSubArray(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], currentSum + nums[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;
    }
}