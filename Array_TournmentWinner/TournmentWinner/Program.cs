using System.Collections;

List<List<string>> competitions = new List<List<string>>() { new List<string>{"HTML","C#"}, new List<string>{"C#","Python"},new List<string>{"Python","HTML"} };
List<int> results = new List<int>() {0,0,1 };    

static string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    string bestTeam = "";
    Hashtable teamStore = new Hashtable();
    teamStore.Add("", 0);
    for (int i = 0; i < results.Count; i++)
    {
        if (results[i] == 0)
        {
            if (teamStore.ContainsKey(competitions[i][1]))
            {
                teamStore[competitions[i][1]] = (int)teamStore[competitions[i][1]] + 3;
            }
            else
            {
                teamStore.Add(competitions[i][1], 3);

            }
            if ((int)teamStore[bestTeam] < (int)teamStore[competitions[i][1]])
            {
                bestTeam = competitions[i][1];
            }
        }
        else
        {
            if (teamStore.ContainsKey(competitions[i][0]))
            {
                teamStore[competitions[i][0]] = (int)teamStore[competitions[i][0]] + 3;
            }
            else
            {
                teamStore.Add(competitions[i][0], 3);
            }
            if ((int)teamStore[bestTeam] < (int)teamStore[competitions[i][0]])
            {
                bestTeam = competitions[i][0];
            }
        }

    }
    return bestTeam;
}
TournamentWinner(competitions,results);