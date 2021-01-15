using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_1_2
{
    class Program
    {
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++) //N ^ 3
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++) 
                    {
                        int y = 0;

                        if (j != 0) //O(1)
                        {
                            y = k / j;// N
                        }

                        sum += inputArray[i] + i + k + j + y; ///N O(N^3+N+N)
                    }
                }
            }

            return sum; /// O(1)
        }
    }
}
