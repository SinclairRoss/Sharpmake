using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_Box2D : MuffinProject
{
    public Project_Box2D()
    {
        Name = "Box2D";
        SourceRootPath = "[project.Path_Rags]/box2d/src";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/box2d/include");
    }
}