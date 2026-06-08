using Sharpmake;

[module: Sharpmake.Include("Muffin/Calamity.sharpmake.cs")]

[Generate]
public class Solution_Calamity : Solution
{
    public Solution_Calamity()
    {
        Name = "349";
        AddTargets(new Target(
            Platform.win64,
            DevEnv.vs2026,
            Optimization.Debug | Optimization.Release));
    }

    [Configure]
    public void ConfigureAll(Solution.Configuration conf, Target target)
    {
        conf.SolutionPath = "[solution.Path_Workspace]/Solutions/[solution.Name]";

        conf.AddProject<Project_Calamity>(target);
        conf.SetStartupProject<Project_Calamity>();  
    }
 
    private const string _Path_Workspace = "C:/Users/S-Ros/Documents/Ragamuffin";                                         
    public string Path_Workspace
    {
        get { return _Path_Workspace; }
    }

    private const string _Path_Build = "[solution.Path_Workspace]/Build";                                         
    public string Path_Build
    {
        get { return _Path_Build; }
    }
}