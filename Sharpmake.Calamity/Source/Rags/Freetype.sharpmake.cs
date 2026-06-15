using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_Freetype : MuffinProject
{
    public Project_Freetype()
    {
        Name = "Freetype";
        SourceRootPath = "[project.Path_Rags]/Freetype/src";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/Freetype/include");
    }
}