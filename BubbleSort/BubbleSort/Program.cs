namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [2, 0, 2, 1, 1, 0];


            Console.WriteLine(String.Join(" ,", BubbleSort(arr)));
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j+1]) = (arr[j+1], arr[j]);
                        //int temp = arr[j];
                        //arr[j] = arr[j + 1];
                        //arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
