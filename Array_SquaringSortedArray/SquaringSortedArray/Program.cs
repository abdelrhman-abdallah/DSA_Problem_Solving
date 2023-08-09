int[] inputArray = new int[] { -6, 2, 3, 5, 6, 8, 9 };
 
static List<int> SortedSquaredArray(int[] array)
    {
        List<int> outputArray = new List<int>();
        int positionStart = 0;
        int positionEnd = array.Length - 1;
        while (positionStart <= positionEnd)
        {
            int minValCurrently = array[positionStart];
            int maxValCurrently = array[positionEnd];
            if (Math.Abs(maxValCurrently) > Math.Abs(minValCurrently))
            {
                positionEnd--;
                maxValCurrently *= maxValCurrently;
                outputArray.Insert(0, maxValCurrently);

            }
            else
            {
                positionStart++;
                minValCurrently *= minValCurrently;
                outputArray.Insert(0, minValCurrently);
            }
        }
        return outputArray;
    }



SortedSquaredArray(inputArray);