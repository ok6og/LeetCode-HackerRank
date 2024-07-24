namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]));
        }

        public static int MaxArea(int[] height)
        {
            int maxArea = 0;

            for (int left = 0, right = height.Length-1; left < right;)
            {
                if ((right - left) * Math.Min(height[left], height[right]) > maxArea)
                {
                    maxArea = (right - left) * Math.Min(height[left], height[right]);
                }
                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return maxArea;
        }
    }
}
