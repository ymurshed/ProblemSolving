using System;
using System.Collections.Generic;

namespace LeetcodeConsole.HashTable
{
    public class LongestSubstringWithoutRepeatingCharacters_3: IExecute
    {
        public int LengthOfLongestSubstring(string s)
        {
            var n = s.Length;
            int ans = 0, i = 0, j = 0;
            var set = new HashSet<char>();
            
            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }

            return ans;
        }

        public void Execute()
        {
            //Input: s = "pwwkew"
            //Output: 3
            //Explanation: The answer is "wke", with the length of 3.
            //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

            try
            {
                var s = "pwwkew";
                Console.WriteLine(LengthOfLongestSubstring(s));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
