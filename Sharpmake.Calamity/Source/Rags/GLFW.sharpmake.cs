using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_GLFW : MuffinProject
{
    public Project_GLFW()
    {
        Name = "GLFW";
        SourceRootPath = @"[project.Path_Rags]/GLFW/src/";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/GLFW/include/");
    }
}
