using System.IO; 
using Sharpmake; 

[Generate]
public class Project_RakNet : Project
{
    public Project_RakNet()
    {
        Name = "RakNet";
        SourceRootPath = @"[project.SharpmakeCsPath]";

        AddTargets(new Target(
            Platform.win64,
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release, 
            OutputType.Lib | OutputType.RunLocal));
    }

    [Configure]
    public void ConfigureLib(Project.Configuration conf, Target target)
    {
        conf.Name = "[target.Optimization]_[target.OutputType]";
        conf.TargetPath = @"[project.SharpmakeCsPath]/../../Library/[target.Platform]/[conf.Name]";

        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.SharpmakeCsPath]";
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/Source");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/DependentExtensions/openssl-1.0.0d/include");
        conf.IncludePaths.Add("[project.SharpmakeCsPath]/DependentExtensions");

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);    
    }
}