using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class MatrixElementsSumSpecs
    {
        [Fact]
        public void should_return_2_for_input()
        {
            var input = new int[][]{new[]{0, 1, 1, 2}, new[]{0, 5, 0, 0}, new[]{2, 0, 3, 3}};
            var obj = new MatrixElementsSum();
            obj.matrixElementsSum(input).Should().Be(9);
        }
    }
}