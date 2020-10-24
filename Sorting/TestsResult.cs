using System;
using System.Collections.Generic;

namespace Sorting
{
    class TestsResult
    {
        public double AvgTime { get; }

        public double AvgCompares { get; }

        public double AvgIterations { get; }

        public double AvgSwaps { get; }

        public TestsResult(List<TestData> tests)
        {
            if (tests == null || tests.Count == 0)
            {
                throw new ArgumentNullException("tests == null/0", nameof(tests));
            }

            double sumTime = 0;
            double sumCompares = 0;
            double sumIterations = 0;
            double sumSwaps = 0;
            for (int i = 0; i < tests.Count; i++)
            {
                sumTime += tests[i].Time;
                sumCompares += tests[i].Compares;
                sumIterations += tests[i].Iterations;
                sumSwaps += tests[i].Swaps;
            }
            AvgTime = sumTime / tests.Count;
            AvgCompares = sumCompares / tests.Count;
            AvgIterations = sumIterations / tests.Count;
            AvgSwaps = sumSwaps / tests.Count;
        }

        public override string ToString()
        {
            return $"Average results:\nTime - {AvgTime}, compares - {AvgCompares}, iterations - {AvgIterations}, swaps - {AvgSwaps}\n";
        }
    }
}
