/*
  T - O(n), where n is the length of the inputted array
  S - O(n), where n is the size of the aray created, which is the same size of the inputted array
  
  Trick is that there can be negative values in inputted array, which would leave a resulting array,
  if all elements from the inputted array are just added to their correspinding index in the result array,
  not sorted. Using a sorted method from C# would increase time complexity to O(nlogn)
  
  Optimal solution is creating local variables that point to start and end of inputted array and add to
  the resulting array the absolute value of the two elements that is largest to the end of the resulting array.
  Make sure to square the largest, too!
*/

using System;

public class Program {

	public int[] SortedSquaredArray(int[] array) {
		int[] result = new int[array.Length];
		int smallest = 0;
		int largest = array.Length - 1;
		int leftValue, rightValue;
		
		for(int i = array.Length - 1; i >= 0; i--){
			leftValue = (int)Math.Abs(array[smallest]);
			rightValue = (int)Math.Abs(array[largest]);
			if(leftValue >= rightValue){
				result[i] = (int)Math.Pow(leftValue, 2);
				smallest++;
			} else {
				result[i] = (int)Math.Pow(rightValue, 2);
				largest--;
			}
		}
		
		return result;
	}
}

