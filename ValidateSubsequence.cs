/*
  Given two non-empty arrays of integers, write a function that determines
	whether the second array is a subsequent of the first one.
	
	A subsequence of an array is a set of numbers that aren't necessarily adjacent
	in the aray but that are in the same order as they appear in the array.
	
	T - O(N) | S - O(1)
*/

using System.Collections.Generic;

public class Program {
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) {
		int sequencePointer = 0;
		for(int i = 0; i <= array.Count - 1; i++ ){
			if(array[i] == sequence[sequencePointer]){ sequencePointer++; }
			if(sequencePointer == sequence.Count){ return true; }
		}
		return false;
	}
}
