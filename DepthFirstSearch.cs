/*
  T - O(V + E) | S - O(V)
  Implement a Depth First Search Algorithm
*/

using System.Collections.Generic;

public class Program {
	public class Node {
		public string name;
		public List<Node> children = new List<Node>();

		public Node(string name) {
			this.name = name;
		}

		public List<string> DepthFirstSearch(List<string> array) {
			array.Add(this.name);
			for(int i = 0; i < children.Count; i++){
				children[i].DepthFirstSearch(array);
			}
			return array;
		}

		public Node AddChild(string name) {
			Node child = new Node(name);
			children.Add(child);
			return this;
		}
	}
}
