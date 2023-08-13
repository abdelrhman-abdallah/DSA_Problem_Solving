
int[] arr = new int[] { 5, 7, 1, 1, 2, 3, 22 };

static int NonConstructibleChange(int[] coins)
{
        int minChange = 1;

        if (coins.Length == 0)
        {
            return minChange;
        }

        else
        {
            Array.Sort(coins);

            if (coins[0] != 1)
            {
                return minChange;
            }

            else
            {
                int largestSum = 0;

                foreach (var coin in coins)
                {
                    if (coin > largestSum + 1)
                    {
                        minChange = largestSum + 1;
                        return minChange;
                    }
                    else
                    {
                        largestSum += coin;
                    }
                }

                minChange = largestSum + 1;
                return minChange;
            }
        }
}

NonConstructibleChange(arr);
