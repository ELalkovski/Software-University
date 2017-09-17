public class StartUp
{
    public static void Main()
    {
        NationsBuilder nationsBuilder = new NationsBuilder();
        ProgramEngine engine = new ProgramEngine(nationsBuilder);

        engine.Run();
    }
}
