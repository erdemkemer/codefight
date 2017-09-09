using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFight
{
    public class RotateImage
    {
        public int[][] rotateImage(int[][] a)
        {
            var matrix = new int[a.Length][];
            for (var index = 0; index < a.Length; index++)
            {
                matrix[index] = new int[a[index].Length];
            }

            for(int x = 0; x < a.Length; x++)
            {
                for(int y = 0; y < a[x].Length; y++)
                {
                    int newX = y;
                    int newY = a[x].Length - 1 - x;
                    matrix[newX][newY] = a[x][y];
                }
            }

            return matrix;
        }

    }
}
