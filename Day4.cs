using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AdventOfCode2021_Csharp
{
    public class Day4
    {
        public static int Day4_Part1(List<string> input)
        {
            var numbers = input.First();
            var boards = BuildBoards(input);
            List<List<string>> winner = null ;
            foreach (var number in numbers.Split(","))
            {
                boards = MarkNumbers(boards, number);
                winner = GetWinner(boards);
                if (winner != null)
                {

                    return GetWinnerBoardScore(winner) * Convert.ToInt32(number);
                }
            }
            return 0;
        }
        public static int Day4_Part2(List<string> input)
        {
            var numbers = input.First();
            var boards = BuildBoards(input);
            foreach (var number in numbers.Split(","))
            {
                boards = MarkNumbers(boards, number);
                if (boards.Count == 1)
                {
                    return GetWinnerBoardScore(boards.First()) * Convert.ToInt32(number);
                }
                boards = RemoveWinner(boards);
                
            }
            return 0;
        }

        public static int GetWinnerBoardScore(List<List<string>> winner)
        {
            var sum = 0;
            winner.ForEach(r => r.ForEach(n => sum += Convert.ToInt32(n) != -1 ? Convert.ToInt32(n) : 0));
            return sum;
        }

        public static List<List<string>> GetWinner(List<List<List<string>>> boards)
        {
            List<List<string>> winner = null;
            foreach (var board in boards)
            {
                if(board.Any(r=> r.Sum(n=> Convert.ToInt32(n)) == -5))
                {
                    winner = board;
                    break;
                }
                for (int i = 0; i < board[0].Count; i++)
                {
                    if (board.Sum(x => Convert.ToInt32(x[i].ToString())) == -5)
                    {
                        winner = board;
                        break;
                    }
                }


            }
            return winner;
        }
        public static List<List<List<string>>> RemoveWinner(List<List<List<string>>> boards)
        {
            List<List<string>> winner = null;
            for (int b = 0; b < boards.Count; b++)
            {

                winner = null;
                if (boards[b].Any(r => r.Sum(n => Convert.ToInt32(n)) == -5))
                {
                    winner = boards[b];
                    
                }
                for (int i = 0; i < boards[b][0].Count; i++)
                {
                    if (boards[b].Sum(x => Convert.ToInt32(x[i].ToString())) == -5)
                    {
                        winner = boards[b];
                        
                    }
                }
                if (winner != null) boards.Remove(winner);
            }
            return boards;
        }

        public static List<List<List<string>>> MarkNumbers(List<List<List<string>>> boards,string number)
        {
            for (int b = 0; b < boards.Count; b++)
            {
                for (int r = 0; r < boards[b].Count; r++)
                {
                    for (int n = 0; n < boards[b][r].Count; n++)
                    {
                        if (boards[b][r][n] == number)
                        {
                            boards[b][r][n] = "-1";
                        }
                    }
                }
            }
            return boards;
        }

        public static List<List<List<string>>> BuildBoards(List<string> input)
        {
            var boards = new List<List<List<string>>>();
            var board = new List<List<string>>();
            foreach (var item in input.Skip(1).ToList())
            {
                if (item == "")
                {
                    if (board.Count > 0) { boards.Add(board); }
                    board = new List<List<string>>();
                    continue;
                }
                var row = new List<string>();
                row.AddRange(item.Split(" ").Where(x => x != ""));
                board.Add(row);
            }
            return boards;
        }
    }
}
