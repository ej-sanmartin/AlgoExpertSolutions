using System.Collections.Generic;

/*
  Problem: Write a function that takines in a Binary Tree and returns a list of its branch's sums ordered from leftmost branch sum to rightmost branch sum
  
  Time and Space Complexity: O(n) and O(n) because we are searching through every branch of a tree in DFS fashion and the space is growing in the list depending on
    the size of the branch.
    
  I wanted to work on this problem first to get more comfortable with the tree data structure. Solving this certainly helped but I did trip myself up because I did
  not think initially to pass the List that will be constructed to the helper method. I initially wanted the helper method to return the branch's sum so that it can
  be added to the list in the BranchSums main method. However, I could not figure out how to add these sums to the list in this way. Only with hints was I able to be
  steered to the right answer.
  
  Still lots of studying to do!!
*/

public class Program {
	// This is the class of the input root. Do not edit it.
	public class BinaryTree {
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value) {
			this.value = value;
			this.left = null;
			this.right = null;
		}
	}

	public static List<int> BranchSums(BinaryTree root) {
		if(root == null) { return null; }
		List<int> answer = new List<int>();
		
		BranchSumsHelper(root, 0, answer);
		
		return answer;
	}
	
	public static void BranchSumsHelper(BinaryTree node, int sum, List<int> answer){
		if(node == null){ return; }
		
		int newSum = sum + node.value;
		
		if(node.left == null && node.right == null) {
			answer.Add(newSum);
			return;
		}
	 	
		BranchSumsHelper(node.left, newSum, answer);
		BranchSumsHelper(node.right, newSum, answer);
	}
}
