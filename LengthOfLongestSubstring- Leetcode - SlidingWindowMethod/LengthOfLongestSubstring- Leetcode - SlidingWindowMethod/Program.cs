namespace LengthOfLongestSubstring__Leetcode___SlidingWindowMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring("dvvdf"));
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int size = s.Length;
            int right = 0;
            int left = 0;
            int longestSubstring = 0;

            List<char> charsInString = new List<char>();

            while(right < size)
            {
                if (!charsInString.Contains(s[right]))
                {
                    charsInString.Add(s[right]);
                    right++;
                    longestSubstring = Math.Max(longestSubstring, right-left);
                }
                else
                {
                    charsInString.Remove(s[left]);
                    left++;
                }
            }
            return longestSubstring;
        }
    }
}
