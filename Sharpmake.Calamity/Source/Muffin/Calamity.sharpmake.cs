using System.IO; 
using Sharpmake; 

[Generate]
public class Project_Calamity : MuffinProject
{
    public Project_Calamity()
    {
        Name = "Calamity";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);
    }
}