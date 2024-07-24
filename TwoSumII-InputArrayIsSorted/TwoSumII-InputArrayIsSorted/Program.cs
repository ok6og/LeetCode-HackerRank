namespace TwoSumII_InputArrayIsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(',', TwoSum([2, 7, 11, 15], 9)));
        }

        public static int[] TwoSum(int[] numbers, int target)
        {
            int sum = 0;
            for (int left = 0, right = numbers.Length-1; left < right;)
            {
                sum = numbers[left] + numbers[right];
                if (sum == target)
                {
                    return [left + 1, right + 1];
                }
                else if(sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }
            return null;



            //MY first solution
            //int numNeeded = 0;
            //for (int i = 0; i < numbers.Length-1; i++)
            //{
            //    numNeeded = target - numbers[i];

            //    if (numbers.Contains(numNeeded))
            //    {
            //        return new int[] {i+1, Array.IndexOf(numbers.Skip(i+1).ToArray(),numNeeded) + i + 2};
            //    }
            //}
            //return null;
        }
    }
}
