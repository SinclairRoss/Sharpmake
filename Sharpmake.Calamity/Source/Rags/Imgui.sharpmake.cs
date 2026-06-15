using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/Freetype.sharpmake.cs")]

[Generate]
public class Project_Imgui : MuffinProject
{
    public Project_Imgui()
    {
        Name = "Imgui";
        SourceRootPath = "[project.Path_Rags]/Imgui";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.SourceRootPath]");
        conf.IncludePaths.Add("[project.Path_Rags]/SDL/2.0.18/include");
        conf.IncludePaths.Add("[project.Path_Rags]/FreeType/include");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("examples", @".*"));
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdl3.cpp");
        conf.SourceFilesBuildExclude.Add("backends/imgui_impl_sdlrenderer2.cpp");

        conf.AddPublicDependency<Project_SDL>(target);
        //conf.AddPublicDependency<Project_Freetype>(target);
    }
}