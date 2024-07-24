namespace GroupAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            foreach (var group in result)
            {
                Console.WriteLine(string.Join(", ", group));
            }
        }

        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> keyValuePairs = new Dictionary<string, IList<string>>();

            string wordAnagram;

            foreach (string word in strs)
            {
                wordAnagram = String.Concat(word.OrderBy(x => x));
                if (keyValuePairs.ContainsKey(wordAnagram))
                {
                    keyValuePairs[wordAnagram].Add(word);
                }
                else
                {
                    keyValuePairs[wordAnagram] = new List<string> { word };
                }
            }

            return keyValuePairs.Values.ToList();
        }
    }
}
