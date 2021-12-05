using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021_Csharp
{
    class Day1
    {
        

        public static int Day1_p1(List<int> inputList)
        {
            var q = new Queue<int>();
            inputList.ForEach(x => q.Enqueue(Convert.ToInt32(x)));
            return GetDecresesCount(q);
        }

        public static int Day1_p2(List<int> inputList)
        {
            var q = new Queue<int>();
            for (int i = 0; i < inputList.Count; i++)
            {
                try
                {
                    q.Enqueue(inputList[i] + inputList[i+1] + inputList[i + 2]);
                }
                catch (Exception)
                {
                    break;
                }
            }
            return GetDecresesCount(q);
        }

        public static int GetDecresesCount(Queue<int> inputList)
        {
            var cnt = -1; var depth = 0;
            while (inputList.Count > 0)
            {
                var d = inputList.Dequeue();
                cnt = d > depth ? ++cnt : cnt;
                depth = d;
            }

            return cnt;
        }
    }
}
