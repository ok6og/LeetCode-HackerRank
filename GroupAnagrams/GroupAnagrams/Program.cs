namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]));
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                string[] anagrams = [];

                Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

                foreach (char smallWord in strs[i])
                {
                    if (keyValuePairs.ContainsKey(smallWord))
                    {
                        keyValuePairs[smallWord]++;
                    }
                    keyValuePairs.Add(smallWord, 1);
                }
            }
        }
    }
}
