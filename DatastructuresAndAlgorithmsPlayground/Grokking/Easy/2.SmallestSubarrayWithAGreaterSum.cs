using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Grokking.Easy
{
    public class SmallestSubarrayWithAGreaterSum
    {
        private static IEnumerable<int[]> FindSmallestSubArrayWithAGreaterSum(int[] arr, int k, int sum)
        {
            int p1,p2, resetIndex, internalSum;
            p1 = p2 = resetIndex = internalSum = 0;

            while (p1 != arr.Length)
            {
                internalSum += arr[p1++];
                if (resetIndex == (k - 1))
                {
                    if (internalSum >= sum)
                    {
                        yield return new[] { p2, p1 };
                    }
                    internalSum -= arr[p2++];
                    resetIndex--;                   
                }
                resetIndex++;
            }
        }

        public static IEnumerable<int[]> GetContiguousSubArray(int[] arr, int k, int sum)
        {
            IEnumerable<int[]> bounds = FindSmallestSubArrayWithAGreaterSum(arr, k, sum);
            return bounds;
        }

        public static void ExecuteTests()
        {
            int[] arr = new int[] { 2, 1, 5, 2, 8 };
            int sum = 7;
            IEnumerable<int[]> bounds = GetContiguousSubArray(arr, 1, sum);
            Console.WriteLine("================================");
            foreach (var bound in bounds)
                PrintDetails(bound, arr, sum);

            arr = new int[] { 2, 1, 5, 2, 3, 2 };
            sum = 7;
            bounds = GetContiguousSubArray(arr, 2, sum);
            Console.WriteLine("================================");
            foreach (var bound in bounds)
                PrintDetails(bound, arr, sum);

            arr = new int[] { 3, 4, 1, 1, 6 };
            sum = 8;
            bounds = GetContiguousSubArray(arr, 3, sum);
            Console.WriteLine("================================");
            foreach (var bound in bounds)
                PrintDetails(bound, arr, sum);
        }

        private static void PrintDetails(int[] bounds, int[] arr, int maxSum)
        {
            int lowerBound = bounds[0];
            int upperBound = bounds[1];
            Console.WriteLine("Contiguous Array");
            if (upperBound == arr.Length && (upperBound - lowerBound) == 1)
                Console.Write(arr[upperBound - 1]);
            else
            {
                for (int i = lowerBound; i < upperBound; i++)
                    Console.Write(arr[i] + ",");
            }
            Console.WriteLine();
            Console.WriteLine("Maximum Sum " + maxSum);
        }
    }
}
