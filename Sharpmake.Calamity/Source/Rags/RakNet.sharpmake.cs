using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_RakNet : MuffinProject
{
    public Project_RakNet()
    {
        Name = "RakNet";
        SourceRootPath = @"[project.SharpmakeCsPath]";

        AddTargets(new Target(
            Platform.win64,
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release, 
            OutputType.Lib));
    }

    [Configure]
    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/Source");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/DependentExtensions/openssl-1.0.0d/include");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/DependentExtensions");

    }
}