# Search a 2D Matrix

## Description
You are given an `m x n` integer matrix `matrix` with the following two properties:

- Each row is sorted in non-decreasing order.
- The first integer of each row is greater than the last integer of the previous row.

Given an integer `target`, return `true` if `target` is in `matrix` or `false` otherwise.

You must write a solution in `O(log(m * n))` time complexity.

### Example 1
**Input**: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3  
**Output**: true  

### Example 2
**Input**: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13  
**Output**: false  

### Constraints
m == `matrix.length`  
n == `matrix[i].length`  
1 <= `m`, `n` <= 100  
-104 <= `matrix[i][j]`, `target` <= 10^4


## Strategy
The matrix's property allow it to be considered as one single array made of all the matrix's rows. Perform binary search, but divide the middle index point by `n` to get the actual row in the matrix and do modulo `n` to get the actual column.

## Time Complexity - O(log(m * n))
It is the time complexity of binary seach throughout an array of `m * n` elements

## Space Complexity - O(1)
No data structures of `n` size are implemented.
