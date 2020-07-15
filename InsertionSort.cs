/*
	T - O(n^2) | S - O(1)
	Write a function that takes in an array of integers and returns a sorted
	version of that array. Use the Insertion Sort algorithm to sort the array.
*/

public class Program {
	public static int[] InsertionSort(int[] array) {
		for(int i = 0; i < array.Length; i++){
			for(int j = i; j > 0; j--){
				if(array[j] < array[j - 1]){
					int temporary = array[j];
					array[j] = array[j - 1];
					array[j - 1] = temporary;
				}
			}
		}
		return array;
	}
}
