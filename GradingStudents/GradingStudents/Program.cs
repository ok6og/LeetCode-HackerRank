namespace GradingStudents1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\t", gradingStudents([4, 73, 67, 38, 33])));
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            var roundedGrades = new List<int>();

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    roundedGrades.Add(grades[i]);
                }
                else if (grades[i] % 5 >= 3)
                {
                    roundedGrades.Add(Math.Abs((grades[i] % 5) - 5) + grades[i]);
                }
                else
                {
                    roundedGrades.Add(grades[i]);
                }
            }
            return roundedGrades;
        }
    }
}
