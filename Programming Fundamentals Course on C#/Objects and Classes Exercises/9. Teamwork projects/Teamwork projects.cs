using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Teamwork_projects
{
    class TeamworkProjects
    {
        public static void Main()
        {
            /* ------------- Team part working properly --------------*/

            var teamsForRegister = int.Parse(Console.ReadLine());
            var allTeams = new List<Team>();

            for (int i = 0; i < teamsForRegister; i++)
            {
                var inputTeams = Console.ReadLine().Split('-');
                var creator = inputTeams[0];
                var teamName = inputTeams[1];
                if (allTeams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine("Team {0} was already created!", teamName);
                    continue;
                    
                }

                else if (allTeams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine("{0} cannot create another team!", creator);
                    continue;
                }

                else
                {
                    var currTeam = new Team() { Name = teamName, Creator = creator };
                    allTeams.Add(currTeam);
                    Console.WriteLine("Team {0} has been created by {1}!", teamName, creator);
                }

            }

            /* ------------- Team part working properly --------------*/

            

            while (true)
            {
                string inputMembers = Console.ReadLine();

                if (inputMembers.ToLower() == "end of assignment")
                {
                    break; 
                }

                var membersData = inputMembers.Split("->".ToArray(),StringSplitOptions.RemoveEmptyEntries);
                string  member = membersData[0];
                string preferedTeamName = membersData[1];

                var members = new List<string>() { member};

                if (allTeams.All(x => x.Name != preferedTeamName))
                {
                    Console.WriteLine("Team {0} does not exist!", preferedTeamName);
                    continue;
                }
                if (allTeams.Any(x => x.Members.Contains(member)) || allTeams.Any(x => x.Creator == member))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!", member, preferedTeamName);
                    continue;              
                }

                int index = allTeams.FindIndex(x => x.Name == preferedTeamName);
                allTeams[index].Members.Add(member);

                
            }

            foreach (var team in allTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                if (team.Members.Count > 0)
                {
                    Console.WriteLine("{0}", team.Name);
                    Console.WriteLine("- {0}", team.Creator);

                    foreach (var member in team.Members.OrderBy(x => x))
                    {
                        Console.WriteLine("-- {0}", member);
                    }             
                }  
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in allTeams.OrderBy(x => x.Name))
            {
                if (team.Members.Count == 0)
                {
                    Console.WriteLine("{0}",team.Name);
                }
            }
        }
    }
}
