# Binary Search

## Description
Given an array of integers `nums` which is sorted in ascending order, and an integer `target`, write a function to search `target` in `nums`. If `target` exists, then return its index. Otherwise, return -1.

You must write an algorithm with `O(log n)` runtime complexity.

### Example 1
**Input**: nums = [-1,0,3,5,9,12], target = 9  
**Output**: 4  
**Explanation**: 9 exists in nums and its index is 4  

### Example 2
**Input**: nums = [-1,0,3,5,9,12], target = 2  
**Output**: -1  
**Explanation**: 2 does not exist in nums so return -1  

### Constraints
- 1 <= `nums.length` <= 10^4
- -104 < `nums[i]`, `target` < 10^4
- All the integers in nums are unique.
- `nums` is sorted in ascending order.

## Strategy
Use two pointers, left and right, since the array is sorted. Find the middle index between them.  
If the target equals the middle value, return that index.

If the target is greater than the middle value, move the left pointer to mid + 1; otherwise, move the right pointer to mid − 1.

## Time Complexity - O(log n)
Each possible half of nodes is discarded following a binary desicion.

## Space Complexity - O(1)
No data structures of `n` size are used.
