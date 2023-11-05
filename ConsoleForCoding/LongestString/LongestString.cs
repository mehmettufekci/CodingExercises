using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.LongestString;

public class LongestString
{
    public string[] GetLongestStringsOfArray(string[] inputString)
    {

        int maxLength = inputString.Max(x => x.Length);
        string[] result = inputString.Where(x => x.Length == maxLength).ToArray();


        return result;
    }
}
