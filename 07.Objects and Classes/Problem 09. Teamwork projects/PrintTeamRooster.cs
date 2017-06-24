using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class PrintTeamRooster
{
    public static void Main()
    {
        int numberOfTeams = int.Parse(Console.ReadLine());
        List<Team> teamList = ReadTeams(numberOfTeams);

        ReadComments(teamList);

        PrintResult(teamList);
    }

    private static void PrintResult(List<Team> teamList)
    {

        foreach (var team in teamList.Where(member => member.Members.Count > 0).OrderByDescending(m => m.Members.Count).ThenBy(n => n.Name))
        {
            Console.WriteLine($"{team.Name}");
            Console.WriteLine($"- {team.Creator}");
            foreach (var member in team.Members.OrderBy(x => x))
            {
                Console.WriteLine($"-- {member}");
            }
        }
        Console.WriteLine($"Teams to disband:");
        foreach (var team in teamList.Where(m => m.Members.Count == 0).OrderBy(x => x.Name))
        {

            Console.WriteLine($"{team.Name}");
        }
    }

    private static void ReadComments(List<Team> teamList)
    {
        string assignment = Console.ReadLine();

        while (!assignment.Equals("end of assignment"))
        {
            string[] teamAssignment = assignment.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string member = teamAssignment[0];
            string appliedTeamName = teamAssignment[1];

            if (!teamList.Select(x => x.Name).Contains(appliedTeamName))
            {
                Console.WriteLine("Team {0} does not exist!", appliedTeamName);
            }
            else if (teamList.Select(x => x.Members).Any(x => x.Contains(member)) || teamList.Select(x => x.Creator).Contains(member))
            {
                Console.WriteLine("Member {0} cannot join team {1}!", member, appliedTeamName);
            }
            else
            {
                int teamToJoinIndex = teamList.FindIndex(x => x.Name == appliedTeamName);
                teamList[teamToJoinIndex].Members.Add(member);
            }

            assignment = Console.ReadLine();
        }
    }

    private static List<Team> ReadTeams(int numberOfTeams)
    {
        List<Team> teamList = new List<Team>();

        for (int i = 0; i < numberOfTeams; i++)
        {
            string[] teamDetails = Console.ReadLine().Split('-').ToArray();
            List<string> membersList = new List<string>();
            Team currentTeam = new Team();
            currentTeam.Name = teamDetails[1];
            currentTeam.Creator = teamDetails[0];
            currentTeam.Members = membersList;

            if (!teamList.Select(x => x.Name).Contains(currentTeam.Name))
            {
                if (!teamList.Select(x => x.Creator).Contains(currentTeam.Creator))
                {
                    teamList.Add(currentTeam);
                    Console.WriteLine("Team {0} has been created by {1}!", teamDetails[1], teamDetails[0]);
                }
                else
                {
                    Console.WriteLine("{0} cannot create another team!", currentTeam.Creator);
                }
            }
            else
            {
                Console.WriteLine("Team {0} was already created!", currentTeam.Name);
            }
        }
        return teamList;
    }
}

public class Team
{
    public string Name { get; set; }
    public string Creator { get; set; }
    public List<string> Members { get; set; }
}
