using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.AreSimilar;

public class AreSimilar
{
    public bool ArraysAreSimilar(int[] a, int[] b)
    {
        // Find the indices where the elements differ
        var diffIndices = Enumerable.Range(0, a.Length).Where(i => a[i] != b[i]).ToList();

        // If there are no differing elements, or if there are exactly two differing elements,
        // check if swapping these elements makes the arrays equal
        if (diffIndices.Count == 0 || (diffIndices.Count == 2 && a[diffIndices[0]] == b[diffIndices[1]] && a[diffIndices[1]] == b[diffIndices[0]]))
            return true;
        else
            return false;
    }
}
