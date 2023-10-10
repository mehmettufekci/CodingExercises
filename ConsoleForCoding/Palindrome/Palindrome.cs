using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleForCoding.Palindrome;

public class Palindrome
{
    public bool CheckPalindrome(string inputString)
    {
        bool sonuc;
        if (string.IsNullOrEmpty(inputString))
        {
            sonuc = false;
        }
        else
        {

            if ((inputString.Length / 2) < 1)
            {
                sonuc = true;
            }
            else
            {
                for (int i = 0; i < inputString.Length / 2; i++)
                {
                    if (inputString[i] != inputString[inputString.Length - i - 1])
                        return false;
                }
                return true;
            }
        }
        return sonuc;
    }
}
