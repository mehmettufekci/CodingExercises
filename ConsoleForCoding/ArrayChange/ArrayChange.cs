using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.ArrayChange;

public class ArrayChange
{
    public int GetArrayChange(int[] inputArray)
    {
        int m = 0;
        for (int i = 0; i < inputArray.Length -1; i++)
        {
            if (inputArray[i] >= inputArray[i + 1])
            {
                int d = inputArray[i] - inputArray[i + 1] + 1;
                m += d;
                inputArray[i + 1] += d;
            }
        }

        return m;
    }
}
