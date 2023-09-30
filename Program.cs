namespace DSAPrablems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 20, 13, 3, 17, 2 };
            Console.WriteLine("Unsorted array");
            InsertionSort.Display(array);
            Console.WriteLine("Sorted array");
            InsertionSort.InsertSort(array);
            InsertionSort.Display(array);

        }
    }
}