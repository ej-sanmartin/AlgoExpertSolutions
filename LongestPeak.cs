/*
  Given an array of integers, find the length of the longest peak where
	numbers to the left of the peak is decreasing and numbers to the right
	of the peak are decreasing.
	
	T - O(n), as we do only one pass through the entire array
	S - O(1), as we do not create any additional space that is dependent on input
*/

using System;

public class Program {
	public static int LongestPeak(int[] array) {
		if(array == null || array.Length == 0) return 0;
		int longestLength = 0;
		int i = 1;
		while(i < array.Length - 1){
			bool isPeak = array[i - 1] < array[i] && array[i + 1] < array[i];
			if(!isPeak){
				i++;
				continue;
			}
			int leftIndex = i - 2;
			while(leftIndex >= 0 && array[leftIndex] < array[leftIndex + 1]){
				leftIndex--;
			}
			int rightIndex = i + 2;
			while(rightIndex < array.Length && array[rightIndex] < array[rightIndex - 1]){
				rightIndex++;
			}
			int currentPeak = rightIndex - leftIndex - 1;
			longestLength = Math.Max(longestLength, currentPeak);
			i = rightIndex;
		}
		
		return longestLength;
	}
}
