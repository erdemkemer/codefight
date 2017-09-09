using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class CommonCharacterCountSpecs
    {
        [Fact]
        public void should_return_2_for_aab_and_caa()
        {
            new CommonCharacterCount().commonCharacterCount("aab", "caa").Should().Be(2);
        }
    }
}