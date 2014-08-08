using System;
using System.Collections.Generic;

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
            for (int i = triangle.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }

            return triangle[0][0];
        }

        public static List<KeyValuePair<int, int>> TwoSum(int[] array, int target)
        {
            List<KeyValuePair<int, int>> results = new List<KeyValuePair<int, int>>();
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();


            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(target - array[i]))
                {
                    results.Add(new KeyValuePair<int, int>(array[i], target - array[i]));
                    if (dict[target - array[i]].Count == 1)
                    {
                        dict.Remove(target - array[i]);
                    }
                    else
                    {
                        dict[target - array[i]].RemoveAt(0);
                    }
                }
                else
                {
                    if (!dict.ContainsKey(array[i]))
                    {
                        dict.Add(array[i], new List<int>());
                    }
                    dict[array[i]].Add(i);
                }
            }
            return results;
        }


        public static List<int[]> ThreeSum(int[] array, int target)
        {
            List<int[]> result = new List<int[]>();
            System.Array.Sort(array);

            for (int i = 0; i < array.Length - 2; i++)
            {
                if (i == 0 || array[i] != array[i - 1])
                {
                    int startIndex = i + 1;
                    int endIndex = array.Length - 1;

                    while (startIndex < endIndex)
                    {

                        if (array[startIndex] + array[endIndex] + array[i] == target)
                        {
                            result.Add(new[] { array[i], array[startIndex], array[endIndex] });
                            startIndex++;
                            endIndex--;

                            while (startIndex < endIndex && array[endIndex] == array[endIndex + 1])
                            {
                                endIndex--;
                            }
                            while (startIndex < endIndex && array[startIndex] == array[startIndex - 1])
                            {
                                startIndex++;
                            }
                        }
                        else if (array[startIndex] + array[endIndex] + array[i] < target)
                        {
                            startIndex++;
                        }
                        else
                        {
                            endIndex--;
                        }
                    }
                }

            }


            return result;
        }
    }
}
