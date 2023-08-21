# Short Intro

This problem wants to check whether the given input array is monotonic or not, an array is said to be monotonic all of its elements are either entirley increasing or entirley decreasing.

For Example:

input array = [-1,-5,-10,-20,-28,-100,-800,-1000]
answer = true

# Simple walk through:

- Linear Scan:

  - We intialize two boolean values, isIncreasing and isDecreasing with true.
  - We can loop through the array so as long as its length is greater than 2.
  - As if the array's length is 2 or less it is momotonic no matter what.
  - we start our loop at the 2nd element and compare it to element before.
  - If the current element is greater than the previous element then isDecreasing is false
  - Else isIncreasing is false.
  - If any of the two bools is still true after the loop then the array is monotonic.

- Time and Space Complexity:

  - This solution has a Time Complexity of O(n).
  - It has a Space Complexity of O(1).
