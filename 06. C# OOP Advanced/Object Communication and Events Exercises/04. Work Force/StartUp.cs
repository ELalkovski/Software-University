namespace _04.Work_Force
{
    using _04.Work_Force.Core;

    public class StartUp
    {
        public static void Main()
        {
            CommandInterpreter interpreter = new CommandInterpreter();
            interpreter.Run();
        }
    }
}
