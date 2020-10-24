using System;
using System.Collections.Generic;

namespace Sorting.Sorts
{
    public class SelectionSort<T> : SortAlgorithm<T> where T : IComparable
    {
        public SelectionSort(List<T> arr) : base(arr) { }

        protected override void SortArray()
        {
            if (Properties.ShowLists)
            {
                ShowArray();
            }

            int minID = 0;

            for (int i = 0; i < Arr.Count - 1; i++)
            {
                minID = i;

                for (int j = i + 1; j < Arr.Count; j++)
                {
                    if (Arr[j].CompareTo(Arr[minID]) == -1)
                    {
                        minID = j;
                    }
                    Compares++;
                }

                if (i != minID)
                {
                    Swap(i, minID);
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
