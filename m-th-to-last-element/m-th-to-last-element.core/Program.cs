using System;
using System.Collections.Generic;
using System.Linq;

namespace m_th_to_last_element.core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var M = Console.ReadLine();
            var L = Console.ReadLine();

            Console.WriteLine(find_mth_element_from_tail(M, L));
        }


        public static string find_mth_element_from_tail(string M, string L)
        {
            var m = int.Parse(M);

            if (string.IsNullOrEmpty(L))
                return "NIL";

            var list = new LinkedList<int>();
            var inputList = L.Split(' ').Select(int.Parse).ToList();

            if (m > inputList.Count || 0 == m)
            {
                return "NIL";
            }

            var node = list.AddFirst(inputList.First());

            for (int i = 1; i < inputList.Count; i++)
            {
                var item = inputList[i];
                node = list.AddAfter(node,item);
            }

            var tail = list.Last;
            for (int i = 2; i <= m; i++)
                tail = tail.Previous;

            return tail.Value.ToString();
        }

    }
}