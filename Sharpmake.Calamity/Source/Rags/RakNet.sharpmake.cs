using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_RakNet : MuffinProject
{
    public Project_RakNet()
    {
        Name = "RakNet";
        SourceRootPath = @"[project.Path_Rags]/RakNet/Source";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/RakNet/Source");
        conf.IncludePaths.Add("[project.Path_Rags]/RakNet/DependentExtensions/openssl-1.0.0d/include");
        conf.IncludePaths.Add("[project.Path_Rags]/RakNet/DependentExtensions");

        conf.Defines.Add("_RAKNET_LIB");
        conf.ExportDefines.Add("_RAKNET_LIB");

        conf.SourceFilesBuildExcludeRegex.Add("./DependentExtensions/*");
        conf.SourceFilesBuildExcludeRegex.Add("./Samples/*");
        conf.SourceFilesBuildExcludeRegex.Add("./cat/*");

        conf.LibraryFiles.Add("Ws2_32.lib");

        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);
        conf.Options.Add(Options.Vc.Compiler.Optimization.FullOptimization);
    }
}