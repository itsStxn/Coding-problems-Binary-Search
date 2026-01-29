using System;

namespace Search_a_2D_Matrix;

public class Solution {
	public bool SearchMatrix(int[][] matrix, int target) {
		int n = matrix[0].Length;
		int m = matrix.Length;

		int left = 0, right = m * n;
		while (left <= right) {
			int mid = left + (right - left) / 2;
			int row = mid / n;
			int col = mid % n;

			if (target < matrix[row][col])
				right = mid - 1;
			else if (target > matrix[row][col])
				left = mid + 1;
			else
				return true;
		}

		return false;
	}
}
