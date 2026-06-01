using System.IO; 
using Sharpmake; 

[Generate]
public class Project_Lua : Project
{
    public Project_Lua()
    {
        Name = "Lua";
        SourceRootPath = @"[project.SharpmakeCsPath]";

        AddTargets(new Target(
            Platform.win64,
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release, 
            OutputType.Lib | OutputType.RunLocal));
    }

    [Configure]
    public void ConfigureLib(Project.Configuration conf, Target target)
    {
        conf.Name = "[target.Optimization]_[target.OutputType]";
        conf.TargetPath = @"[project.SharpmakeCsPath]/../../Library/[target.Platform]/[conf.Name]";

        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/5.4.7/src");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("5.4.4", @".*"));
        conf.SourceFilesBuildExclude.Add("[project.SharpmakeCsPath]/5.4.7/src/luac.c");

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);    
    }
}