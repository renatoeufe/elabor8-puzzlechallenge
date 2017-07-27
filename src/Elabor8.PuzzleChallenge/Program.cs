using System;
using System.IO;
using Elabor8.PuzzleChallenge.Solvers;

namespace Elabor8.PuzzleChallenge
{
    internal class Program
    {
        private static readonly IPuzzleSolver PuzzleSolver = new DefaultPuzzleSolver();

        private static void Main(string[] args)
        {
            var filename = "05940506228403";

            if (args.Length > 0)
            {
                filename = args[0];
                Console.WriteLine(filename);
            }

            var result = PuzzleSolver.Solve(File.ReadAllLines(filename));

            Console.WriteLine($"{result.NumberOfPiecesDisconnected} Alone");
            Console.WriteLine($"{result.NumberOfGroups} Groups");
            Console.ReadKey();
        }
    }
}