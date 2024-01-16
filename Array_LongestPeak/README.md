# Short Intro:

This problem wants us to find the length of the longest peak.
A peak is defined as the tip of the strictly increasing range before it and a strictly decreasing range after it

For example:

[1,2,3,3,4,0,10,6,5,-1,-3,2,3]

solution: 6

the problem wants us to make a function that should return an int that has the length of the longest peak.
notice that to form a peak at least 3 numbers are required.

# Simple walk through:

## Two Pointer Solution (Recommended):

- initialize longestPeakLength to 0 to keep track of the longest peak length found.
- Start iterating through the array from index 1 (i = 1).
- Check if the current element array[i] is a peak by comparing it with its neighbors (array[i-1] and array[i+1]).
- If it's not a peak, continue to the next element.
- If it's a peak, we have a potential peak. Expand the peak to the left and right by finding the left and right boundaries of the peak:
  - Move leftIdx to the left while the elements are strictly decreasing.
  - Move rightIdx to the right while the elements are strictly decreasing.
  - Calculate the current peak length as rightIdx - leftIdx + 1.
  - Update longestPeakLength if the current peak length is greater.
  - Set i to the right boundary of the peak (i = rightIdx) to continue searching for the next potential peak.
- Repeat the previous steps until the end of the array is reached.
- Return longestPeakLength as the result.
- Time complexity: O(N), space complexity: O(1) Where N is the total number of elements in the input array.
