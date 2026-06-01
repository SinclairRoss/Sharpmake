using System.IO; 
using Sharpmake; 

[Generate]
public class Project_Imgui : Project
{
    public Project_Imgui()
    {
        Name = "Imgui";
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
        conf.IncludePaths.Add("[project.SharpmakeCsPath]");

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);

        conf.IncludePaths.Add("[project.SharpmakeCsPath]/../SDL/2.0.18/include");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/../FreeType/2.12.1/include");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("examples", @".*"));
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdl3.cpp");
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdlrenderer2.cpp");
    }
}