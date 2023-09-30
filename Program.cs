namespace DSAPrablems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 13, 3, 17, 2 };
            Console.WriteLine("Unsorted array");
            BubbleSort.Display(array);
            Console.WriteLine("Sorted array");
            BubbleSort.Sort(array);
            BubbleSort.Display(array);

        }
    }
}