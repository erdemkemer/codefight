using System;
using System.Collections.Generic;

namespace GameOfThronesII
{
    public class Program
    {
        static void Main(string[] args)
        {
            var noTests = int.Parse(Console.ReadLine());
            var results = new List<string>();
            for(int i = 0; i < noTests; i++)
            {
                var stringA = Console.ReadLine();
                var stringB = Console.ReadLine();

                var result = haveCommon(stringA, stringB);

                results.Add(result);
            }

            results.ForEach(Console.WriteLine);
            Console.ReadKey();
        }

        public static string haveCommon(string a, string b)
        {
            var stringA = analyseString(a);
            var stringB = analyseString(b);

            int resemblance = 0;
            foreach(var p in stringA)
            {
                if (stringB.ContainsKey(p.Key))
                    resemblance++;
            }

            var result = "NO";
            if (resemblance > 0)
                result = "YES";

            return result;
        }

        public static Dictionary<char,int> analyseString(string input)
        {
            var dict = new Dictionary<char, int>();
            for(int i=0;i<input.Length;i++)
            {
                char c = input[i];
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;
            }
            return dict;
        }
    }
}