/*
  T - O(n), as we are going to loop through every item of the array
  S - O(1)
	
	You're given an array of integers. Write a function that moves all
	instances of that integer in the array to the end of the array and
	returns the array.
	
	The function should perform this in place and doesn't need to maintain
	the order of the other integers.
*/

using System.Collections.Generic;

public class Program {
	public static List<int> MoveElementToEnd(List<int> array, int toMove) {
		int startPointer = 0;
		int endPointer = array.Count - 1;
		
		while(startPointer < endPointer){
			if(array[endPointer] == toMove){ endPointer--; }
			if(array[startPointer] == toMove){
				int temporary = array[startPointer];
				array[startPointer] = array[endPointer];
				array[endPointer] = temporary;
			}
			startPointer++;
		}
		
		return array;
	}
}
