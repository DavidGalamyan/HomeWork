using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Algorithms_2_2
{
    class Program
    {
        public static int BinarySearch(int[] inputArray, int searchValue) // O(log n)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max) 
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    Console.WriteLine(mid);
                    return  mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] array = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14};
            BinarySearch(array, 12);
        }
    }
    
}
