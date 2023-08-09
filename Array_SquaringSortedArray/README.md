# Short Intro

This Problem wants to take in an array of integers (positive or negative) and that array is sorted in ascending order, and it wants us to square the entire array (each element is squared) and that squared array must also be sorted in ascending order.

For Example:

input array = [1,2,3,5,6,8,9]
result = [1,4,9,25,36,64,81]

# Simple walk through:

- Main Challenge:

The primary challenge of this problem arises from the fact that even when the input numbers are sorted in ascending order, their squares may not follow the same order due to the presence of negative numbers.

- Simple Solution - Squaring and Sorting:

  - Loop through the input array.
  - Square each element and append it to a result array.
  - Perform an ascending sort on the result array.
  - Even with efficient sorting techniques like MergeSort or QuickSort, the time complexity remains O(N log(N)), where N is the length of the input array and the space complexity Big O (N).

- Optimized Solution - Linear Time Complexity:

  - To achieve linear time complexity, a better approach involves finding the positions of elements before squaring them.
  - Utilize two pointers, one at the start and one at the end of the input array.
  - Compare the absolute values of the elements pointed to by the two pointers.
  - If the absolute value of the element at the start is greater, increment the start Pointer, square it and insert the squared value at the end of the result array
  - If the absolute value of the element at the end is greater, square it and insert the squared value at the end of the result array; then decrement the end pointer.
  - Continue this process until both pointers meet.
  - The time complexity is Big O (N) and the space complexity Big O (N)

This approach correctly describes the process of squaring the values and inserting them into the result array while maintaining the sorted order. The insertion at the end of the result array ensures that the largest squared values accumulate toward the end, resulting in a properly sorted array. The time complexity of this approach remains O(N), where N is the length of the input array.
