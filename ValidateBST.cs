/*
  Write a program to check if a given root is a valid BST

  T - O(n), we go through every node in tree once to validate tree
	S - O(h), recursive stack space depends on if tree is balanced
*/

using System;

public class Program {
	public static bool ValidateBst(BST tree) {
		if(tree == null) return true;
		return ValidBST(tree, Int32.MinValue, Int32.MaxValue);
	}
	
	public static bool ValidBST(BST root, int min, int max){
		if(root == null) return true;
		if(root.value < min || root.value >= max) return false;
		bool left = ValidBST(root.left, min, root.value);
		bool right = ValidBST(root.right, root.value, max);
		return left && right;
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
