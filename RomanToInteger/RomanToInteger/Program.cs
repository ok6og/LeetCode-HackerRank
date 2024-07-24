namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(romanToInt("MCMXCIV"));
        }

        static int romanToInt(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>
            {
                { 'I', 1 },
                {'V',5 },
                {'X',10 },
                {'L',50 },
                {'C',100 },    
                {'D', 500 },
                {'M',1000 }
            };

            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && keyValuePairs[s[i]] < keyValuePairs[s[i + 1]])
                {
                    sum = sum - keyValuePairs[s[i]];
                }
                else
                {
                    sum = sum + keyValuePairs[s[i]];
                }
                
            }
            return sum;
        }
    }
}
