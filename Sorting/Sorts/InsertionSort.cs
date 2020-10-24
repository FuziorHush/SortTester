using System;
using System.Collections.Generic;

namespace Sorting.Sorts
{
    public class InsertionSort<T> : SortAlgorithm<T> where T : IComparable
    {
        public InsertionSort(List<T> arr) : base(arr) { }

        protected override void SortArray()
        {
            if (Properties.ShowLists)
            {
                ShowArray();
            }

            for (int i = 1; i < Arr.Count; i++) {
                T temp = Arr[i];
                int j = i;
                while (j > 0 && temp.CompareTo(Arr[j - 1]) == -1) {
                    Arr[j] = Arr[j - 1];
                    j--;
                    Swaps++;
                    Compares++;
                }
                Arr[j] = temp;
                Iterations++;

                if (Properties.ShowLists)
                {
                    ShowArray();
                }
            }
        }
    }
}
