using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AvoidObstacles;

public class AvoidObstacles
{
    public int GetJumpLength(int[] inputArray)
    {
        HashSet<int> hs = new HashSet<int>();
        int max = inputArray[0];
        for (int i = 0; i < inputArray.Length; i++)
        {
            hs.Add(inputArray[i]);
            max = Math.Max(max, inputArray[i]);
        }
        
        for (int i = 1; i <= max; i++)
        {
            int j;
            for (j = i; j <= max; j = j + i)
            {

                if (hs.Contains(j))
                    break;
            }

            if (j > max)
                return i;
        }
        return max + 1;
    }
}
