using System;

namespace Algorithms.Grokking.Easy
{
    public static class MaximumSumOfSubArrayOfSizeK
    {
        private static int FindMaxSumOfContiguousArray(int[] arr, int k, out int startIndexOfSubArray)
        {
            startIndexOfSubArray = 0;
            int p1 = 0, p2 = 0;
            int sum = 0;
            int resetIndex = 0;
            int maxSum = int.MinValue;
            while (p1 != arr.Length - 1)
            {
                sum += arr[p1++];
                if (resetIndex == k - 1)
                {
                    if (sum > maxSum)
                    {
                        startIndexOfSubArray = p2;
                        maxSum = sum;
                    }
                    sum -= arr[p2++];
                    resetIndex -= 1;
                }
                resetIndex++;
            }
            return maxSum;
        }

        public static int[] GetMaxSumContigousArray(int[] arr, int k, out int maxSum)
        {
            int startIndexOfSubArray;
            maxSum = FindMaxSumOfContiguousArray(arr, k, out startIndexOfSubArray);
            int[] contiguousArray = arr[startIndexOfSubArray..(startIndexOfSubArray + k)];
            return contiguousArray;
        }

        public static void ExecuteTests()
        {
            int maxSum;
            int[] contiguousArray = { 2, 1, 5, 1, 3, 2 };
            int subArraySize = 3;
            contiguousArray = GetMaxSumContigousArray(contiguousArray, subArraySize, out maxSum);
            PrintDetails(contiguousArray, maxSum);

            contiguousArray = new int[] { 2, 3, 4, 1, 5 };
            subArraySize = 2;
            contiguousArray = GetMaxSumContigousArray(contiguousArray, subArraySize, out maxSum);
            PrintDetails(contiguousArray, maxSum);
        }

        private static void PrintDetails(int[] array, int maxSum)
        {
            Console.WriteLine("Contiguous Array");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + ",");
            Console.WriteLine();
            Console.WriteLine("Maximum Sum " + maxSum);
        }
    }
}
