namespace _1_TwoSum;

public class BruteForceSolution : ISolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        foreach (var i in Enumerable.Range(0, nums.Length))
        {
            foreach (var ii in Enumerable.Range(0, nums.Length))
            {
                if (i != ii && nums[i] + nums[ii] == target)
                    return new[] { i, ii };
            }
        }

        return Array.Empty<int>();
    }

}
