using System.Collections.Generic;

public partial class Solution
{
    public void Rotate(int[][] matrix)
    {
        List<List<int>> newMatrix = new List<List<int>>();
        for (int i = 0;i<matrix.Length;i++)
        {
            newMatrix.Add(new List<int>());
            for (int j = 0; j < matrix[i].Length; j++)
            {
                newMatrix[i].Add(matrix[matrix.Length - i - 1][j]);
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = newMatrix[j][i];
            }
        }
    }
}