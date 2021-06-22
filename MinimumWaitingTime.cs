using System;

public class Program {
	// T - O(nlogn), longest operation is sorting inputted array
	// S - O(1), we are only creating int variables, independent on size of array
	public int MinimumWaitingTime(int[] queries) {
		Array.Sort(queries);
		int timeSoFar = queries[0];
		int waitTime = 0;
		
		for(int i = 1; i < queries.Length; i++){
			waitTime += timeSoFar;
			timeSoFar += queries[i];
		}
		
		return waitTime;
	}
}
