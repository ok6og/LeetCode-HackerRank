namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SingleNumber([4, 1, 2, 1, 2]));
        }

        public static int SingleNumber(int[] nums)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i]))
                {
                    keyValuePairs.Add(nums[i], 1);
                }
                else
                {
                    keyValuePairs.Remove(nums[i]);
                }
            }
            return keyValuePairs.Keys.First();


            //BITWISE SOLUTION

            //int uniqueElement = 0;

            //foreach (var num in nums)
            //{
            //    uniqueElement ^= num;
            //}

            //return uniqueElement;
        }
    }
}
