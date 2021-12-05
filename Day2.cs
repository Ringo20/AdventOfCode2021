using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2021_Csharp
{
    class Day2
    {
        public static int Day2_Part1(List<string> l)
        {
            var x = 0;
            var y = 0;
            l.ForEach(d => {
                var cmd = d.Split(" ")[0].ToLower();
                var unit = Convert.ToInt32(d.Split(" ")[1]);
                x = cmd.Contains("forward") ? x += unit : x;
                y = cmd.Contains("up") ? y -= unit : cmd.Contains("down") ? y += unit :y;
            }
            );
            return x*y;

        }
        public static int Day2_Part2(List<string> l)
        {
            var x = 0;
            var aim = 0;
            var depth = 0;
            l.ForEach(d => {
                var cmd = d.Split(" ")[0].ToLower();
                var unit = Convert.ToInt32(d.Split(" ")[1]);
                x = cmd.Contains("forward") ? x += unit : x;
                depth = cmd.Contains("forward") ? depth += unit*aim : depth;
                aim = cmd.Contains("up") ? aim -= unit : cmd.Contains("down") ? aim += unit : aim;
            });
            return x * depth;

        }
        public static int Day2_Part1_2(List<string> l)
        {
            var x = 0;
            var y = 0;
            var values = l.GroupBy(i => i.Split(" ")[0].ToLower()).Select(s => new { cmd = s.Key, unit = s.Sum(g => Convert.ToInt32(g.Split(" ")[1])) }).ToList();
            x = values.Where(v => "forward".Equals(v.cmd)).First().unit;
            y = values.Where(v => "down".Equals(v.cmd)).First().unit - values.Where(v => "up".Equals(v.cmd)).First().unit;
            return x * y;

        }

    }
}
