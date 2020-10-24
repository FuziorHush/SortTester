using System;
using System.Collections.Generic;

namespace Sorting.Sorts
{
    public class ShellSort<T> : SortAlgorithm<T> where T : IComparable
    {
        public ShellSort(List<T> arr) : base(arr) { }

        protected override void SortArray()
        {
            if (Properties.ShowLists)
            {
                ShowArray();
            }

            int step = Arr.Count / 2;

            while (step > 0) {
                for (int i = step; i < Arr.Count; i++) {
                    int j = i;
                    while (j >= step && Arr[j - step].CompareTo(Arr[j]) == 1) {
                        Swap(j - step, j);
                        j -= step;

                        Compares++;
                    }
                    Iterations++;

                    if (Properties.ShowLists)
                    {
                        ShowArray();
                    }
                }

                step /= 2;
            }
        }
    }
}
