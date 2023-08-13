
int[,] matrix = new int[,] { {1,2,3 }, {4,5,6 }, {7,8,9 } }; 

static int[,] TransposeMatrix(int[,] matrix)
{
        int rowCount = matrix.GetLength(0);
        int columnCount = matrix.GetLength(1);
        int[,] transMatrix = new int[columnCount, rowCount];
        for (int col = 0; col < transMatrix.GetLength(1); col++)
        {
            for (int row = 0; row < transMatrix.GetLength(0); row++)
            {
                transMatrix[row, col] = matrix[col, row];
            }
        }
        return transMatrix;
}

TransposeMatrix(matrix);

