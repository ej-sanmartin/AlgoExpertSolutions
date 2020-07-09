/*
  Write a function that takes in a non-empty string and that returns
  a boolean representing whether the string is a palindrome.
  
	A palindrome is defined as a string that's written the same forward
  and backward. Note that single-character strings are palindromes.
*/

public class Program {
	public static bool IsPalindrome(string str) {
		int start = 0;
		int end = str.Length - 1;
		while(start <= end){
			if(str[start] != str[end]){ return false; }
			start++;
			end--;
		}
		return true;
	}
}
