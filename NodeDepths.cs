/*
	The distance between a node in a Binary Tree and the tree's root is called the node's depth
	Write a function that takes in a Binary Tree and returns the sum of its nodes' depths.
*/

public class Program {
	public static int NodeDepths(BinaryTree root) {
		return NodeDepthsHelper(root, 0);
	}
	
	public static int NodeDepthsHelper(BinaryTree childNode, int level){
		if(childNode == null){ return 0; }
		return level + NodeDepthsHelper(childNode.left, level + 1) + NodeDepthsHelper(childNode.right, level + 1);
	}

	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			left = null;
			right = null;
		}
	}
}
