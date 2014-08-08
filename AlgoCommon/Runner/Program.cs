using System;
using System.Collections.Generic;
using System.Diagnostics;
using AiDriven.AlgoCommon.Heap;

namespace AiDriven.AlgoCommon.Runner
{
    using AiDriven.AlgoCommon.Array;
    class Program
    {
        static void Main(string[] args)
        {
            //TestArrayRemoveDups();
            //TestTriangleMinPathSum();
            //TestTwoSum();
            //TestThreeSum();
            //TestMinHeap();
            TestMergeKSortedList();
        }


        public static void TestArrayRemoveDups()
        {
            int[] array = new[] { 1, 2, 2, 2, 3, 4, 5, 5, 8 };
            int length = ArrayOps.RemoveDups(array);
            Debug.Assert(length == 6);
            Debug.Assert(array[0] == 1);
            Debug.Assert(array[1] == 2);
            Debug.Assert(array[2] == 3);
            Debug.Assert(array[3] == 4);
            Debug.Assert(array[4] == 5);
            Debug.Assert(array[5] == 8);
                 
        }

        public static void TestTriangleMinPathSum()
        {
            int[][] triangle = new[]
            {
                new[] {2},
                new[] {3, 4},
                new[] {6, 5, 7},
                new[] {4, 1, 8, 3}
            };

            int result = ArrayOps.FindTriangleMinimumPathSum(triangle);
            Debug.Assert(result == 11);
        }

        public static void TestTwoSum()
        {
            var result = ArrayOps.TwoSum(new[] {-1, -1, 2, 3, 1, -2, -2, 0, 2, -3, 0, -3, 0, -2}, -3);
        }

        public static void TestThreeSum()
        {
            var result = ArrayOps.ThreeSum(new[] {-1, 0, 1, 2, -1, -4}, 0);

            result = ArrayOps.ThreeSum(new[] { 2,3, 1, -2, -1, 0, 2, -3, 0}, 0);
        }

        public static void TestMinHeap()
        {
            MinHeap<int> minHeap = new MinHeap<int>();
            minHeap.Insert(1);
            minHeap.Insert(2);
            minHeap.Insert(5);
            minHeap.Insert(4);
            minHeap.Insert(0);
            minHeap.RemoveMin();
            minHeap.RemoveMin();

        }

        public static void TestMergeKSortedList()
        {
            int[] sortedList1 = {1, 4, 8, 12, 20};
            int[] sortedList2 = { -1, 0, 1, 2};
            int[] sortedList3 = { -5, -4, -3, -2};
            int[] sortedList4 = { 0, 0, 0, 10, 21 };

            var result = ExternalSort.MergeKSortedList(new List<int[]>
            {
                sortedList1,
                sortedList2,
                sortedList3,
                sortedList4
            });
        }
    }
}
