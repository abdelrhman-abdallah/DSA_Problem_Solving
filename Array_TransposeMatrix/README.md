# Short Intro

This Problem wants to returnthe transpose of the given matrix (2D array), the transpose of a matrix is the same elements of the original array but the rows of the matrix become the columns of the transpose matrix

For Example:

Matrix = [
[1,2,3],
[4,5,6],
[7,8,9]
]
answer = [
[1,4,7],
[2,5,8],
[3,6,9]
]

# Simple walk through:

- Transpose Matrix Calculation:

  - Create a 2-dimensional array to represent the transpose of the given matrix.
  - Set the dimensions (height and width) of the transpose matrix to match the dimensions of the original matrix.
  - Iterate through the length of the transpose matrix (same as the given matrix).
  - For each iteration, iterate through the width of the transpose matrix.
  - Inside the nested loop:
    - Assign the value of the element at the current row and column in the transpose matrix to the value at the corresponding column and row in the original matrix:
      - transposeMatrix[row, col] = matrix[col, row]
      - This ensures that the rows in the original matrix become columns in the transpose matrix.

- Time and Space Complexity:

  - This solution has a time complexity of O(l \* w), where l is the length and w is the width of the matrix.
  - It also requires a space complexity of O(l \* w) because a 2-dimensional array is used to store the transpose of the matrix.
