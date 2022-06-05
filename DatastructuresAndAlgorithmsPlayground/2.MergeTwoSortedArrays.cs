namespace DatastructuresAndAlgorithmsPlayground
{
    internal static class MergeTwoSortedArrays
    {



        public static int[] MergeSortedArrays(int[] sortedArray1, int[] sortedArray2)
        {
            int[] results = new int[sortedArray1.Length + sortedArray2.Length];

            int index = 0;
            for(int i = 0; i < sortedArray1.Length; i++)
            {
                for (int j = 0; j < sortedArray2.Length; j++)
                {
                    results[index] = sortedArray1[i] <= sortedArray2[j] ? sortedArray1[i] : sortedArray2[j];                    
                }
            }

            int minArray1 = sortedArray1 [0];
            int maxArray1 = sortedArray1 [sortedArray1.Length - 1];

            int minArray2 = sortedArray2[0];
            int maxArray2 = sortedArray2[sortedArray2.Length - 1];

            results[0] = minArray1 < minArray2 ? minArray1 : minArray2;
            results[results.Length - 1] = maxArray1 > maxArray2 ? maxArray1 : maxArray2;
            return results;
        }
    }
}
