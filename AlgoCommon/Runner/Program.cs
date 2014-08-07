using System;
using System.Diagnostics;

namespace AiDriven.AlgoCommon.Runner
{
    using AiDriven.AlgoCommon.Array;
    class Program
    {
        static void Main(string[] args)
        {
            TestArrayRemoveDups();
            TestTriangleMinPathSum();
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
    }
}
