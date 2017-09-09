using System;
using System.Collections.Generic;

namespace Solutions
{
    public class CommonCharacterCount
    {
        public int commonCharacterCount(string s1, string s2)
        {
            var l1 = new Dictionary<char,int>();
            var l2 = new Dictionary<char,int>();
    
            for(int i=0; i < s1.Length;i++)
            {
                if (l1.ContainsKey(s1[i])) 
                    l1[s1[i]]++;
                else 
                    l1[s1[i]] = 1;
            }
            for(int i=0; i < s2.Length;i++){
                if (l2.ContainsKey(s2[i])) 
                    l2[s2[i]]++;
                else 
                    l2[s2[i]] = 1;
            }
    
            int sum=0;
            foreach(var ch in l1){
                var c = ch.Key;
                if(l2.ContainsKey(c))
                    sum += Math.Min(l1[c],l2[c]);
            }
            return sum;
        }
    }
}