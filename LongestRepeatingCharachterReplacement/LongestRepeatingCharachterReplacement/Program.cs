namespace LongestRepeatingCharachterReplacement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CharacterReplacement("ABAB",2));
        }

        public static int CharacterReplacement(string s, int k)
        {
            Dictionary<char,int> map = new Dictionary<char,int>();
            int result = 0;

            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                if (map.ContainsKey(s[right]))
                    map[s[right]]++;
                else
                    map[s[right]] = 1;

                while ((right - left +1 - map.Values.Max()) > k)
                {
                    map[s[left]] -= 1;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }
            return result;
        }
    }
}
