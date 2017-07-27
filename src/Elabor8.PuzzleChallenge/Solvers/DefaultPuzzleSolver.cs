using System.Collections.Generic;
using System.Linq;

namespace Elabor8.PuzzleChallenge.Solvers
{
    public class DefaultPuzzleSolver : IPuzzleSolver
    {
        private int _numberOfPieces;
        private int _numberOfOperations;
        private readonly List<NumberGroup> _pairs = new List<NumberGroup>();

        public PuzzleSolverResult Solve(string[] fileLines)
        {
            Initialize(fileLines);

            bool keepMerging;
            do
            {
                var mergeFound = false;

                foreach (var pair in _pairs)
                {
                    if (pair.Merged) continue;
                    foreach (var anotherPair in _pairs.Where(x => x.GroupId != pair.GroupId))
                    {
                        var merged = pair.MergeWith(anotherPair);
                        if (mergeFound == false && merged)
                            mergeFound = true;
                    }
                }

                _pairs.RemoveAll(x => x.Merged);
                keepMerging = mergeFound;
            } while (keepMerging);

            return new PuzzleSolverResult
            {
                NumberOfGroups = _pairs.Count,
                NumberOfPiecesDisconnected = _numberOfPieces - _pairs.SelectMany(x => x.Numbers).Distinct().Count()
            };
        }

        private void Initialize(IReadOnlyList<string> fileLines)
        {
            _numberOfPieces = int.Parse(fileLines[0].Split(' ')[0]);
            _numberOfOperations = int.Parse(fileLines[0].Split(' ')[1]);

            for (var i = 1; i <= _numberOfOperations; i++)
            {
                var item = fileLines[i];

                var a = int.Parse(item.Split(' ')[0]);
                var b = int.Parse(item.Split(' ')[1]);

                _pairs.Add(new NumberGroup(a, b));
            }
        }
    }
}