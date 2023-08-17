using System;
using System.Linq.Expressions;

int [] arrayOne = new int[] {-1,5,10,20,28,3 };
int[] arrayTwo = new int[] { 26, 134, 135, 15, 17 };
    static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
    {
        int firstPointer = 0;
        int secondPointer = 0;
        int minDiff = Int32.MaxValue;
        int[] result = new int[2];

        Array.Sort(arrayOne);
        Array.Sort(arrayTwo);

        while (firstPointer < arrayOne.Length && secondPointer < arrayTwo.Length)
        {
            int firstNum = arrayOne[firstPointer];
            int secondNum = arrayTwo[secondPointer];

            int absDiff = Math.Abs(firstNum - secondNum);

            if (absDiff == 0)
            {
                return new int[] { firstNum, secondNum };
            }
            else if (firstNum < secondNum)
            {
                firstPointer += 1;
            }
            else
            {
                secondPointer += 1;
            }

            if (minDiff > absDiff)
            {
                minDiff = absDiff;
                result = new int[] { firstNum, secondNum };
            }
        }
        return result;
    }


SmallestDifference(arrayOne, arrayTwo);