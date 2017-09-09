using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input a number");
            var n = int.Parse(Console.ReadLine());
            if (n < 1)
                return;

            var mng = new FizzbuzzManager();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(mng.GetFizzbuzz(i));
            }
        }
    }
}