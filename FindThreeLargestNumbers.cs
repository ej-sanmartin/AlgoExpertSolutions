/*
  Write a function that takes in an aray of integers and, without sorting the input array,
	returns a sorted array of the three largest integers in the input array.
	
	T - O(n) | S - O(1)
*/

using System;

public class Program {
	public static int[] FindThreeLargestNumbers(int[] array) {
		int[] threeLargest = { Int32.MinValue, Int32.MinValue, Int32.MinValue };
		foreach(int num in array){
			updateLargest(threeLargest, num);
		}
		
		return threeLargest;
	}
	
	public static void updateLargest(int[] threeLargest, int num){
		if(threeLargest[2] == Int32.MinValue || num > threeLargest[2]){ shiftAndUpdate(threeLargest, num, 2); }
		else if(threeLargest[1] == Int32.MinValue || num > threeLargest[1]){ shiftAndUpdate(threeLargest, num, 1); }
		else if(threeLargest[0] == Int32.MinValue || num > threeLargest[0]){ shiftAndUpdate(threeLargest, num, 0); }
	}
	
	public static void shiftAndUpdate(int[] array, int num, int index){
		for(int i = 0; i <= index; i++){
			if(i == index){ array[i] = num; }
			else{ array[i] = array[i + 1]; }
		}
	}
}
