namespace Move_Zeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveZeroes([0, 1, 0, 3, 12]);
        }

        public static void MoveZeroes(int[] nums)
        {
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right]>0)
                {
                    (nums[left] ,nums[right]) = (nums[right],nums[left]);
                    left += 1;
                }
            }
        }
    }
}
