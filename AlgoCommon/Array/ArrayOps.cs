using System;

namespace AiDriven.AlgoCommon.Array
{
    public static class ArrayOps
    {
        /// <summary>
        ///  Given a sorted array, remove the duplicates in place such that each element appear only once
        ///  and return the new length.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int RemoveDups(int[] array)
        {
            if (array == null)
            {
                return 0;
            }

            if (array.Length == 1)
            {
                return 1;
            }

            int currentIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[currentIndex] != array[i])
                {
                    array[++currentIndex] = array[i];
                }
            }
            return ++currentIndex;
        }


        /// <summary>
        ///  numbers on the row below.
        /// For example, given the following triangle
        /// [
        ///     [2],
        ///    [3,4],
        ///   [6,5,7],
        ///  [4,1,8,3]
        // ]
        //The minimum path sum from top to bottom is 11 (i.e., 2 + 3 + 5 + 1 = 11).
        //Note: Bonus point if you are able to do this using only O(n) extra space, where n is the total number of
        //rows in the triangle.
        /// </summary>
        /// <param name="triangle"></param>
        /// <returns></returns>
        public static int FindTriangleMinimumPathSum(int[][] triangle)
        {
            // no parameter validation to save time, assuming parameter is a valid triangle
            int numberOfRolws = triangle.Length;

            int currentPathSum = triangle[0][0];
            for (int i = triangle.Length-2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }

            return triangle[0][0];
        }
    }
}
