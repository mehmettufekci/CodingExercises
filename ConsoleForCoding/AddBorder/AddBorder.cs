using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AddBorder;

public class AddBorder
{
    public string[] GetBordertoPicture(string[] picture)
    {
        string[] result = { };
        int elementLength = 0;
        string star = "";
        List<string> list = new List<string>();

        foreach (var item in picture)
        {
            elementLength = item.Length + 2;
            string items = "*" + item + "*";
            if (string.IsNullOrEmpty(star))
            {
                for (int i = 0; i < elementLength; i++)
                {
                    star = star.Insert(i, "*");
                }
                list.Add(star);
            }
            list.Add(items);

        }

        list.Add(star);

        result = list.ToArray();

        return result;
    }
}
