using System;
using System.Collections.Generic;

namespace Sorting
{
    class ListFactory
    {
        static Random r = new Random();

        public static List<int> GetRandomListInt(int listCount, int maxValue) {
            List<int> list = new List<int>();
            for (int i = 0; i < listCount; i++) {
                list.Add(r.Next(maxValue+1));
            }
            return list;
        }
    }
}
