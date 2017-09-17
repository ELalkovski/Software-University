using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        int lines = int.Parse(Console.ReadLine());

        List<Person> persons = new List<Person>();

        for (int i = 0; i < lines; i++)
        {
            string[] cmdArgs = Console.ReadLine()
                .Split();

            Person person = new Person(cmdArgs[0],
                cmdArgs[1],
                int.Parse(cmdArgs[2]),
                double.Parse(cmdArgs[3]));

            persons.Add(person);
        }

        Team team = new Team("Gorno Nadolnishte");

        foreach (var person in persons)
        {
            team.AddPlayer(person);
        }

        Console.WriteLine($"First team have {team.FirstTeam.Count} players");
        Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players");
    }
}