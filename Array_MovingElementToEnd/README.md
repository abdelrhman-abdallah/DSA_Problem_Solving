# Short Intro

This Problem wants to move all instances of a given number in the given input array towards the end of the same array.

For Example:

input array = [2,1,2,2,2,3,4,2]
valueToMove = 2
answer = [1,4,3,2,2,2,2,2]

# Simple walk through:

- Solution 1: Sorted Array Approach

  - We can first sort the array
  - We then loop through the sorted array.
  - if we find our number , then we check:

    - if the number at the last index of the now sorted array = the valueToMove.
      We are finished and can return the array.
    - else we swap that number with the number at the last index and move on until we end the loop.

  - Time and Space Complexity:
    - The solution has a Time Complexity of O(N Log N), where N is the length of the Coins array, As we first sort the Input array, and then we loop through it which take time of Big O (N), but it neglected so the final time complexity is indeed Big O(N Log N).
    - The Space Complexity is O(1) because no additional space is used beyond the given Input array.

- Solution 2: Two-Pointer Linear Scan

  - We intialize two pointers one at the start and one at the end of the array.
  - We loop though the array so long as the pointer at the start is less than the pointer at the end.
  - While the value at the end of the array = the value to move, then we decrment the end pointer.
  - After the end pointer points at a value that isn't equal to the value to move, then:

    - We check if the value at the start pointer = value to move, then we swap the values at the start and end pointers
    - else we increment the start pointer

  - Time and Space Complexity:
    - The solution has a Time Complexity of O(N), where N is the length of the Input array, As we fonly loop through the input array once.
    - The Space Complexity is O(1) because no additional space is used beyond the given Coins input array.
