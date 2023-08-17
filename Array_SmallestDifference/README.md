# Short Intro

This Problem wants to find the two numbers whose absolute difference is closest to zero, the problem gives us two array, they don't have to be of the same length and it wants us to return an array containing the two numbers whose absolute difference is equal to or closest to zero.

For Example:

input array 1 = [-1,5,10,20,28,3]
input array 2 = [26,134,135,15,17]
answer =[28,26]

# Simple walk through:

- Naive Solution:

  - Loop through the first array.
  - For each element in the first array, loop through the second array (nested loop).
  - Find all pairs of elements.
  - Return the pair that gives in the smallest absolute difference.

- Time and Space Complexity:

  - This solution has a Time Complexity of O(n^2).
  - It has a Space Complexity of O(1).

- Sorting Both Arrays and Using Two Pointers:

  - First, sort both input arrays.
  - Initialize two pointers, one at the start of the first array and another at the start of the second array.
  - Loop until both pointers reach the end of their respective arrays.
  - Calculate the absolute difference between the values pointed to by the two pointers and keep track of it.
  - If the absolute difference equals zero, return.
  - If the value at the first pointer is greater than the value at the second pointer, increment the second pointer.
  - If the value at the first pointer is less than the value at the second pointer, increment the first pointer.
  - This is because the absolute difference increases if we increment the pointer that is pointing towards a bigger value, and as both arrays are sorted we only increment the pointer pointing towards a smaller value.
  - If the absolute difference is less than the current value of the tracking variable, update the tracked pair in - the result array and the tracker variable.

- Time and Space Complexity:

  - The solution has a Time Complexity of O(N log N + M log M), where N is the length of the first input array and M is the length of the second input array.
    - This accounts for the time taken to sort both arrays using optimal sorting algorithms like QuickSort or MergeSort.
  - The Space Complexity is O(1) because no additional space is used beyond the given arrays.
