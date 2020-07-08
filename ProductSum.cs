/*
  Write a function that takes in a "special" array and returns its product sum. A "special" array is a non-empty array
  that contains either integers or other "special" arrays. The product sum of a "special" array is the sum of its elements,
  where "special" arrays inside it are summed themselves and then multiplied by their level of depth
  T: O(n) -> we have to iterate through every element in the array and subarray, S: O(n) -> depending on depth of arrays
*/

using System.Collections.Generic;

public class Program {
	public static int ProductSum(List<object> array) {
		int sum = 0;
		sum = ProductSumsHelper(array, 1);
		return sum;
	}
	
	public static int ProductSumsHelper(List<object> array, int depth){
		int count = 0;
		for(int i = 0; i < array.Count; i++){
			if(array[i].GetType() != typeof(int)){
				int newLevel = depth + 1;
				count += ProductSumsHelper((List<object>) array[i], newLevel); 
			} else { count += (int)array[i]; }
		}
		return count * depth;
	}
}
