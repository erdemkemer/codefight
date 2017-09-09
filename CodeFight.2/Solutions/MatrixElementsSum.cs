using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Solutions
{
    public class MatrixElementsSum
    {
        public int matrixElementsSum(int[][] matrix)
        {
            int sum = 0;
            var unavailableRoomColumns = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                        unavailableRoomColumns.Add(j);
                    if (unavailableRoomColumns.Contains(j))
                        matrix[i][j] = 0;
                    else
                    {
                        sum += matrix[i][j];
                    }
                }
            }
            return sum;
        }
    }
}