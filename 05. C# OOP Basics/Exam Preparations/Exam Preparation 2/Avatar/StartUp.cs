public class StartUp
{
    public static void Main()
    {
        var nationsBuilder = new NationsBuilder();
        var engine = new ProgramEngine(nationsBuilder);
        engine.Run();
    }
}
