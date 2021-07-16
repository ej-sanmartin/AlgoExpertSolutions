/*
	Check if an array of integers is monotonic, monotonic meaning that if its
	elements, from left to right, are entirely non increasing or entirely non
	decreasing.

	T - O(n), n being the length of the array as we must go through each element
					  to check if array is monotonic
	S - O(1), we are only ever creating bool variables
*/

using System;

public class Program {
	public static bool IsMonotonic(int[] array) {
		bool isNonDecreasing = true;
		bool isNonIncreasing = true;
		
		for(int i = 1; i < array.Length; i++){
			if(array[i] < array[i - 1]) isNonDecreasing = false;
			if(array[i] > array[i - 1]) isNonIncreasing = false;
		}
		
		return isNonDecreasing || isNonIncreasing;
	}
}
