namespace SortThePeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(" ,",SortPeople(["Mary", "John", "Emma"], [180, 165, 170])));
        }

        public static string[] SortPeople(string[] names, int[] heights)
        {
            (string Name, int Height)[] people = new (string Name, int Height)[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                people[i] = (names[i], heights[i]);
            }
            return people.OrderByDescending(x => x.Height).Select(x => x.Name).ToArray();
        }
    }
}
