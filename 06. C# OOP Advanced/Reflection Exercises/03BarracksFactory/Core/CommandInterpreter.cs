namespace _03BarracksFactory.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private const string commandNamespace = "_03BarracksFactory.Core.Commands.";

        public IExecutable InterpretCommand(string[] data, string commandName, IRepository repository, IUnitFactory factory)
        {
            var firstLetter = commandName[0].ToString().ToUpper();
            commandName = commandName.Remove(0, 1);
            commandName = commandName.Insert(0, firstLetter);
            var entireCommandName = commandNamespace + commandName + "Command";
            Type commandType = Type.GetType(entireCommandName);
            FieldInfo[] fields = commandType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            IExecutable commandInstance = (IExecutable)Activator.CreateInstance(commandType, new object[]{data});

            foreach (FieldInfo field in fields)
            {
                if (field.CustomAttributes.Any(n => n.AttributeType == typeof(InjectAttribute)))
                {
                    if (field.Name == "repository")
                    {
                        field.SetValue(commandInstance, repository);
                    }
                    else if (field.Name == "unitFactory")
                    {
                        field.SetValue(commandInstance, factory);
                    }
                }
            }

            return commandInstance;
        }
    }
}
