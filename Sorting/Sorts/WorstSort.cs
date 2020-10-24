using System;
using System.Collections.Generic;

namespace Sorting.Sorts
{
    /// <summary>
    /// Просто сравнивание соседних элементов n*n раз
    /// </summary>
    public class WorstSort<T> : SortAlgorithm<T> where T : IComparable
    {
        public WorstSort(List<T> arr) : base(arr) { }

        protected override void SortArray()
        {
            if (Properties.ShowLists)
            {
                ShowArray();
            }

            int count = Arr.Count;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                    {
                        Swap(j, j + 1);
                    }
                    Compares++;
                }
                Iterations++;

                if (Properties.ShowLists)
                {
                    ShowArray();
                }
            }
        }
    }
}
