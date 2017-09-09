namespace Solutions
{
    public class AdjacentElements
    {
        public int AdjacentElementsProduct(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 1)
                return 0;

            if (inputArray.Length == 2)
                return inputArray[0] * inputArray[1];
                
            int firstIndex = 0;
            int secondIndex = 1;
            int max = int.MinValue;
            while (secondIndex + 1 <= inputArray.Length)
            {
                
                int tmax = inputArray[firstIndex] * inputArray[secondIndex];
                if (tmax > max)
                    max = tmax;
                firstIndex++;
                secondIndex++;
            }
            return max;
        }
    }
}