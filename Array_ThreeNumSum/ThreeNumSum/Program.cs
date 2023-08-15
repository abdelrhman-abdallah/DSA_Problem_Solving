

int[] ints= new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
int target = 0;

static List<int[]> ThreeNumberSum(int[] array, int targetSum)
    {
        List<int[]> threeNumSum = new List<int[]>();
        int leftIdx = 0;
        int rightIdx = 0;
        Array.Sort(array);

        for (int i = 0; i < array.Length; i++)
        {
            if (i + 1 >= array.Length)
            {
                leftIdx = -1;
            }
            else 
            {
                leftIdx = i + 1;
            }
            rightIdx = array.Length - 1;
            while (leftIdx != -1 && leftIdx < rightIdx)
            {
                int currentSum = array[i] + array[leftIdx] + array[rightIdx];
                if (currentSum == targetSum)
                {
                    int[] triplet = new int[] { array[i] , array[leftIdx] , array[rightIdx] };
                    threeNumSum.Add(triplet);
                    rightIdx--;
                }
                else if (currentSum > targetSum)
                {
                    rightIdx -- ;
                }
                else
                {
                    leftIdx ++;
                }
            }
        }
        return threeNumSum;
    }

ThreeNumberSum(ints, target);