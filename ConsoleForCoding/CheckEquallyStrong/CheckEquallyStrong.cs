using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.CheckEquallyStrong;

public class CheckEquallyStrong
{
    public bool AreEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
    {
        bool result = false;
        int yourStrongestArm = 0;
        int yourWeakestArm = 0;
        int friendsWeakestArm = 0;
        int friendsStrongestArm = 0;
         
        if (yourRight >= yourLeft)
        {
            yourStrongestArm = yourRight;
            yourWeakestArm = yourLeft;
        }
        else
        {
            yourStrongestArm = yourLeft;
            yourWeakestArm = yourRight;
        }

        if (friendsRight >= friendsLeft)
        {
            friendsStrongestArm = friendsRight;
            friendsWeakestArm = friendsLeft;
        }
        else
        {
            friendsStrongestArm = friendsLeft;
            friendsWeakestArm = friendsRight;
        }

        if (yourStrongestArm == friendsStrongestArm)
        {
            if (yourWeakestArm == friendsWeakestArm)
            {
                result = true;
            }
            else
            {
                result = false;
            }
        }
        
        return result;
    }
}
