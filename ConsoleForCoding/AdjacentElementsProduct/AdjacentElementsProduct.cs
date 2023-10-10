using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AdjacentElementsProduct;

public class AdjacentElementsProduct
{
    public int GetAdjacentElementLargestProduct(int[] inputArray)
    {
        int tempVal1, maxVal = -1000;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (i < inputArray.Length - 1)
            {
                tempVal1 = inputArray[i] * inputArray[i + 1];
                if (tempVal1 > maxVal)
                {
                    maxVal = tempVal1;
                }
            }
        }
        return maxVal;
    }
}
