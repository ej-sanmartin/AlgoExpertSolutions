using System.Collections.Generic;
using System;

/*
  Remove duplicate elements from a sorted linked list
  
  Since linked list is sorted, we just need to remove neighboring
  nodes to make sure they do not have the same values
  
  If Linked list is not sorted and we are asked this question
  we must keep track of previously seen values, with a hashset or
  hashmap. Then, we remove a node if the value has already been
  seen in the linked list

	T - O(n), where n is number of items in the linked list
					  and we must traverse through all elements to find
					  all duplicates
	S - O(1), we are using constant space, not creating anything
						extra that depends on input size.
*/
public class Program {
	// This is an input class. Do not edit.
	public class LinkedList {
		public int value;
		public LinkedList next;

		public LinkedList(int value) {
			this.value = value;
			this.next = null;
		}
	}

	public LinkedList RemoveDuplicatesFromLinkedList(LinkedList linkedList) {
		LinkedList current = linkedList;
		LinkedList sentinel = new LinkedList(Int32.MaxValue);
		sentinel.next = linkedList;
		
		while(current != null){
			if(current.value == sentinel.value){
				sentinel.next = current.next;
				current = sentinel.next;
			} else {
				sentinel = current;
				current = current.next;
			}
		}
		
		return linkedList;
	}
}
