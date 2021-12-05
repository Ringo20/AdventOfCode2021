using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021_Csharp
{
    class AdventOfCode
    {
        static void Main(string[] args)
        {
            var inputDay1 = File.ReadAllLines("Input/input_Day1.txt").Select(x => Convert.ToInt32(x)).ToList();
            var inputDay2 = File.ReadAllLines("Input/input_Day2.txt").ToList();
            var inputDay3 = File.ReadAllLines("Input/input_Day3.txt").ToList();
            var inputDay4 = File.ReadAllLines("Input/input_Day4.txt").ToList();

            var d1p1 = Day1.Day1_p1(inputDay1);
            var d1p2 = Day1.Day1_p2(inputDay1);
            var d2p1 = Day2.Day2_Part1(inputDay2);
            var d2p1p2 = Day2.Day2_Part1_2(inputDay2);
            var d2p2 = Day2.Day2_Part2(inputDay2);
            var d3p1 = Day3.Day3_Part1(inputDay3);
            var d3p2 = Day3.Day3_Part2(inputDay3);
            var d4p1 = Day4.Day4_Part1(inputDay4);
            var d4p2 = Day4.Day4_Part2(inputDay4);
            Console.WriteLine(string.Format("Day1Part1: {0}", d1p1));
            Console.WriteLine(string.Format("Day1Part2: {0}", d1p2));
            Console.WriteLine(string.Format("Day2Part1: {0}", d2p1));
            Console.WriteLine(string.Format("Day2Part1p2: {0}", d2p1p2));
            Console.WriteLine(string.Format("Day2Part2: {0}", d2p2));
            Console.WriteLine(string.Format("Day3Part1: {0}", d3p1));
            Console.WriteLine(string.Format("Day3Part2: {0}", d3p2));
            Console.WriteLine(string.Format("Day4Part1: {0}", d4p1));
            Console.WriteLine(string.Format("Day4Part2: {0}", d4p2));
            Console.Read();
        }
    }
}
