# Search In Rotated Sorted Array

## Description
There is an integer array `nums` sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly left rotated at an unknown index `k (1 <= k < nums.length)` such that the resulting array is `[nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]]` (0-indexed). For example, `[0,1,2,4,5,6,7]` might be left rotated by 3 indices and become `[4,5,6,7,0,1,2]`.

Given the array `nums` after the possible rotation and an integer `target`, return *the index of `target` if it is in `nums`, or -1 if it is not in `nums`*.

You must write an algorithm with `O(log n)` runtime complexity.

### Example 1
**Input**: nums = [4,5,6,7,0,1,2], target = 0  
**Output**: 4  

### Example 2
**Input**: nums = [4,5,6,7,0,1,2], target = 3  
**Output**: -1  

### Example 3
**Input**: nums = [1], target = 0  
**Output**: -1  

### Constraints
1 <= `nums.length` <= 5000  
-10^4 <= `nums[i]` <= 10^4  
All values of nums are unique.  
`nums` is an ascending array that is possibly rotated.  
-10^4 <= `target` <= 10^4

## Strategy
First off, find the index of the smallest value in the array. There are 2 halves around that smallest value.

Then modify the value of `left` and `right` after identifying 3 use cases:
- If the smallest value has index 0, then set `left` as 0 and `right` as the last index
- If the target is in the first half, then set `left` as 0 and `right` as the last index of the first half
- Otherwise, set left as the smallest index and `right` as last index

The run a normal binary search.

## Time Complexity - O(log n)
A binary search is used to find the smallest index, and another binary search is used to find the the target.

## Space Complexity - O(1)
No additional data structures of `n` size are used.
