# Short Into:

this problem wants to find the first two numbers that when added together result in a given value.

For example:

[-1,7,8,23,22,11,2]

target = 10

the problem wants us to make a function that should return an array having two integers [-1,11]

and in the case there are no numbers that add up to the target value then we should return an empty array

# Simple walk through:

Almost Naive Solution:

- Loop through the array.
- For each element, loop through the entire array again (nested loop).
- Time complexity: O(N^2) where N is the array length.
- Not efficient for most test cases.

Sort and Two Pointers Solution:

- Sort the array using advanced sorting techniques like Quicksort or Merge sort.
- Maintain pointers at the beginning and end of the sorted array.
- Check the sum of elements at the two pointers.
- If smaller than the target value, increment the beginning pointer.
- If larger than the target value, decrement the end pointer.
- If equal to the target value, return it.
- Time complexity: O(N log N), space complexity: O(1).

- Hashtable Solution (Recommended):

- Use a hashtable (dictionary) to store seen elements.
- Loop through the array once.
- For each element, check if the target value minus the element exists in the hashtable.
- If found, return a new array containing these two elements.
- If not found, add the element to the hashtable.
- Time complexity: O(N), space complexity: O(N).
- This is the recommended solution due to its efficiency.
- Remember, the hashtable solution is the most popular and efficient approach among these options. It provides a balance between time and - space complexity, making it a suitable choice for solving the problem efficiently.
