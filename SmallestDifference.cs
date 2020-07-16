using System;

/*
  T - O(nlog(n) + mlog(m)) | S - O(1)
	Write a function that takes in two non-empty arrays of integers, find the pairs
	of numbers (one from each array) whose absolute difference is closest to zero,
	and returns an array containing these two numbers from the first array in the
	first position.
	
	You can assume that there will only be one pair of numbers with the smallest difference.
*/

public class Program {
	public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo) {
		Array.Sort(arrayOne);
		Array.Sort(arrayTwo);
		
		int pointerOne = 0;
		int pointerTwo = 0;
		int currentSum = Int32.MaxValue;
		int closestToZero = Int32.MaxValue;
		
		int[] answer = new int[2];
		
		while(pointerOne < arrayOne.Length && pointerTwo < arrayTwo.Length){
			int firstArrayNumber = arrayOne[pointerOne];
			int secondArrayNumber = arrayTwo[pointerTwo];
			
			if(firstArrayNumber < secondArrayNumber){
				currentSum = secondArrayNumber - firstArrayNumber;
				pointerOne++;
			} else if(secondArrayNumber < firstArrayNumber){
				currentSum = firstArrayNumber - secondArrayNumber;
				pointerTwo++;
			} else {
				return new int[] { firstArrayNumber, secondArrayNumber };
			}
			
			if(closestToZero > currentSum){
				closestToZero = currentSum;
				answer = new int[] { firstArrayNumber, secondArrayNumber };
			}
		}
		
		return answer;
	}
}
