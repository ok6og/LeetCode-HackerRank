using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace LongestSubstringWithoutRepeatingCharachters_Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Insane code - Not Optimized
            Console.WriteLine(LengthOfLongestSubstring("dvdf"));
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int longestSubstring = 0;
            int counter = 0;

            List<(char Key, int Value)> keys = new List<(char Key, int Value)>();
        
            for (int i = 0; i < s.Length; i++)
            {
                if (!keys.Exists(x=> x.Key == s[i]))
                {
                    keys.Add((s[i],i));
                    counter++;

                    if (longestSubstring < counter)
                    {
                        longestSubstring = counter;
                    }
                }
                else
                {
                    counter = 0;
                    var lastOccuranceOfChar = keys.FindLast(x=> x.Key == s[i]);
                    keys.Clear();
                    i = lastOccuranceOfChar.Value;
                }
            }
            return longestSubstring;
        }
    }
}
