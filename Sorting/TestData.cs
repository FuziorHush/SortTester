using System;
using System.Collections.Generic;

namespace Sorting
{
    public class TestData
    {
        public double Time { get; }

        public int Compares { get; }

        public int Iterations { get; }

        public int Swaps { get; }

        public TestData(double time, int compares, int iterations, int swaps) {
            if (time < 0) {
                throw new ArgumentException("Time can't be less than 0", nameof(time));
            }
            if (compares < 0)
            {
                throw new ArgumentException("Compares amout can't be less than 0", nameof(time));
            }
            if (iterations < 0)
            {
                throw new ArgumentException("Iterations amout can't be less than 0", nameof(iterations));
            }
            if (swaps < 0)
            {
                throw new ArgumentException("Swaps amout can't be less than 0", nameof(swaps));
            }

            Time = time;
            Compares = compares;
            Iterations = iterations;
            Swaps = swaps;
        }

        public override string ToString()
        {
            return $"Time - {Time}, compares - {Compares}, iterations - {Iterations}, swaps - {Swaps}";
        }
    }
}
