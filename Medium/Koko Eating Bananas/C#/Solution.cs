using System;

namespace Koko_Eating_Bananas;

public class Solution {
	public int MinEatingSpeed(int[] piles, int h) {
		bool isValidK(int k) {
			double eatingHours = 0;

			foreach (double pile in piles) {
				eatingHours += Math.Ceiling(pile / k);
				if (eatingHours > h)
					return false;
			}

			return true;
		}

		int left = 1; 
		int right = piles.Max();

		while (left < right) {
			int k = (right + left) / 2;
			
			if (isValidK(k))
				right = k;
			else
				left = k + 1;
		}

		return left;
	}
}
