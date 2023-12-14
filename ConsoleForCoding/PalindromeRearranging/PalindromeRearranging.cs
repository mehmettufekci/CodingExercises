using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.PalindromeRearranging
{
    public class PalindromeRearranging
    {
        public bool IsPalindromeRearranging(string inputString)
        {
            int NunmerOfChars = 256;

            // Create a count array and initialize all values as 0
            int[] count = new int[NunmerOfChars];
            Array.Fill(count, 0);

            // For each character in input strings, increment count in the corresponding count array
            for (int i = 0; i < inputString.Length; i++)
                count[(int)(inputString[i])]++;

            // Count odd occurring characters
            int odd = 0;
            for (int i = 0; i < NunmerOfChars; i++)
            {
                if ((count[i] & 1) == 1)
                    odd++;

                if (odd > 1)
                    return false;
            }

            return true;
        }
    }
}
