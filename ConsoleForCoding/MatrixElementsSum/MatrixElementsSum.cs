using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleForCoding.MatrixElementsSum;

public class MatrixElementsSum
{
    public int GetMatrixElementsSum(int[][] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {

                if (i == 0)
                {
                    if (matrix[i][j] != 0)
                    {
                        count += matrix[i][j];
                    }
                }
                else if(i == 1)
                {
                    if (matrix[i][j] != 0 && matrix[i - 1][j] != 0)
                    {
                        count += matrix[i][j];
                    }
                }
                else if (i == 2)
                {
                    if (matrix[i][j] != 0 && matrix[i - 1][j] != 0 && matrix[i - 2][j] != 0)
                    {
                        count += matrix[i][j];
                    }
                }
                else if (i == 3)
                {
                    if (matrix[i][j] != 0 && matrix[i - 1][j] != 0 && matrix[i - 2][j] != 0 && matrix[i - 3][j] != 0)
                    {
                        count += matrix[i][j];
                    }
                }
                else if (i == 4)
                {
                    if (matrix[i][j] != 0 && matrix[i - 1][j] != 0 && matrix[i - 2][j] != 0 && matrix[i - 3][j] != 0 && matrix[i - 4][j] != 0)
                    {
                        count += matrix[i][j];
                    }
                }

            }
        }

        return count;
    }
}
