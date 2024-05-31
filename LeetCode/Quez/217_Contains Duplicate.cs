//217. Contains Duplicate

internal partial class Program
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hashSet = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            hashSet.Add(nums[i]);
        }
        return nums.Length != hashSet.Count();
    }
}