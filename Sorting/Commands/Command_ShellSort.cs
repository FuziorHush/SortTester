using System;
using System.Collections.Generic;
using Sorting.Sorts;

namespace Sorting.Commands
{
    class Command_ShellSort : ICommand
    {
        public void Execute()
        {
            Sort();
            GC.Collect();
        }

        private void Sort()
        {
            List<TestData> tests = new List<TestData>();
            for (int i = 0; i < Properties.TestsAmout; i++)
            {
                SortAlgorithm<int> _shellSort = new ShellSort<int>(ListFactory.GetRandomListInt(Properties.ListCount, Properties.MaxValue));
                tests.Add(_shellSort.StartTest());
                if (Properties.ShowLists)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine(new TestsResult(tests).ToString());
        }

        public override string ToString()
        {
            return "Shell's sort";
        }
    }
}
