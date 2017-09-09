using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFight
{
    public class RemoveKFromList
    {
        public class ListNode<T>
        {
            public ListNode()
            {
                
            }
            public ListNode(T value)
            {
                this.value = value;
            }
            public T value { get; set; }
            public ListNode<T> next { get; set; }
        }
        
        public ListNode<int> removeKFromList(ListNode<int> l, int k)
        {
            var node = l;
            var head = l;
            ListNode<int> prevNode = null;
            while (node != null) 
            {
                if (node.value == k)
                {
                    if (node == head)
                        head = node.next;
                    else if(node.next != null && node.next.value != k)
                    {
                        prevNode.next = node.next;
                    }
                    else
                    {
                        prevNode.next = null;
                    }
                }
                else
                {
                    prevNode = node;
                }
                node = node.next;
            } 

            return head;
        }

    }
}
