using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.MaximalAdjacentDifference;

public class MaximalAdjacentDifference
{
    public int GetMaximalAdjacentDifference(int[] inputArray)
    {
        int maximalDifference = 0;
        int leftMax = 0, rightMax= 0;

        for (int i = 1; i < inputArray.Length; i++)
        {
            // calculate left max
            if (Math.Abs(inputArray[i] - inputArray[i-1]) > leftMax)
            {
                leftMax = Math.Abs(inputArray[i] - inputArray[i - 1]);
            }

            //  means there is no element on the right side
            if ( i < inputArray.Length - 1)
            {
                // calculate right max
                if (Math.Abs(inputArray[i + 1] - inputArray[i]) > rightMax)
                {
                    rightMax = Math.Abs(inputArray[i + 1] - inputArray[i]);
                }
            }

            if (leftMax >= rightMax)
            {
                maximalDifference = leftMax;
            }
            else
            {
                maximalDifference = rightMax;
            }
        }

        return maximalDifference;
    }
}
