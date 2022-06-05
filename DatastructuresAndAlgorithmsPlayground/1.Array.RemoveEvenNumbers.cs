namespace DatastructuresAndAlgorithmsPlayground
{
    internal static class RemoveEvenNumbersInArray
    {
        public static int[] RemoveEvenNumbers(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int index = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0) { 
                    result[index] = numbers[i];
                    index++;    
                }
            }
            return result;
        }
    }
}
