namespace Staircase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            staircase(4);
        }


        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = i; j < n-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = n-1; k < n+i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
