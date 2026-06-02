using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_GLM : MuffinProject
{
    public Project_GLM()
    {
        Name = "GLM";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    [Configure]
    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/glm");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("glm/test", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("glm/util", @".*"));

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);
    }
}