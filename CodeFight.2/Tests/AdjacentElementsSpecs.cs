using System;
using FluentAssertions;
using Solutions;
using Xunit;

namespace Tests
{
    public class AdjacentElementsState : IDisposable
    {
        public Solutions.AdjacentElements AdjacentElements { get; }
            
        public AdjacentElementsState()
        {
            AdjacentElements = new Solutions.AdjacentElements();
        }

        public void Dispose()
        {
        }
    }
    
    public class AdjacentElementsSpecs : IClassFixture<AdjacentElementsState>
    {
        private readonly AdjacentElements _adjacentElements;

        public AdjacentElementsSpecs(AdjacentElementsState edgeOfOceanState)
        {
            _adjacentElements = edgeOfOceanState.AdjacentElements;
        }

        [Fact]
        void should_find_largest_product_for_adjacent_elements()
        {
            var array = new[]{3, 6, -2, -5, 7, 3};
            _adjacentElements.AdjacentElementsProduct(array).Should().Be(21);
        }
    }
}