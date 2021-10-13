/*
	Classic problem. Given an array of positive integers representing coin
	denominations and a single non negative n representing target amount of
	money.
	
	Write a function that returns the number of ways to make that target amount
	given the array of denominations

	T - O(nd), we are solving n * d sub problems, where n is n input target
					   and d is equal to the length of the denoms array
	S - O(nd), memo is being created of this size. See n and d above
*/
using System;

public class Program {
	public static int NumberOfWaysToMakeChange(int n, int[] denoms) {
		if (denoms == null) {
			return 0;
		}
		
		int?[,] memo = new int?[n + 1, denoms.Length];
		return NumberOfWays(n, denoms, 0, memo);
	}
	
	private static int NumberOfWays(int target, int[] denoms, int index, int?[,] memo) {
		if (target == 0) {
			return 1;
		}
		
		if (index >= denoms.Length) {
			return 0;
		}
		
		if (memo[target, index] == null) {
			int countOne = 0;
			if (denoms[index] <= target) {
				countOne = NumberOfWays(target - denoms[index], denoms, index, memo);
			}
			int countTwo = NumberOfWays(target, denoms, index + 1, memo);
			memo[target, index] = countOne + countTwo;
		}
		
		return (int)memo[target, index];
	}
}
