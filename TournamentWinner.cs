/*
  Question: Given a list of list, each list representing a single game with a home team in the first index
  and a away team in the second index, and another list of results of each game, return the team that won the most
  points from the inputted list of list.
  
  In the result list, a 1 represents that the home team won, and a 0 represents that the away team won.
  
  If a team wins, they win 3 points. Loser wins no points
  
  There are not draws.
  
  Example INPUT: competition - [["New York", "Boston"], ["New York", "California"], ["California", "Boston"], ["California", "Boston"], ["New York", "California"]]
                 result - [1, 1, 0, 1, 1]
          OUTPUT: "New York"

*/

using System.Collections.Generic;
using System;

// T - O(n + m)
// S - O(m)
public class Program {

	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
		Dictionary<string, int> seasonResult = new Dictionary<string, int>();
		int teamsIndex = 1;
		string winner = "";
		int highestScore = 0;
		int winningTeamIndex;
		
		for(int i = 0; i < results.Count; i++){
			winningTeamIndex = teamsIndex - results[i];
			winner = competitions[i][winningTeamIndex];
			if(seasonResult.ContainsKey(winner)){
				seasonResult[winner] += 3;
			} else {
				seasonResult.Add(winner, 3);
			}
		}
		
		foreach(var team in seasonResult){
			if(team.Value > highestScore){
				winner = team.Key;
				highestScore = team.Value;
			}
		}
		
		return seasonWinner;
	}
}



/***** Optimal Solution ******/
// T - O(n), S - O(k)
using System.Collections.Generic;
using System;

// T - O(n + m)
// S - O(m)
public class Program {

	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
		Dictionary<string, int> seasonResult = new Dictionary<string, int>();
		int teamsIndex = 1;
		string winner = "";
		int highestScore = 0;
		int winningTeamIndex;
		
		for(int i = 0; i < results.Count; i++){
			winningTeamIndex = teamsIndex - results[i];
			winner = competitions[i][winningTeamIndex];
			if(seasonResult.ContainsKey(winner)){
				seasonResult[winner] += 3;
			} else {
				seasonResult.Add(winner, 3);
			}
		}
		
		foreach(var team in seasonResult){
			if(team.Value > highestScore){
				winner = team.Key;
				highestScore = team.Value;
			}
		}
		
		return seasonWinner;
	}
}
