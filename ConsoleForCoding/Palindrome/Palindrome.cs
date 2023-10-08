using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.Palindrome;

public class Palindrome
{
    public bool CheckPalindrome(string inputString)
    {
        int diziLength = (inputString.Length / 2);
        bool sonuc = false;

        if (string.IsNullOrEmpty(inputString))
        {
            sonuc = false;
        }
        else
        {

            if (diziLength < 1)
            {
                sonuc = true;
            }
            else
            {

                for (int i = 0; i < diziLength; i++)
                {
                    for (int j = inputString.Length - 1; j > diziLength; j--)
                    {
                        if (inputString[j] == inputString[i])
                        {
                            sonuc = true;
                        }
                        else
                        {
                            sonuc = false;
                        }
                    }
                }
            }
        }
        return sonuc;
    }
}
