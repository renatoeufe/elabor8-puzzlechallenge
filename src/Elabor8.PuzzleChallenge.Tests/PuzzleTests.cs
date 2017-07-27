using System;
using System.IO;
using Elabor8.PuzzleChallenge.Solvers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Elabor8.PuzzleChallenge.Tests
{
    [TestClass]
    public class PuzzleTests
    {
        private static IPuzzleSolver _puzzleSolver;

        [ClassInitialize]
        public static void Init(TestContext context)
        {
            _puzzleSolver = new Solvers.DefaultPuzzleSolver();
        }

        [TestMethod]
        public void Should_Solve_Sample_05370342103181()
        {
            var result = _puzzleSolver.Solve(File.ReadAllLines("Samples\\05370342103181"));
            Assert.AreEqual(2, result.NumberOfGroups);
            Assert.AreEqual(12, result.NumberOfPiecesDisconnected);
        }

        [TestMethod]
        public void Should_Solve_Sample_08601592266314()
        {
            var result = _puzzleSolver.Solve(File.ReadAllLines("Samples\\08601592266314"));
            Assert.AreEqual(176, result.NumberOfGroups);
            Assert.AreEqual(559, result.NumberOfPiecesDisconnected);
        }

        [TestMethod]
        public void Should_Solve_Sample_06960860405937()
        {
            var result = _puzzleSolver.Solve(File.ReadAllLines("Samples\\06960860405937"));
            Assert.AreEqual(47, result.NumberOfGroups);
            Assert.AreEqual(177, result.NumberOfPiecesDisconnected);
        }
    }
}