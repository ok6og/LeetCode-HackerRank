namespace _1WeekPreperationKit_Time_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(timeConversion("12:05:45AM")); 
        }

        public static string timeConversion(string s)
        {
            if (s.Contains("PM"))
            {
                if (s.Substring(0, 2) == "12")
                {
                    return s.Substring(0, 8);
                }

                int hour = int.Parse(s.Substring(0, 2));
                hour += 12;

                return (hour + s.Substring(2,6));
            }
            else
            {
                if (s.Substring(0, 2) == "12")
                {
                    return  "00" + s.Substring(2, 6);
                }

                return s.Substring(0, 8);
            }
        }
    }
}
