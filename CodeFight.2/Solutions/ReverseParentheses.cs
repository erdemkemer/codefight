using System;
using System.Linq;

namespace Solutions
{
    public class ReverseParentheses
    {
        public string reverseParentheses(string s)
        {
            var str = "";
            for(int i = 0;i< s.Length;i++)
            {
                if (s[i] == '(')
                {
                    int retIdx;
                    str = str + revers(s, i,out retIdx);
                    i = retIdx;
                }
                else
                    str += s[i];
            }
            return str;
        }

        public string revers(string s, int index,out int returnIndex)
        {
            var str = "";
            index = index + 1;
            while (s[index] != ')')
            {
                if (s[index] == '(')
                {
                    str = str + revers(s, index,out returnIndex);
                    index = returnIndex;
                }
                    
                else
                    str += s[index];
                index++;
            }
            returnIndex = index;
            return new string(str.Reverse().ToArray());
        }
        
    }
}