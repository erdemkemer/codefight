using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Solutions
{
    public class AreSimiliar
    {
        public bool areSimilar(int[] a, int[] b)
        {
            int noSwap = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    if (i + 1 < a.Length && a[i + 1] == b[i])
                    {
                        noSwap++;
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                    }
                    else
                    {
                        noSwap++;
                    }
            }
            return noSwap <= 1;
        }

        public bool areSimilar2(int[] a, int[] b) {
            var dic1 = new Dictionary<int,int>();
            var dic2 = new Dictionary<int,int>();
            for(int i=0;i < a.Length; i++){
                if(!dic1.ContainsKey(a[i]))
                    dic1[a[i]] = 1;
                else
                    dic1[a[i]]++;
                if(!dic2.ContainsKey(b[i]))
                    dic2[b[i]] = 1;
                else
                    dic2[b[i]]++;
            }
            int aOneMore=0,aOneLess=0;
            foreach(var item in dic1)
            {
                if (!dic2.ContainsKey(item.Key) || 
                    dic2[item.Key] - item.Value > 1 || 
                    dic2[item.Key] - item.Value < -1)
                    return false;
                else if (dic2[item.Key] - item.Value == 1)
                    aOneLess++;
                else if (dic2[item.Key] - item.Value == -1)
                    aOneMore++;
            
            }
            foreach(var item in dic2)
            {
                if (!dic1.ContainsKey(item.Key))
                    return false;
            
            }
            Console.WriteLine(aOneLess);
            Console.WriteLine(aOneMore);
            return aOneLess + aOneMore == 0;
        }

    }
}