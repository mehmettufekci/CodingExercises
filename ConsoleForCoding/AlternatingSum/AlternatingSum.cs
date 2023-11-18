using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AlternatingSum;

public class AlternatingSum
{
    public int[] GetAlternatingSum(int[] a)
    {
        List<int> a1 = new List<int>();
        List<int> a2 = new List<int>();
        int[] result = new int[2];

        for (int i = 0; i < a.Length; i++)
        {
            if (i%2 == 0)
            {
                a1.Add(a[i]);
            }
            else if (i % 2 == 1)
            {
                a2.Add(a[i]);
            }
        }

        result[0] = a1.Sum();
        result[1] = a2.Sum();

        return result;
    }
}
