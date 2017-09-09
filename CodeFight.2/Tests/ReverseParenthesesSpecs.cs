using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class ReverseParenthesesSpecs
    {
        [Fact]
        public void should_return_valid_string_for_case()
        {
            new ReverseParentheses().reverseParentheses("a(bcdefghijkl(mno)p)q").Should().Be("apmnolkjihgfedcbq");
        }
        
    }
}