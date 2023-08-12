# Short Intro

This Problem wants to find a winner of a tournment that goes between teams using different programming langauges, the problem provides an Jagged array of the competitions where each record is an array of the home team and away team: [homeTeam, awayTeam] and the problem also provides a results array, where it contains either 0 or 1 values, if 0 then the away team wins, if 1 then the home team wins.

For Example:

input competitions array = [ ["C#","HTML"],["C#","PYTHON"],["PYTHON","HTML"] ]
result = [1,0,1]
Winner is python:
c# wins the first match, then python wins the next two matches

# Simple walk through:

- Hashtable-Based Tournament Ranking:

  - Initialize a hashtable to keep track of teams and their points.
    - The initial entry has an empty string as the best team with a value of 0.
  - Loop through the results array.

    - For each match result:
      - Determine which team won (home or away).
      - Check if the winning team exists in the hashtable.
        - If not, add the team to the hashtable with its name as the key and 3 points as the value.
        - If the team already exists, increment its points by 3.
      - After updating the team's points, compare its points with the points of the current best team.
        - If the team's points are greater, update the best team entry in the hashtable.

  - After processing all match results, the best team in the hashtable represents the winner of the tournament.

This solution efficiently ranks the teams based on their match outcomes using a hashtable for constant-time insertion and retrieval. It calculates the winner of the tournament by comparing points. The time complexity is O(N), where N is the number of match results in the array. The space complexity is O(M), where M is the total number of teams participating in the tournament. The solution's effectiveness lies in its ability to quickly update team rankings and determine the tournament winner.
