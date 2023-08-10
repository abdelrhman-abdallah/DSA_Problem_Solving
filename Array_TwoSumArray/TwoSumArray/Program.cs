
int[] array = new int[] { -1, 7, 8, 23, 22, 11, 2 };
static int[] TwoNumberSum(int[] array, int targetSum)
    {
        Hashtable valueStore = new Hashtable();

        for (int i = 0; i < array.Length; i++)
        {
            int missingValue = targetSum - array[i];
            if (valueStore.ContainsKey($"{missingValue}"))
            {
                return new int[] { missingValue, array[i] };
            }
            else
            {
                valueStore.Add($"{array[i]}", true);
            }
        }
        return new int[0];
    }

TwoNumberSum(array, 10);