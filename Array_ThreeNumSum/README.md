# Short Intro:

this problem wants to find all the three numbers that when added together result in a given value.

For example:

[12,3,1,2,-6,5,-8,6]

target = 0

the problem wants us to make a function that should return an list of arrays having all the triplets that give the target sum:
[ [-8,2,6], [-8,5,3], [-6,1,5] ]

# Simple walk through:

Almost Naive Solution:

- Loop through the array.
- For each next element, loop through the rest of the array again (nested loop).
- For each next element, loop through the rest of the array again (nested inside of the nested loop)
- Time complexity: O(N^3) where N is the array length, Space Complexity: O(1).
- Not efficient for most test cases.

Sort and Two Pointers Solution:

- Sort the array using advanced sorting techniques like Quicksort or Merge sort.
- loop through the array, Maintain pointers at the next value "left" and at the end "right" of the sorted array
- loop through the array while the left pointer is left than the right pointer:

  - Check the sum of current element and the elements at both pointers.
  - If smaller than the target value, increment the left pointer.
  - If larger than the target value, decrement the right pointer.
  - If equal to the target value, add it to the list of possible triplets and increment the left or decrement the right pointer.
  - Continue until u break the inner while - loop condition and then we do the same for the remaining elements.

- Time complexity: O(N ^2) Where N is the Length of the Array, Space complexity: O(N).
