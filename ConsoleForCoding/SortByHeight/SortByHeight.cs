using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.SortByHeight;

public class SortByHeight
{
    public int[] GetSortByHeight(int[] a)
    {
        int[] b = new int[a.Length];

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == -1)
            {
                b[i] = a[i];
            }
        }
       
        a = a.Where(e => e != -1).ToArray();
        Array.Sort(a);

        int index = 0;

        for (int i = 0; i < b.Length; i++)
        {
            if (b[i] != -1)
            {
                b[i] = a[index];
                index++;
            }
        }

        return b;
    }
}
