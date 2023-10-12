using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.ConsecutiveArray;

public class ConsecutiveArray
{
    public int GetMissingElementsNumberOfConsecutiveArray(int[] statues)
    {
        int numberOfElements = 0;

        int min = statues.Min();
        int max = statues.Max();
        Array.Sort(statues);

        for (int i = 1; i < max; i++)
        {
            if (!statues.Contains(min + i) && (min + i) < max )
            {
                numberOfElements++;
            }
        }

        return numberOfElements;
    }
}
