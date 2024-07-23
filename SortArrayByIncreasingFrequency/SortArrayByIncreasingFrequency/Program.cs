using System.Linq;

namespace SortArrayByIncreasingFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ,",FrequencySort([2, 3, 1, 3, 2])));
        }

        public static int[] FrequencySort(int[] nums)
        {
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            foreach (int num in nums)
            {
                if (keyValuePairs.ContainsKey(num))
                {
                    keyValuePairs[num]++;
                }
                else
                {
                    keyValuePairs.Add(num, 1);
                }
            }
            return keyValuePairs.OrderBy(x => x.Value).ThenByDescending(x=>x.Key).SelectMany(x => Enumerable.Repeat(x.Key, x.Value)).ToArray();
        }
    }
}
