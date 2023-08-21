﻿
int[] inputArray = new int[] { -1, -5, -5, -5, -5, -10, -9000, -99901 }; 

static bool IsMonotonic(int[] array)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;
        if (array.Length <= 2)
        {
            return true;
        }
        else
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) { isIncreasing = false; }
                if (array[i] > array[i - 1]) { isDecreasing = false; }
            }
            return isIncreasing || isDecreasing;
        }
    }


IsMonotonic(inputArray);