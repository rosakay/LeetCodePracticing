//152. Maximum Product Subarray


internal partial class Program
{
    public int MaxProduct_0(int[] nums)
    {
        long maxSoFar = nums[0];
        long minSoFar = nums[0];
        long result = maxSoFar;

        for (int i = 1; i < nums.Length; i++)
        {
            long temp = maxSoFar;
            maxSoFar = Math.Max(Math.Max(nums[i], nums[i] * maxSoFar), nums[i] * minSoFar);
            minSoFar = Math.Min(Math.Min(nums[i], nums[i] * temp), nums[i] * minSoFar);
            result = Math.Max(result, maxSoFar);

            // 檢查溢出，並將結果限制在 int 範圍內
            if (maxSoFar > int.MaxValue)
            {
                maxSoFar = int.MaxValue;
            }
            if (minSoFar < int.MinValue)
            {
                minSoFar = int.MinValue;
            }
        }

        return (int)result;
    }

    //不符合 32位元規則
    public int MaxProduct_1(int[] nums)
    {
        int prefix = 1;
        int suffix = 1;
        int prod = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (prefix == 0)
            {
                prefix = 1;
            }
            if (suffix == 0)
            {
                suffix = 1;
            }
            prefix *= nums[i];
            suffix *= nums[nums.Length - i - 1];
            prod = Math.Max(prod, Math.Max(prefix, suffix));
        }
        return prod;
    }
}