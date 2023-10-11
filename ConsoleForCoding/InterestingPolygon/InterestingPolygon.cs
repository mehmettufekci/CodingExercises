using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.InterestingPolygon;

public class InterestingPolygon
{
    public int GetInterestingPolygonArea(int n)
    {
        int area = (n - 1) * n * 2 + 1;
        return area;
    }
}
