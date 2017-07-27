namespace Elabor8.PuzzleChallenge.Solvers
{
    public interface IPuzzleSolver
    {
        PuzzleSolverResult Solve(string[] fileLines);
    }
}