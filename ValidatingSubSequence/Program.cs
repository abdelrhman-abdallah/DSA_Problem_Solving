
List<int> inputArray = new List<int> { 5, 1, 22, 23, 6, -1, 7, 10 };
List<int> sequence = new List<int> { 1, 6, -1, 10 };

static bool IsValidSubsequence(List<int> array, List<int> sequence)
    {
        int j = 0;
        for (int i = 0; i < array.Count; i++)
        {
            if (j < sequence.Count && array[i] == sequence[j])
            {
                j++;
            }
            else
            {
                continue;
            }
        }
        if (j == sequence.Count)
        {
            return true;
        }
        return false;
    }


IsValidSubsequence(inputArray,sequence);