using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AiDriven.AlgoCommon.Heap;

namespace AiDriven.AlgoCommon
{
    public static class ExternalSort
    {
        public static List<int> MergeKSortedList(List<int[]> sortedArrays)
        {
            int k = sortedArrays.Count;
            List<int> result = new List<int>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
            int[] currentIndices = new int [sortedArrays.Count];

            MinHeap<int> minHeap = new MinHeap<int>();
            for (int i = 0; i < sortedArrays.Count; i++)
            {
                dict.Add(sortedArrays[i][0], new List<int>{i});
                currentIndices[i] = 1;
                minHeap.Insert(sortedArrays[i][0]);
            }

            while (minHeap.Count > 0)
            {
                int currentMin = minHeap.RemoveMin();
                int fromList = dict[currentMin][0];

                result.Add(currentMin);
                dict[currentMin].RemoveAt(0);
                if (dict[currentMin].Count == 0)
                {
                    dict.Remove(currentMin);
                }
                
                if (currentIndices[fromList] < sortedArrays[fromList].Length)
                {
                    var value = sortedArrays[fromList][currentIndices[fromList]];
                    minHeap.Insert(value);
                    if (!dict.ContainsKey(value))
                    {
                        dict.Add(value, new List<int>());
                    }
                    dict[value].Add(fromList);
                }

                currentIndices[fromList]++;
            }

            return result;
        }
    }
}
