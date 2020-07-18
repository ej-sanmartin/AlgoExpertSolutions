/*
  T - O(n^2) | S - O(n)
	
	Write a function that takes in a non-empty array of distinct integers and
	an integer representing a target sum. The function should find all triplets
	in the array that sum up to the target sum and return a two-dimensional array,
	of all these triplets. The Numbers in each triplet should be ordered in
	ascending order, and the triplets themselves should be ordered in ascending
	order with respect to the numbers they hold.
	
	If no three numbers sum up to the target sum, the function should return an
	empty array
*/

using System;
using System.Collections.Generic;

public class Program {
	public static List<int[]> ThreeNumberSum(int[] array, int targetSum) {
		List<int[]> answer = new List<int[]>();
		Array.Sort(array);
		
		for(int i = 0; i < array.Length - 2; i++){
			int leftPointer = i + 1;
			int rightPointer = array.Length - 1;
			while(leftPointer < rightPointer){
				int currentSum = array[i] + array[leftPointer] + array[rightPointer];
				if(currentSum == targetSum) {
					int[] triplet = { array[i], array[leftPointer], array[rightPointer] };
					answer.Add(triplet);
					leftPointer++;
					rightPointer--;
				} else if(currentSum < targetSum){
					leftPointer++;
				} else if(currentSum > targetSum){
					rightPointer--;
				}
			}
		}
		return answer;
	}
}
