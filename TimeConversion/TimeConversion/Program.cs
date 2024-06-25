namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("12:05:45PM"));
        }

        public static string timeConversion(string s)
        {
            if (s[8] == 'P')
            {
                if (s.Substring(0, 2) == "12")
                {
                    return s.Substring(0, 8);
                }
                return int.Parse(s.Substring(0,2))+12 +s.Substring(2,6);
            }
            else
            {
                if (s.Substring(0,2) == "12")
                {
                    return "00" + s.Substring(2, 6);
                }

                return s.Substring(0,8);
            }
        }
    }
}
