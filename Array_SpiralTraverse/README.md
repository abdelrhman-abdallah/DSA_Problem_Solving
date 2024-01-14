# Short Intro:

This problem involves traversing a given `n x m` matrix in a spiral order, starting from the top-left corner and moving clockwise.

For example:

[
[1,2,3,4],
[12,13,14,5],
[11,16,15,6],
[10,9,8,7],
]

solution: [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16]

the problem wants us to make a function that should return a one dimensional array having all the matrix's elements traversed in a spiral order.

# Simple walk through:

## Using Layer Iteration [Traversing the Perimeter] (recommended approach):

- Keep four pointer that define the perimeter of the matrix: rowStart, rowEnd, colStart, and colEnd.
- Then we traverse the matrix as follows:
  - Traverse the top row from colStart to colEnd.
  - Traverse the rightmost column from rowStart + 1 to rowEnd.
  - Traverse the bottom row from colEnd - 1 to colStart if rowStart is not equal to rowEnd.
  - Traverse the leftmost column from rowEnd - 1 to rowStart + 1 if colStart is not equal to colEnd.
  - We then redefine our perimeter by shrinking it inwards (rowStart +1, rowEnd -1, colStart +1, colEnd -1) and repeat.

### We must handle the edge case where the shrinked perimeter is a single row or a single column, so that we don't double traverse them

- Time complexity: O(N), space complexity: O(N) Where N is the total number of elements in the matrix.
