using System.IO; 
using Sharpmake; 

[Generate]
public class Project_GLM : Project
{
    public Project_GLM()
    {
        Name = "GLM";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    [Configure]
    public void ConfigureLib(Project.Configuration conf, Target target)
    {
        conf.Name = "[target.Optimization]_[target.OutputType]";
        conf.TargetPath = @"[project.SharpmakeCsPath]/../../Library/[target.Platform]/[conf.Name]";

        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/glm");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("glm/test", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("glm/util", @".*"));

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);
    }
}