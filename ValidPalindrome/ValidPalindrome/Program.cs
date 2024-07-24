using System.Text;

namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("0P"));
        }

        public static bool IsPalindrome(string s)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i]))
                {
                    sb.Append(s[i]);
                }
            }
            var newString = sb.ToString().ToLower();
            return newString == new string(newString.Reverse().ToArray());
        }
    }
}
