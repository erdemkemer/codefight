using System;
using System.Collections.Generic;
using System.Text;

namespace CodeFight
{
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }
    }

    public class IsPalandrome
    {
        public bool isListPalindrome(ListNode<int> l)
        {
            var hs = new List<int>();
            int count = 0;
            while (l != null)
            {
                hs.Add(l.value);
                count++;
                l = l.next;
            }
            for (int i = 0; i < hs.Count / 2; i++)
            {
                var ieq = hs.Count - 1 - i;
                if (hs[i] != hs[ieq])
                    return false;
            }
            return true;
        }

    }
}
