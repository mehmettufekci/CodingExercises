using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleForCoding.IsLucky;

public class IsLucky
{
    public bool GetIsLucky(int n)
    {
        bool result = false;
        int firstHalfTotal = 0;
        int secondHalfTotal = 0;

        string numStr = n.ToString();
        int length = numStr.Length;
        int halfLength = length / 2;
        string firstHalf = numStr.Substring(0, halfLength);
        char[] firstHalfDigits = firstHalf.ToCharArray();
        for (int i = 0; i < firstHalfDigits.Length; i++)
        {
            firstHalfTotal += int.Parse(firstHalfDigits[i].ToString());
        }

        string secondHalf = numStr.Substring(halfLength);
        char[] secondHalfDigits = secondHalf.ToCharArray();
        for (int i = 0; i < secondHalfDigits.Length; i++)
        {
            secondHalfTotal += int.Parse(secondHalfDigits[i].ToString());
        }

        if (firstHalfTotal == secondHalfTotal)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        return result;
    }

    
}
