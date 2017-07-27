using System;
using System.Collections.Generic;
using System.Linq;

namespace Elabor8.PuzzleChallenge
{
    public class NumberGroup
    {
        public Guid GroupId { get; } = Guid.NewGuid();
        public List<int> Numbers { get; } = new List<int>();
        public bool Merged { get; private set; }

        public NumberGroup(int a, int b)
        {
            Numbers.AddRange(new[] { a, b });
        }

        public bool MergeWith(NumberGroup numberGroup)
        {
            if (numberGroup.Merged)
                return false;

            if (!Numbers.Any(n => numberGroup.Numbers.Contains(n)))
                return false;

            foreach (var number in numberGroup.Numbers)
                if (!Numbers.Contains(number))
                    Numbers.Add(number);

            numberGroup.Merged = true;

            return true;
        }
    }
}