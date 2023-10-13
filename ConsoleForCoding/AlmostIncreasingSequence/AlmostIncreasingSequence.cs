using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AlmostIncreasingSequence;

public class AlmostIncreasingSequence
{
    public bool IsAlmostIncreasingSequence(int[] sequence)
    {
        // Stores the count of numbers that are needed to be removed
        int count = 0;
        // Store the index of the element that needs to be removed
        int index = -1;


        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i - 1] >= sequence[i])
            {
                // Increment the count by 1
                count++;

                // Update index
                index = i;
            }
        }
        // If count is greater than one
        if (count > 1)
            return false;

        // If no element is removed
        if (count == 0)
            return true;

        // If only the last or the first element is removed
        if (index == sequence.Length - 1 || index == 1)
            return true;

        // If a[index] is removed
        if (sequence[index - 1] < sequence[index + 1])
            return true;

        // If a[index - 1] is removed
        if (index - 2 >= 0 && sequence[index - 2] < sequence[index])
            return true;

        // if there is no element to compare
        if (index < 0)
            return true;

        return false;
    }
}
