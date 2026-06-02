[module: Sharpmake.Include("Source/Solution_Calamity.sharpmake.cs")]

public static class Main
{
    [Sharpmake.Main]
    public static void SharpmakeMain(Sharpmake.Arguments arguments)
    {
        arguments.Generate<Solution_Calamity>();
    }
}