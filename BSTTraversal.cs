/*
  T - O(n), based on number of nodes in tree
	S - O(n), recursive stack that is taking up memory
	
	Write three functions that take in a Binary Search Tree (BST)
 and an empty array, traverse the BST, add its nodes' values to the input
 array, and return that array. The three functions should traverse the
 BST using the in-order, pre-order, and post-order tree traversal
 techniques, respectively.
 
*/

using System.Collections.Generic;

public class Program {
	public static List<int> InOrderTraverse(BST tree, List<int> array) {
		if(tree.left != null){ InOrderTraverse(tree.left, array); }
		
		array.Add(tree.value);
		
		if(tree.right != null){ InOrderTraverse(tree.right, array); }

		return array;
	}

	public static List<int> PreOrderTraverse(BST tree, List<int> array){		
		array.Add(tree.value);
		
		if(tree.left != null){ PreOrderTraverse(tree.left, array); }
		if(tree.right !=null){ PreOrderTraverse(tree.right, array); }
		
		return array;
	}

	public static List<int> PostOrderTraverse(BST tree, List<int> array){
		if(tree.left != null){ PostOrderTraverse(tree.left, array); }
		if(tree.right != null){ PostOrderTraverse(tree.right, array); }
		
		array.Add(tree.value);
		return array;
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
