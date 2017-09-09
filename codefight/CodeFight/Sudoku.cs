using System.Collections.Generic;

namespace CodeFight
{
    public class Sudoku
    {
        public bool sudoku2(char[][] grid)
        {
            var yLine = new HashSet<int>[9];
            var innerSqures = new HashSet<int>[3,3];
            for (int yIndex = 0; yIndex < grid.Length; yIndex++)
            {
                var xLine = new HashSet<int>();
                for (int xIndex = 0; xIndex < grid[yIndex].Length; xIndex++)
                {
                    var value = grid[yIndex][xIndex];
                    if (value == '.')
                        continue;
                    
                    int innerX = xIndex / 3;
                    int innerY = yIndex / 3;
                    
                    if (innerSqures[innerX, innerY] == null)
                        innerSqures[innerX, innerY] = new HashSet<int>();

                    if (yLine[xIndex] == null)
                        yLine[xIndex] = new HashSet<int>();

                    if (yLine[xIndex].Contains(value))
                        return false;

                    if (innerSqures[innerX, innerY].Contains(value))
                        return false;

                    if (xLine.Contains(value))
                        return false;

                    innerSqures[innerX, innerY].Add(value);
                    yLine[xIndex].Add(value);
                    xLine.Add(value);
                }
            }
            return true;
        }
    }
}