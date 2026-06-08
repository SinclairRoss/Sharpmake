using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_GLEW : MuffinProject
{
    public Project_GLEW()
    {
        Name = "GLEW";
        SourceRootPath = @"[project.Path_Rags]/GLEW/2.1.0/";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.SourceRootPath]/include");
    }
}
