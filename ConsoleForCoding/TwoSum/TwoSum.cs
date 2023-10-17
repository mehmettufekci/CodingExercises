using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.TwoSum;

public class TwoSum
{
    public int[] GetTwoSum(int[] nums, int target)
    {
        int num1 = 0;
        int num2 = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                    if (nums[i] + nums[j] == target)
                    {
                        num1 = i;
                        num2 = j;
                        goto Foo;
                    }
            }
        }

    Foo:
        int[] result = { num1, num2 };
        return result;
    }

}
