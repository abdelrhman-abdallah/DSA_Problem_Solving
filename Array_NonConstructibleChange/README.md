# Short Intro

This Problem wants to find the minimum amount of change that cannot be created from the given input array which represents coins, so it will be only consist of positive integers.

For Example:

coins = [5,7,1,1,2,3,22]
answer = 20

# Simple walk through:

- Basic Thoughts and Brainstorming:

- If the given array is empty, the least amount of change we can't produce is 1.
- If we Find that the first element - supposing that the Coins Array is Sorted Ascendingly - isn't 1, then we return 1.
- So we sort the Coins Array in ascending order:

  - Check if the first value in the Coins array is greater than 1:
    - If yes, return 1.
    - If no, proceed with further analysis.

- Analysis of Coin Array:

  - If the array consists of consecutive positive integers starting from 1 (e.g., [1, 2, 3, ...]), the minimum change we can't produce will be the sum of all elements + 1.
    - For example, if the array is [1,2,3,7], the minimum change is 15 (1 + 2 + 3 + 7 + 1).
    - But if the array consisted of [1,2,3,8] then the minimum amount of change we can't produce will be 7.
    - This is because of the follwing:
      - If the element if larger than the sum of all the previous elements +1.
      - Then the minimum change that can't be created will be the sum of all previous elements +1, in this case (1 + 2 + 3 + 1) = 7.

- Time and Space Complexity:
  - The solution has a Time Complexity of O(N Log N), where N is the length of the Coins array, As we first sort the Coins array, and even the most optimal sorting algorithms like QuickSort and MergeSort takes Big O(N Log N) time to run.
  - The Space Complexity is O(1) because no additional space is used beyond the given Coins array.

This approach efficiently calculates the minimum amount of change that cannot be produced using the provided coin denominations. It covers both cases where the coin array starts with 1 and where it does not, providing an effective solution with linear time complexity.
