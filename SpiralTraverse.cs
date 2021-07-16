/*
	Write a function that takes in a two dimensional array and return a one
	dimensional array of all the elements in spiral order.
	
	Spiral Order starts at the top left corner of this square, rectangular 
	shaped array, goes to the right, travels straight downward, and keeps
	going in a spiral pattern from there.

	T - O(n), where n is the number of elements in the array
	S - O(n), where our output list we create is goign to hold all the elements
						of the input array
*/
using System;
using System.Collections.Generic;

public class Program {
	public static List<int> SpiralTraverse(int[,] array) {
		List<int> spiralArray = new List<int>();
		int startRow = 0;
		int startColumn = 0;
		int endRow = array.GetLength(0) - 1;
		int endColumn = array.GetLength(1) - 1;
		int row, column;
		
		while(startRow <= endRow && startColumn <= endColumn){
			for(column = startColumn; column <= endColumn; column++){
				spiralArray.Add(array[startRow, column]);
			}
			
			for(row = startRow + 1; row <= endRow; row++){
				spiralArray.Add(array[row, endColumn]);
			}
			
			for(column = endColumn - 1; column >= startColumn; column--){
				if(startRow == endRow) break;
				spiralArray.Add(array[endRow, column]);
			}
			
			for(row = endRow - 1; row > startRow; row--){
				if(startColumn == endColumn) break;
				spiralArray.Add(array[row, startColumn]);
			}
			
			startRow++;
			endRow--;
			startColumn++;
			endColumn--;
		}
		
		return spiralArray;
	}
}
