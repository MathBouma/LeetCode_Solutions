namespace _1_TwoSum;

/*
 * This solution uses a hashmap
 * to check for a value that matches our guy!
 */
public class FastSolution : ISolution
{
    public int[] TwoSum(int[] nums, int target)
    {        
        var valueLookup = new Dictionary<int, int>();
        
        // Bad code, but because we know the
        // number is valid, we can skip checking to the end of the list
        for (var index = 0;; index++)
        {
            if (valueLookup.TryGetValue(target - nums[index], out var matchvalue))
            {
                return new[] { matchvalue, index};
            }

            valueLookup[nums[index]] = index;
        }
    }
}
