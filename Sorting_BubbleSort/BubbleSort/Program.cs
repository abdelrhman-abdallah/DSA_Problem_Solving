
int[] inputArray = new int[] { 8, 5, 2, 9, 5, 6, 3 };
static int[] BubbleSort(int[] array)
    {
        int loopLength = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            int swapNo = 0;
            for (int j = 1; j < loopLength; j++)
            {
                if (array[j] > array[j - 1])
                {
                    continue;
                }
                else
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    swapNo++;

                }
            }
            if (swapNo == 0)
            {
                break;
            }
            else
            {
                loopLength--;
            }
        }
        return array;
    }


BubbleSort(inputArray);