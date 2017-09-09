using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class AlmostIncreasingSequenceSpecs
    {
        [Fact]
        public void having_bad_element_at_the_beginning_case_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {10, 1, 2, 3, 4, 5}).Should().BeTrue();
        }

        [Fact]
        public void having_bad_element_at_the_middle_case_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 3, 2}).Should().BeTrue();
        }

        [Fact]
        public void having_bad_element_at_the_end_case_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 2, 1}).Should().BeTrue();
        }

        [Fact]
        public void repeated_case_should_be_false()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 2, 1, 2}).Should().BeFalse();
        }

        [Fact]
        public void having_bad_element_at_the_middle_case_longer_array_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 2, 3, 4, 99, 5, 100}).Should().BeTrue();
        }
        
        [Fact]
        public void having_bad_element_at_the_middle_case_longer_array2_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 2, 3, 4, 99, 5, 6}).Should().BeTrue();
        }
        
        

        [Fact]
        public void having_repeated_element_with_valid_case_should_be_true()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {1, 2, 3, 4, 3, 6}).Should().BeTrue();
        }
        
        [Fact]
        public void double_series_should_be_false()
        {
            var actor = new AlmostIncreasingSequence();
            actor.almostIncreasingSequence(new[] {4, 5, 6, 1, 2, 3}).Should().BeFalse();
        }
    }
}