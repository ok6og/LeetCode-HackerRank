namespace BirthDayCakeCandles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> candles = [3,2,1,3];
            int candlesNumber = birthdayCakeCandles(candles);
            Console.WriteLine($"{candlesNumber}");
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            //int maxAge = candles.Max();
            return candles.Count(num => num.Equals(candles.Max()));
        }
    }
}
