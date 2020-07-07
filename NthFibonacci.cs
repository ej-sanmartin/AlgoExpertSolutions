/*
  Write a function that takes in an integer n and returns the nth Fibonacci number
*/

public class Program {
	private static int[] memo = new int[19]; // create a memo cache to store sequences already calculated by the function
	
	public static int GetNthFib(int n) {
		if(n == 1) { return 0; }
		else if(n == 2) { return 1; }
		else if(memo[n] == 0 ) { memo[n] = GetNthFib(n - 1) + GetNthFib(n - 2); } // if n hasn't been set, set n's value by running this function recursively with n-1 and n-2 as parameters passed
		return memo[n];
	}
}
