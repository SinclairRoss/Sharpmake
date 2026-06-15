using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("MuffinEngine.sharpmake.cs")]

[Generate]
public class Project_Calamity : MuffinProject
{
    public Project_Calamity()
    {
        Name = "Calamity";
        SourceRootPath = @"[project.Path_Workspace]/Calamity/Calamity/Source";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);
        conf.Output = Configuration.OutputType.Exe;

        conf.AddPublicDependency<Project_Muffin>(target);

        conf.IncludePaths.Add("[project.SourceRootPath]");
        conf.Defines.Add("NOGDI");

        conf.SourceFilesBuildExcludeRegex.Add("./*_Depricated/*");
    }
}