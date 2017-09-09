using System;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace CodeFight.Tests
{
    public class RotateImageSpecs
    {
        [Fact]
        public void should_rotate_image()
        {
            var input = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var output = new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } };

            var result = new RotateImage().rotateImage(input);
            for (var x = 0; x < result.Length; x++)
            {
                for (int y = 0; y < result[x].Length; y++)
                {
                    result[x][y].Should().Be(output[x][y]);
                }
            }
        }
    }
}
