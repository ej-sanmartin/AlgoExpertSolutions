/*
  T - O(log(n))
  S - O(n)
  
  Write a function that takes in a Binary Search Tree (BST) and a target
	integer value and returns the closest value to that target value in the BST.
	You can assume that there will only be one closest value.
*/

using System;

public class Program {
	public static int FindClosestValueInBst(BST tree, int target) {
		return findClosestValueInBSTHelper(tree, target, tree.value);
	}
	
	public static int findClosestValueInBSTHelper(BST tree, int target, int closest){
		if(Math.Abs(target - closest) > Math.Abs(target - tree.value)){
			closest = tree.value;
		}
		
		if(target < tree.value && tree.left != null){
			return findClosestValueInBSTHelper(tree.left, target, closest);
		} else if(target > tree.value && tree.right != null){
			return findClosestValueInBSTHelper(tree.right, target, closest);
		} else {
			return closest;
		}
	}

	public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}
}
