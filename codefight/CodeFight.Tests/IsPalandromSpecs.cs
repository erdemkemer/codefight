using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace CodeFight.Tests
{
    public class IsPalandromSpecs
    {
        [Fact]
        void should_true_for_real_palandrome()
        {
            var node = new ListNode<int>();
            node.value = 0;
            node.next = new ListNode<int>();
            node.next.value = 1;
            node.next.next = new ListNode<int>();
            node.next.next.value = 0;
            new IsPalandrome().isListPalindrome(node).Should().BeTrue();
        }
    }
}