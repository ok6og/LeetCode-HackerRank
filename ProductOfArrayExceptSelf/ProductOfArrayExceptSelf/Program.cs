namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductExceptSelf([-1, 1, 0, -3, 3]));
        }

        public static int[] ProductExceptSelf(int[] nums)
        {
            int count = 0;
            var array = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i != count)
                {
                    int sum = nums.SkipWhile(x => x. )
                }
                int sum = nums.
            }
        }
    }
}
