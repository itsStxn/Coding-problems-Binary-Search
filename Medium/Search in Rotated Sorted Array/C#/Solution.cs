using System;

namespace Search_in_Rotated_Sorted_Array;

public class Solution {
	public int Search(int[] nums, int target) {
		int left = 0;
		int right = nums.Length - 1;
		int minIdx = FindMinimum(nums);

		if (minIdx > 0) {
			if (nums[left] <= target && target <= nums[minIdx - 1])
				right = minIdx - 1;
			else left = minIdx;
		}

		while (left <= right) {
			int mid = left + (right - left) / 2;
			if (target < nums[mid])
				right = mid - 1;
			else if (target > nums[mid])
				left = mid + 1;
			else
				return mid;
		}

		return -1;
	}

	public int FindMinimum(int[] nums) {
		int left = 0;
		int right = nums.Length - 1;

		while (left < right) {
			int mid = left + (right - left) / 2;
			if (nums[mid] > nums[right])
				left = mid + 1;
			else
				right = mid;
		}

		return left;
	}
}
