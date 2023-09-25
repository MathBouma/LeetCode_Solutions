namespace _00003_LongestSubstringWithoutRepeatingCharacters;

/*
 * A solution using a buffer of the current substring
 */
public class Solution : ISolution
{
    public int LengthOfLongestSubstring(string s)
    {
        var maxCount = 0;
        var currCount = 0;

        List<char> letterBuffer = new();
    
        foreach (var c in s)
        {
            // If the letter is found in the current buffer/
            // There is a duplicate, so we clear out from the
            // left until it is cleaned!
            while (letterBuffer.Contains(c))
            {
                currCount -= 1;
                letterBuffer.RemoveAt(0);
            }

            // Always add the letter to the buffer,
            // now we know there are no duplicates
            currCount += 1;
            letterBuffer.Add(c);
            
            // Standard check for the size.
            if (currCount > maxCount)
                maxCount = currCount;
        }
        
        return maxCount;
    }
}