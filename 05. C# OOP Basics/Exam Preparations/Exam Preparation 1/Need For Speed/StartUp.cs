public class StartUp
{
    public static void Main()
    {
        CarManager manager = new CarManager();
        Engine engine = new Engine(manager);

        engine.Run();
    }
}
