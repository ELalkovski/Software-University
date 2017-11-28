namespace _07.Custom_List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        private CustomList<string> customList;

        public CommandInterpreter()
        {
            this.customList = new CustomList<string>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                List<string> data = input
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string command = data[0];

                ExecuteCommand(command, data);
                input = Console.ReadLine();
            }
        }

        private void ExecuteCommand(string command, List<string> data)
        {
            switch (command)
            {
                case "Add":
                    string element = data[1];
                    this.customList.Add(element);
                    break;
                case "Remove":
                    int index = int.Parse(data[1]);
                    this.customList.Remove(index);
                    break;
                case "Contains":
                    element = data[1];
                    Console.WriteLine(this.customList.Contains(element));
                    break;
                case "Swap":
                    int firstIndex = int.Parse(data[1]);
                    int secondIndex = int.Parse(data[2]);
                    this.customList.Swap(firstIndex, secondIndex);
                    break;
                case "Greater":
                    string border = data[1];
                    Console.WriteLine(this.customList.CountGreaterThan(border));
                    break;
                case "Max":
                    Console.WriteLine(this.customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(this.customList.Min());
                    break;
                case "Print":
                    Console.WriteLine(this.customList.ToString());
                    break;
                case "Sort":
                    this.customList = Sorter.Sort(this.customList);
                    break;
            }
        }
    }
}
