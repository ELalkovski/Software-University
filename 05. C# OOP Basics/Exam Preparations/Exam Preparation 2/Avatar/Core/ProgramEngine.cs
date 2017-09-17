using System;
using System.Collections.Generic;
using System.Linq;

public class ProgramEngine
{
    private NationsBuilder nationsBuilder;

    public ProgramEngine(NationsBuilder nationsBuilder)
    {
        this.nationsBuilder = nationsBuilder;
    }

    public void Run()
    {
        string input = Console.ReadLine();

        while (true)
        {
            List<string> data = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = data[0];

            ExecuteCommand(command, data);

            if (input == "Quit")
            {
                break;
            }

            input = Console.ReadLine();
        }
    }

    private void ExecuteCommand(string command, List<string> data)
    {
        switch (command)
        {
            case "Bender":
                this.nationsBuilder.AssignBender(data);
                break;
            case "Monument":
                this.nationsBuilder.AssignMonument(data);
                break;
            case "Status":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.nationsBuilder.GetStatus(data[1]));
                Console.ResetColor();
                break;
            case "War":
                this.nationsBuilder.IssueWar(data[1]);
                break;
            case "Quit":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(this.nationsBuilder.GetWarsRecord());
                Console.ResetColor();
                break;
        }
    }
}
