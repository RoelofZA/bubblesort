using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            SortLogic sortLogic = new SortLogic();
            sortLogic.Sort(new int[] {10, 9, 8, 7, 6, 5, 4, 3, 2, 1});
        }
    }
}
