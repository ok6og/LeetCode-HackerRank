namespace TwoCrystalBallsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] breaks = { false,false,false,false,false,false,false,false,false,false,true,true,true,true,true,true,true,true,true};
            int jmpAmount = (int)Math.Floor(Math.Sqrt(breaks.Length));

            int i = jmpAmount;

            for (; i < breaks.Length; i += jmpAmount) 
            {
                if (breaks[i])
                {
                    break;
                }

            }
            i -= jmpAmount;

            for (int j = 0; j < jmpAmount; j++, i++)
            {
                if (breaks[i])
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("slab4o");
        }
    }
}
