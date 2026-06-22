using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_GLM : MuffinProject
{
    public Project_GLM()
    {
        Name = "GLM";
        SourceRootPath = @"[project.Path_Rags]/GLM/";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.SourceRootPath]");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"glm\\test", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"glm\\util", @".*"));
        
        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);
        conf.Options.Add(Options.Vc.Compiler.Optimization.FullOptimization);
    }
}
