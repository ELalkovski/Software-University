using System;

namespace Paw_Inc.Core
{
    public class Engine
    {
        private CenterManager manager;

        public Engine()
        {
            this.manager = new CenterManager();
        }

        public void Run()
        {
            var input = Console.ReadLine();

            while (input != "Paw Paw Pawah")
            {
                var data = input.Split(new []{' ', '|'}, StringSplitOptions.RemoveEmptyEntries);
                var command = data[0];

                switch (command)
                {
                    case "RegisterAdoptionCenter":
                        this.manager.RegisterAdoptionCenter(data[1]);
                        break;
                    case "RegisterCleansingCenter":
                        this.manager.RegisterCleansingCenter(data[1]);
                        break;
                    case "RegisterDog":
                        this.manager.RegisterDog(data[1], int.Parse(data[2]), int.Parse(data[3]), data[4]);
                        break;
                    case "RegisterCat":
                        this.manager.RegisterCat(data[1], int.Parse(data[2]), int.Parse(data[3]), data[4]);
                        break;
                    case "SendForCleansing":
                        this.manager.SendForCleansing(data[1], data[2]);
                        break;
                    case "Cleanse":
                        this.manager.Cleanse(data[1]);
                        break;
                    case "Adopt":
                        this.manager.Adopt(data[1]);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(manager.ToString());
            Console.ResetColor();
            
        }

        public void ExecuteCommand()
        {
            
        }
    }
}
