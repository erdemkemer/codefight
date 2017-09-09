using System;
using FluentAssertions;
using Xunit;

namespace Tests
{
    public class PalindromeFixtureState : IDisposable
    {
        public Solutions.Palindrome Palindrome;
        public PalindromeFixtureState()
        {
            Palindrome = new Solutions.Palindrome();
        }

        public void Dispose()
        {
        }
    }
    
    public class PalindromeSpecs : IClassFixture<PalindromeFixtureState>
    {
        private readonly Solutions.Palindrome _palindrome;
        public PalindromeSpecs(PalindromeFixtureState palindromeFixtureState)
        {
            _palindrome = palindromeFixtureState.Palindrome;
        }
        
        [Theory]
        [InlineData("a")]
        [InlineData("asa")]
        [InlineData("basab")]
        public void should_be_palindrome_when_palindrome_of_odd_length_string(string input)
        {
            _palindrome.CheckPalindrome(input).Should().BeTrue();

        }
        [Theory]
        [InlineData("abba")]
        [InlineData("xabbax")]
        public void should_be_palindrome_when_palindrome_of_even_length_string(string input)
        {
            _palindrome.CheckPalindrome(input).Should().BeTrue();
        }
        
        [Theory]
        [InlineData("abbaa")]
        [InlineData("xabbaxc")]
        [InlineData("ab")]
        public void should_be_palindrome_when_not_palindrome(string input)
        {
            _palindrome.CheckPalindrome(input).Should().BeFalse();
        }
        
        [Fact]
        public void should_not_be_palindrome_when_empty()
        {
            _palindrome.CheckPalindrome("").Should().BeFalse();
        }
        
        [Fact]
        public void should_not_be_palindrome_when_null()
        {
            _palindrome.CheckPalindrome(null).Should().BeFalse();
        }
    }
}