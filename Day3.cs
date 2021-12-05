using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace AdventOfCode2021_Csharp
{
    class Day3
    {
        public static int Day3_part1()
        {
            var cnt = 0;

            return cnt;
        }

        public static int Day3_Part1(List<string> inputDay3)
        {
            var tot = inputDay3.Count;
            var gammaBit = "";
            var epsilon = "";
            for (int i = 0; i < inputDay3[0].Length; i++)
            {
                gammaBit += inputDay3.Sum(x => Convert.ToInt32(x[i].ToString())) > (tot / 2) ? "1" : "0";
                epsilon += inputDay3.Sum(x => Convert.ToInt32(x[i].ToString())) > (tot / 2) ? "0" : "1";
            }
            return Convert.ToInt32(gammaBit, 2) * Convert.ToInt32(epsilon, 2);
        }
        public static int Day3_Part2(List<string> inputDay3)
        {
            var index = 0;
            return Convert.ToInt32(GetOxygenGeneratorRating(inputDay3, index), 2) * Convert.ToInt32(GetCO2ScrubRating(inputDay3, index), 2);
        }

        public static string GetOxygenGeneratorRating(List<string> input, int i)
        {
            var tot = input.Count;
            var h = tot / 2.0;
            if (tot == 1)
                return input[0];
           var check = input.Count(x => Convert.ToInt32(x[i].ToString())==1) >= (tot / 2.0) ? "1" : "0";
           return GetOxygenGeneratorRating(input.Where(x => x[i].ToString() == check).ToList(), ++i);
        }
        public static string GetCO2ScrubRating(List<string> input, int i)
        {
            var tot = input.Count;
            var h = tot / 2.0;
            if (tot == 1)
                return input[0];

           var check = input.Count(x => Convert.ToInt32(x[i].ToString())==1) >= (tot / 2.0) ? "0" : "1";
           return GetCO2ScrubRating(input.Where(x => x[i].ToString() == check).ToList(), ++i);
        }

    }
}
