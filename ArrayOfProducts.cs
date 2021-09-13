/*
	Given an array, return an array where array[i] is the product of all
	elements in the array not factoring in array[i]. Cannot use division

	T - O(n), n being size of the input array. we do 3 passes through n
	S - O(n), we create 3 arrays of size n
*/

using System;

public class Program {
	public int[] ArrayOfProducts(int[] array) {
		int[] products = new int[array.Length];
		int[] leftProducts = new int[array.Length];
		int[] rightProducts = new int[array.Length];
		
		int leftRunningProduct = 1;
		for(int i = 0; i < array.Length; i++){
			leftProducts[i] = leftRunningProduct;
			leftRunningProduct *= array[i];
		}
		
		int rightRunningProduct = 1;
		for(int i = array.Length - 1; i >= 0; i--){
			rightProducts[i] = rightRunningProduct;
			rightRunningProduct *= array[i];
		}
		
		for(int i = 0; i < array.Length; i++){
			products[i] = leftProducts[i] * rightProducts[i];
		}
		
		return products;
	}
}
