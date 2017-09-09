using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class AreSilimiarSpecs
    {
        AreSimiliar obj = new AreSimiliar();

        [Fact]
        public void should_be_similiar_for_case_already_equal()
        {
            var a = new[] {1, 2, 3};
            var b = new[] {1, 2, 3};
            
            obj.areSimilar(a,b).Should().BeTrue();
            
        }
        
        [Fact]
        public void should_be_similiar_for_case_one_swap()
        {
            var a = new[] {1, 2, 3};
            var b = new[] {2, 1, 3};
            
            obj.areSimilar(a,b).Should().BeTrue();
            
        }
        
        [Fact]
        public void should_not_be_similiar_for_case_non_equal_with_one_swap()
        {
            var a = new[] {1, 2, 2};
            var b = new[] {2, 1, 1};
            
            obj.areSimilar(a,b).Should().BeFalse();
            
        }
        
        [Fact]
        public void should_not_be_similiar_for_case_non_equal_with_one_swap_2()
        {
            var a = new[] {4, 6, 3};
            var b = new[] {3, 4, 6};
            
            obj.areSimilar(a,b).Should().BeFalse();
            
        }
        
    }
}