using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using FluentAssertions;
using Xunit;

namespace CodeFight.Tests
{
    public class RemoveKFromListSPecs
    {
        [Fact]
        void should_remove_item_from_list()
        {
            //[3, 1, 2, 3, 4, 5] and k = 3
            var item = new RemoveKFromList();
            var head = new RemoveKFromList.ListNode<int>(3);
            var l = head;
            l.next = new RemoveKFromList.ListNode<int>(1);
            l = l.next;
            l.next = new RemoveKFromList.ListNode<int>(2);
            l = l.next;
            l.next = new RemoveKFromList.ListNode<int>(3);
            l = l.next;
            l.next = new RemoveKFromList.ListNode<int>(4);
            l = l.next;
            l.next = new RemoveKFromList.ListNode<int>(5);

            var result = item.removeKFromList(head, 3);
            result.value.Should().Be(1);
            result.next.value.Should().Be(2);
            result.next.next.value.Should().Be(4);
            result.next.next.next.value.Should().Be(5);
        }

        [Fact]
        void should_move_head()
        {
            //[1, 2, 3] and k = 1
            var item = new RemoveKFromList();
            var l = new RemoveKFromList.ListNode<int>(1)
            {
                next = new RemoveKFromList.ListNode<int>(2)
            };
            l.next.next = new RemoveKFromList.ListNode<int>(3);

            var result = item.removeKFromList(l, 1);
            result.value.Should().Be(2);
            result.next.value.Should().Be(3);
        }

        [Fact]
        void should_remove_long_tail()
        {
            //[1, 3, 3, 3] and k = 3
            var item = new RemoveKFromList();
            var l = new RemoveKFromList.ListNode<int>(1)
            {
                next = new RemoveKFromList.ListNode<int>(3)
            };
            l.next.next = new RemoveKFromList.ListNode<int>(3);
            l.next.next.next = new RemoveKFromList.ListNode<int>(3);

            var result = item.removeKFromList(l, 3);
            result.value.Should().Be(1);
            result.next.Should().BeNull();
        }

        [Fact]
        void should_remove_tail()
        {
            //[1, 2, 3] and k = 3
            var item = new RemoveKFromList();
            var l = new RemoveKFromList.ListNode<int>(1)
            {
                next = new RemoveKFromList.ListNode<int>(2)
            };
            l.next.next = new RemoveKFromList.ListNode<int>(3);

            var result = item.removeKFromList(l, 3);
            result.value.Should().Be(1);
            result.next.value.Should().Be(2);
        }


        [Fact]
        void should_return_for_empty()
        {
            //[1, 2, 3] and k = 3
            var item = new RemoveKFromList();
            var l = new RemoveKFromList.ListNode<int>(0);
            var result = item.removeKFromList(l, 3);
            result.Should().Be(l);
        }
    }
}