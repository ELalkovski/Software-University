using System;

public class StartUp
{
    static void Main()
    {
        Scale<string> scale = new Scale<string>("a", "c");
        Console.WriteLine(scale.GetHavier());

        Scale<int> scale2 = new Scale<int>(5, 3);
        Console.WriteLine(scale2.GetHavier());
    }
}
