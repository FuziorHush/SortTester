using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Sorting.Sorts
{
    public abstract class SortAlgorithm<T> where T : IComparable
    {
        protected List<T> Arr;

        protected int Compares;
        protected int Iterations;
        protected int Swaps;

        public SortAlgorithm(List<T> arr)
        {
            Arr = arr;
        }

        protected void Swap(int posA, int posB)
        {
            T tmp = Arr[posA];
            Arr[posA] = Arr[posB];
            Arr[posB] = tmp;

            Swaps++;
        }

        /// <summary>
        /// Выполняет сортировку и генерирует отчет
        /// </summary>
        /// <returns>Отчет о сортировке</returns>
        public TestData StartTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SortArray();
            stopwatch.Stop();

            return new TestData(stopwatch.ElapsedMilliseconds, Compares, Iterations, Swaps);
        }

        protected abstract void SortArray();

        protected void ShowArray()
        {
            for (int i = 0; i < Arr.Count; i++)
            {
                Console.Write(Arr[i].ToString() + " ");
            }
            Console.WriteLine();
        }
    }
}
