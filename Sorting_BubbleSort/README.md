# Short Intro

This Problem wants to sort the input array using the Bubble Sort Technique.

For Example:

input array = [8,5,2,9,5,6,3]
sequence = [2,3,5,5,6,8,9]

# Simple walk through:

- Bubble Sort Algorithm:

  - Bubble Sort works by repeatedly stepping through the array, comparing adjacent elements, and swapping them if they are in the wrong order (e.g., when sorting ascendingly, swapping if the current element is larger than the next one).
  - This process is repeated until the entire array is sorted.
  - After each pass, the largest unsorted element "bubbles up" to its correct position, similar to bubbles rising to the surface of a liquid.

- Optimization:

  - To optimize Bubble Sort, we can introduce a flag that tracks whether any swaps occurred during a pass.
  - If no swaps are made in a pass, the array is already sorted, and we can break out of the loop early.

- Time Complexity and Space Complexity:

  - Time Complexity: O(N^2), where N is the length of the array. In the worst case, the algorithm needs to compare and swap elements in each pass for every element in the array.
  - Space Complexity: O(1), because the algorithm sorts the array in place without requiring additional memory proportional to the size of the input.
