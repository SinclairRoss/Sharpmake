using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_Lua : MuffinProject
{
    public Project_Lua()
    {
        Name = "Lua";
        SourceRootPath = @"[project.Path_Rags]/Lua/";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        //conf.IncludePaths.Add("[project.SharpmakeCsPath]/5.4.7/src");

       // conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine("5.4.4", @".*"));
        conf.IncludePaths.Add("[project.SourceRootPath]");
        conf.SourceFilesBuildExclude.Add("[project.SourceRootPath]/onelua.c");
        conf.SourceFilesBuildExcludeRegex.Add("./testes/*");

        conf.Defines.Add("MAKE_LIB");
 
    }
}