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
            var input = Console.ReadLine();

            while (input != "END")
            {
                var data = input
                    .Split(';')
                    .ToList();

                var command = data[0];
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
                    var axeInfo = data[0].Split(' ');
                    var rarity = axeInfo[0];
                    var weaponType = axeInfo[1];
                    var weaponName = data[1];
                    interpreter.Create(rarity, weaponType, weaponName);
                    break;
                case "Add":
                    var gemInfo = data[2].Split(' ');
                    weaponName = data[0];
                    var insertIndex = int.Parse(data[1]);
                    var gemClarity = gemInfo[0];
                    var gemType = gemInfo[1];
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
