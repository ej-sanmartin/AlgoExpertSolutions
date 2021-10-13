/*
	Given an array of positive integers and return the max sumof non adjacent
	elements in the array.
	
	If the input array is empty, the function should return 0

	T - O(n), n being the size of the input array and max size of memo array
	S - O(n), n being the size of memo which is the size of the input array
*/
using System;

public class Program {
	public static int MaxSubsetSumNoAdjacent(int[] array) {
		if (array.Length == 0 || array == null) {
			return 0;
		}
		int[] memo = new int[array.Length + 1];
		return MaxSubsetSum(array, 0, memo);
	}
	
	private static int MaxSubsetSum(int[] arr, int index, int[] memo){
		if (index >= arr.Length) {
			return 0;
		}
		
		if (memo[index] == 0) {
			int sumOne = arr[index] + MaxSubsetSum(arr, index + 2, memo);
			int sumTwo = MaxSubsetSum(arr, index + 1, memo);
			memo[index] = Math.Max(sumOne, sumTwo);
		}

		return memo[index];
	}
}
