using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_Glad : MuffinProject
{
    public Project_Glad()
    {
        Name = "GLAD";
        SourceRootPath = "[project.Path_Rags]/glad";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/glad/include");
        
        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);
        conf.Options.Add(Options.Vc.Compiler.Optimization.FullOptimization);
    }
}