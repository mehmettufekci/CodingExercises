using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.ReverseInParentheses;

public class ReverseInParentheses
{
    public string GetReverseInParentheses(string inputString)
    {
        string result = " ";


        int lid = inputString.LastIndexOf('(');
        if (lid == -1)
        {
            result = inputString;
        }
        else
        {
            int rid = inputString.IndexOf(')', lid);

            result = inputString.Substring(0, lid) + new string(inputString.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) + inputString.Substring(rid + 1);

        }

        if (result.Contains(')'))
        {
            result = GetReverseInParentheses(result);
        }


        return result;
    }
}
