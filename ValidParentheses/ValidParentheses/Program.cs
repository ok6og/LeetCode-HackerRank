using System.Linq;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("){"));
        }

        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0 || s.Length == 0 || s == null ) return false;
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> pairs = new Dictionary<char, char> 
            {
                { '(', ')' },
                {'[', ']' },
                {'{', '}' }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (pairs.ContainsKey(s[i]))
                {
                    stack.Push(s[i]);
                }
                else if( stack.Count == 0)
                {
                    return false;
                }
                else if(pairs[stack.Pop()] != s[i])
                {
                    return false;
                }

            }
            return stack.Count == 0;
        }
    }
}
