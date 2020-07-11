/*
  Write a function that takes in the head of a Singly Linked List and an integer k and removes the kth node from the end of the list.
	You can assume that the input Linked List will always have at least 2 nodes and, more specifically, at least k nodes.
*/

public class Program {
	public static void RemoveKthNodeFromEnd(LinkedList head, int k) {
		int counter = 1;
		LinkedList current = head;
		LinkedList kPointer = head;
		
		while(counter <= k){
			kPointer = kPointer.Next;
			counter++;
		}
		
		if(kPointer == null){
			head.Value = head.Next.Value;
			head.Next = head.Next.Next;
			return;
		}
		
		while(kPointer.Next != null){
			current = current.Next;
			kPointer = kPointer.Next;
		}
		current.Next = current.Next.Next;
	}

	public class LinkedList {
		public int Value;
		public LinkedList Next = null;

		public LinkedList(int value) {
			this.Value = value;
		}
	}
}
