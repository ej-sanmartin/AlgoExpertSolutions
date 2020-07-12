// Implement Bubble Sort. T - O(n^2)

public class Program {
	public static int[] BubbleSort(int[] array) {
		for(int i = 0; i < array.Length - 1; i++){
			for(int j = 0; j < array.Length - i - 1; j++){ // remember, whenever i is incremented, that means the second loop within has ran and has already sorted the largest number to the end of the array. Thus, you do not need to loop to that point
				if(array[j] > array[j + 1]){
					int temporary = array[j];
					array[j] = array[j + 1];
					array[j + 1] = temporary;
				}
			}
		}
		return array;
	}
}
