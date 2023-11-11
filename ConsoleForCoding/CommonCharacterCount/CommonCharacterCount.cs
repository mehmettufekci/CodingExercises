using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.CommonCharacterCount;

public class CommonCharacterCount
{
    public int GetCommonCharacterCount(string s1, string s2)
    {
        int result = 0;

        for (int i = 0; i < s1.Length; i++)
        {
            if (s2.Contains(s1[i]))
            {
                result++;
                s2 = s2.Remove(s2.IndexOf(s1[i]), 1);
            }
        }

        return result;
    }
}
