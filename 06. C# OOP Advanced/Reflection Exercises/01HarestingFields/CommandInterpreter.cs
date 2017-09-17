namespace _01HarestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandInterpreter
    {
       public void Run()
        {
            var command = Console.ReadLine();
            var field = new HarvestingFields();
            Type classType = Type.GetType(field.GetType().FullName);
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static
                                                     | BindingFlags.Public | BindingFlags.NonPublic);

            while (command != "HARVEST")
            {
                ExecuteCommand(command, fields);

                command = Console.ReadLine();
            }
        }

        private void ExecuteCommand(string command, FieldInfo[] fields)
        {
            switch (command)
            {
                case "private":
                    foreach (var field in fields.Where(f => f.IsPrivate))
                    {
                        Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "protected":
                    foreach (var field in fields.Where(f => f.IsFamily))
                    {
                        Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "public":
                    foreach (var field in fields.Where(f => f.IsPublic))
                    {
                        Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                    }
                    break;
                case "all":
                    foreach (var field in fields)
                    {
                        if (field.IsPrivate)
                        {
                            Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                        }
                        else if (field.IsFamily)
                        {
                            Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                        }
                        else
                        {
                            Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                        }
                    }
                    break;
            }
        }
    }
}
