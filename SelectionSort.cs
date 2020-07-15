/*
  T - O(n^2) | S - O(1)
	
	Write a function that takes in an array of integers and returns a sorted
	version of that array. Use the Selection Sort algorithm to sort the array.
*/

using System;

public class Program {
	public static int[] SelectionSort(int[] array){
		if(array.Length == 0){ return new int[] {}; }
		
		for(int i = 0; i < array.Length - 1; i++){
			int smallestIndex = i;
			for(int j = i + 1; j < array.Length; j++){
				if(array[j] < array[smallestIndex]){
					smallestIndex = j;
				}
			}
			int temporary = array[smallestIndex];
			array[smallestIndex] = array[i];
			array[i] = temporary;
		}
		return array;
	}
}
