using System;
using System.Collections.Generic;

namespace Sorting.Sorts
{
    public class CocktailSort<T> : SortAlgorithm<T> where T : IComparable
    {
        public CocktailSort(List<T> arr) : base(arr) { }

        protected override void SortArray()
        {
            if (Properties.ShowLists)
            {
                ShowArray();
            }

            int left = 0;
            int right = Arr.Count - 1;

            while (left < right)
            {
                int swaps = Swaps;

                for (int i = left; i < right; i++)
                {
                    if (Arr[i].CompareTo(Arr[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                    Compares++;
                }
                Iterations++;
                right--;

                if (Properties.ShowLists)
                {
                    ShowArray();
                }

                if (swaps == Swaps)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Arr[i].CompareTo(Arr[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                    }
                    Compares++;
                }
                Iterations++;
                left++;

                if (Properties.ShowLists)
                {
                    ShowArray();
                }

                if (swaps == Swaps)
                {
                    break;
                }
            }
        }
    }
}