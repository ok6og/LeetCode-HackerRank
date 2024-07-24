namespace FirstUniqueCharachterInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("leetcode"));
        }

        public static int FirstUniqChar(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            foreach (char letter in s)
            {
                if (keyValuePairs.ContainsKey(letter))
                {
                    keyValuePairs[letter]++;
                }
                else
                {
                    keyValuePairs.Add(letter, 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                if (keyValuePairs[letter] == 1)
                {
                    return i;
                }
            }
            return -1;


            //Tuples rock

            //List<(string letter,int nTimes)> list = new List<(string,int)>();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    string currentChar = s[i].ToString();

            //    int index = list.FindIndex(item => item.letter == currentChar);

            //    if (index != -1)
            //    {
                   
            //        list[index] = (currentChar, list[index].nTimes + 1);
            //    }
            //    else
            //    {
            //        list.Add((currentChar, 1));
            //    }
            //}
            //var notRepeater = list.FirstOrDefault(x => x.nTimes == 1);

            //return notRepeater.letter != null ? s.IndexOf(notRepeater.letter) : -1;
            
        }
    }
}
