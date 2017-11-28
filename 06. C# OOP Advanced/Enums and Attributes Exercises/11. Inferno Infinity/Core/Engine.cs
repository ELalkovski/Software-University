namespace _11.Inferno_Infinity.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private CommandInterpreter interpreter;

        public Engine()
        {
            this.interpreter = new CommandInterpreter();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                List<string> data = input
                    .Split(';')
                    .ToList();

                string command = data[0];
                data.RemoveAt(0);

                ExecuteCommand(command, data);
                input = Console.ReadLine();
            }
        }

        private void ExecuteCommand(string command, List<string> data)
        {
            switch (command)
            {
                case "Create":
                    string[] axeInfo = data[0].Split(' ');
                    string rarity = axeInfo[0];
                    string weaponType = axeInfo[1];
                    string weaponName = data[1];
                    interpreter.Create(rarity, weaponType, weaponName);
                    break;
                case "Add":
                    string[] gemInfo = data[2].Split(' ');
                    weaponName = data[0];
                    int insertIndex = int.Parse(data[1]);
                    string gemClarity = gemInfo[0];
                    string gemType = gemInfo[1];
                    interpreter.Add(weaponName, insertIndex, gemClarity, gemType);
                    break;
                case "Remove":
                    weaponName = data[0];
                    insertIndex = int.Parse(data[1]);
                    interpreter.Remove(weaponName, insertIndex);
                    break;
                case "Print":
                    weaponName = data[0];
                    interpreter.Print(weaponName);
                    break;
            }
        }
    }
}
