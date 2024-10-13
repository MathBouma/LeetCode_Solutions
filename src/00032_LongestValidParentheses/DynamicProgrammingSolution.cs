namespace _00032_LongestValidParentheses;

public class DynamicProgrammingSolution : ISolution
{
    public int LongestValidParentheses(string s)
    {
        int[] lengths = new int[s.Length];

        int currentMax = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                continue;
            }

            // The length of the previous run
            var currentLongest = lengths[i - 1];
            var indexOfPossibleOpening = i - currentLongest - 1;

            // Skip behind the previous run, and see if it is a an opening
            if (indexOfPossibleOpening >= 0 && s[indexOfPossibleOpening] == '(')
            {
                // This is the length of the chain, assuming it is isolated
                var currentLength =
                    currentLongest + 2 + lengths[Math.Max(i - currentLongest - 2, 0)];

                lengths[i] = currentLength;
                currentMax = Math.Max(currentMax, currentLength);
            }
        }
        return currentMax;
    }
}
