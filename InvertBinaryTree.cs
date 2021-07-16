/*
	Invert a binary tree
	
	T - O(n), where n is the number of the nodes in the tree we have to invert
	S - O(h), where h is the height of the recursive call stack. Depends on
					  if the tree is balanced or not
*/
using System;

public class Program {
	public static void InvertBinaryTree(BinaryTree tree) {
		InvertBinaryTreeHelper(tree);
	}
	
	public static BinaryTree InvertBinaryTreeHelper(BinaryTree tree){
		if(tree == null) return null;
		
		BinaryTree left = InvertBinaryTreeHelper(tree.left);
		BinaryTree right = InvertBinaryTreeHelper(tree.right);
		
		tree.left = right;
		tree.right = left;
		
		return tree;
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
		}
	}
}
