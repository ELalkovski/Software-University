public class StartUp
{
    public static void Main()
    {
        var manager = new CarManager();
        var engine = new Engine(manager);
        engine.Run();
    }
}
