using System;
using System.Collections.Generic;

namespace LeetcodeConsole
{
    public class Program
    {
        public static string CurrentTag => "HashTable";

        #region CurrentTag List
        private protected static Dictionary<string, List<string>> TagClassMapping = new Dictionary<string, List<string>>
        {
            {
                "HashTable", new List<string>
                {
                    "TwoSum_1",
                    "LongestSubstringWithoutRepeatingCharacters_3"
                }
            }
        };
        #endregion

        #region Properties
        public static string NameSpace => "LeetcodeConsole";
        public static string Method => "Execute";
        #endregion

        public static void Main(string[] args)
        {
            var ob = Activator.CreateInstance($"{NameSpace}", $"{NameSpace}.{CurrentTag}.{TagClassMapping[CurrentTag][1]}");
            var p = ob.Unwrap();
            var t = p.GetType();
            var method = t.GetMethod(Method);
            method?.Invoke(p, null);
        }
    }
}
