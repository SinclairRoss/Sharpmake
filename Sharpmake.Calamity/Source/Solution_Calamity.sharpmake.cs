using Sharpmake;

[module: Sharpmake.Include("Muffin/Calamity.sharpmake.cs")]
[module: Sharpmake.Include("Muffin/Muffin.sharpmake.cs")]

[Generate]
public class Solution_Calamity : Solution
{
    public Solution_Calamity()
    {
        Name = "349";

        AddTargets(new Target(
            Platform.win32 | Platform.win64,
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release));
    }

    [Configure]
    public void ConfigureAll(Solution.Configuration conf, Target target)
    {
        conf.SolutionPath = @"[solution.SharpmakeCsPath]\generated";

        conf.AddProject<Project_Muffin>(target);
        conf.AddProject<Project_Calamity>(target);

        conf.SetStartupProject<Project_Calamity>();

        
    }
}