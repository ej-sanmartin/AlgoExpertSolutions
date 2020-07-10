/*
  Write a function that takes in a sorted array of integers as well as a target integer. The function should use the
  Binary Search Algotithm to determine if the target integer is contained in the array and should return its index if
  it is, otherwise -1.
*/

public class Program {
	public static int BinarySearch(int[] array, int target) {
		return BinarySearchHelper(array, target, 0, array.Length - 1);
	}
	
	public static int BinarySearchHelper(int[] input, int target, int start, int end){
		if(start > end){ return -1; }
		int middle = (start + end) / 2;
		if(target == input[middle]){ return middle; }
		else if(target < input[middle]){ return BinarySearchHelper(input, target, start, middle - 1); }
		else{ return BinarySearchHelper(input, target, middle + 1, end); }		
	}
}
