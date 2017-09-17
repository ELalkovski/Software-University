namespace _02BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Type classType = typeof(BlackBoxInt);
            FieldInfo innerValue = classType.GetField("innerValue", BindingFlags.Instance | BindingFlags.NonPublic);
            MethodInfo[] methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            ConstructorInfo[] ctors = classType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);
            Type[] constrParams = new Type[]{};
            Object classInstance = ctors[1].Invoke(constrParams);
            

            while (input != "END")
            {
                var tokens = input.Split('_');
                var command = tokens[0];
                var value = int.Parse(tokens[1]);

                methods.FirstOrDefault(m => m.Name.Equals(command)).Invoke(classInstance, new object[] {value});
                Console.WriteLine(innerValue.GetValue(classInstance));

                input = Console.ReadLine();
            }
        }
    }
}
