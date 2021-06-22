using System;
using System.Collections.Generic;

namespace LeetcodeConsole.HashTable
{
    public class LongestSubstringWithoutRepeatingCharacters_3: IExecute
    {
        public int LengthOfLongestSubstring(string s)
        {
            var n = s.Length;
            int maxLength = 0, start = 0, end = 0;
            var uniqueChars = new List<char>();
            var maxSubString = "";


            while (start < n && end < n)
            {
                if (!uniqueChars.Contains(s[end]))
                {
                    uniqueChars.Add(s[end++]);
                    maxLength = Math.Max(maxLength, end - start);
                }
                else
                {
                    if (uniqueChars.Count > maxSubString.Length)
                    {
                        maxSubString = string.Join("", uniqueChars); // get the longest sub-string without repetitive chars
                        Console.WriteLine(maxSubString);
                    }
                    uniqueChars.Remove(s[start++]); // increase 'start' just to make the max count consistent in the if block
                }
            }

            return maxLength;
        }

        public void Execute()
        {
            //Input: s = "pwwkew"
            //Output: 3
            //Explanation: The answer is "wke", with the length of 3.
            //Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

            try
            {
                //var s = "abcadb";
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
