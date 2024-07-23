namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "anagram"));
        }

        public static bool IsAnagram(string s, string t)
        {
            return s.ToList().Order().SequenceEqual(t.ToList().Order());
        }
    }
}
