using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

namespace Solutions
{
    public class AlmostIncreasingSequence
    {
        public bool almostIncreasingSequence(int[] sequence)
        {

            var errorIndex = new List<int>();
            int headIndex = 0;
            int tailIndex = 1;

            while (tailIndex <= sequence.Length - 1)
            {
                var head = sequence[headIndex];
                var tail = sequence[tailIndex];
                var moveHead = false;
                var seriesBeginning = headIndex == 0;
                var seriesEnd = tailIndex == sequence.Length -1;
                var nextTail = seriesEnd ? int.MaxValue : sequence[tailIndex + 1];
                var previousHead = seriesBeginning ? -1 : sequence[headIndex - 1];
                
                if (head >= tail)
                {
                    if (head > nextTail)
                    {
                        errorIndex.Add(headIndex);
                        moveHead = true;
                        if (previousHead == tail)
                            errorIndex.Add(tail);
                        if(previousHead >= nextTail)
                            errorIndex.Add(tailIndex + 1);
                    }
                    else
                    {
                        errorIndex.Add(tailIndex);
                    }
                }
                else
                {
                    moveHead = true;
                }
                
                
                if (moveHead)
                    while (errorIndex.Contains(++headIndex)){}

                tailIndex++;
            }

            return errorIndex.Count == 1;
        }

    }
}