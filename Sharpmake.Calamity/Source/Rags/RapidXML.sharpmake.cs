using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_RapidXML : MuffinProject
{
    public Project_RapidXML()
    {
        Name = "RapidXML";
        SourceRootPath = "[project.Path_Rags]/RapidXML";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.Output = Configuration.OutputType.Utility;
        conf.IncludePaths.Add("[project.SourceRootPath]/Rapidxml");

        conf.SourceFilesBuildExcludeRegex.Add("RapidXML.Tests/*");
    }
}