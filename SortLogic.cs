using System;

namespace BubbleSort
{
    class SortLogic
    {
        public void Sort(int[] numberArr)
        {
            int[] sortedArr = numberArr;
            for(int x =0; x<numberArr.Length; x++)
                Console.Write(numberArr[x]);

            Console.WriteLine();

            for(int x =0; x<numberArr.Length; x++) {
                for(int y = 0; y<numberArr.Length-x-1; y++) {
                    if (numberArr[y]>numberArr[y+1])
                    {
                        int val = numberArr[y];
                        numberArr[y] = numberArr[y+1];
                        numberArr[y+1] = val;
                    }
                }
                
                for(int z =0; z<numberArr.Length; z++)
                    Console.Write(numberArr[z]);

                Console.WriteLine();
            }
            for(int x =0; x<numberArr.Length; x++)
                Console.Write(numberArr[x]);
        }
    }
}
