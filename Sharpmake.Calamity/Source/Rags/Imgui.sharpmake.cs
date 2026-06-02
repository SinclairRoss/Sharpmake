using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_Imgui : MuffinProject
{
    public Project_Imgui()
    {
        Name = "Imgui";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    [Configure]
    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]");

        conf.IncludePaths.Add("[project.SharpmakeCsPath]/../SDL/2.0.18/include");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/../FreeType/2.12.1/include");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("examples", @".*"));
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdl3.cpp");
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdlrenderer2.cpp");
    }
}