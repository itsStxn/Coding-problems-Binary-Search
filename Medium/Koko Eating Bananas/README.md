# Koko Eating Bananas

## Description
Koko loves to eat bananas. There are `n` piles of bananas, the `i^th` pile has `piles[i]` bananas. The guards have gone and will come back in h hours.

Koko can decide her bananas-per-hour eating speed of `k`. Each hour, she chooses some pile of bananas and eats `k` bananas from that pile. If the pile has less than `k` bananas, she eats all of them instead and will not eat any more bananas during this hour.

Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

Return *the minimum integer `k` such that she can eat all the bananas within h hours*.

### Example 1
**Input**: piles = [3,6,7,11], h = 8  
**Output**: 4  

### Example 2
**Input**: piles = [30,11,23,4,20], h = 5  
**Output**: 30  

### Example 3
**Input**: piles = [30,11,23,4,20], h = 6  
**Output**: 23  

### Constraints
1 <= `piles.length` <= 10^4  
`piles.length` <= `h` <= 10^9  
1 <= `piles[i]` <= 10^9  

## Strategy
Write a function to determine if a `k` value is valid. THe function goes over `piles` and calculates the sum of all the hours needed to clear each pile. If the sum is less or equal to `h`, the `k` value is valid.

The possible `k` values span from 1 to the maximum pile in `piles`. Use the validator function as a condition to apply binary search on the span of possible `k` values.

## Time Complexity - O(n * log m)
With `m` being the maximum pile, binary search is executed on a range between 1 and `m`, thus running log `m`. THe validator function runs an O(n) operation each time because it goes over each pile.

## Space Complexity - O(1)
No data structures of `n` size were used.
