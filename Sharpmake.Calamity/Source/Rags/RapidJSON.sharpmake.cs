using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_RapidJSON : MuffinProject
{
    public Project_RapidJSON()
    {
        Name = "RapidJSON";
        SourceRootPath = "[project.Path_Rags]/RapidJSON/include";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.Output = Configuration.OutputType.Utility;
        conf.IncludePaths.Add("[project.Path_Rags]/RapidJSON/include");

        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);
        conf.Options.Add(Options.Vc.Compiler.Optimization.FullOptimization);
    }
}