using System.IO; 
using Sharpmake; 

[Generate]
public class MuffinProject : Project
{
    public MuffinProject()
    {
        Name = "UnnamedProject";
        SourceRootPath = "";

        AddTargets(new Target(
            Platform.win64,
            DevEnv.vs2026,
            Optimization.Debug | Optimization.Release,
            OutputType.Lib,
            Blob.NoBlob,
            BuildSystem.MSBuild));
    }

    [Configure]
    public virtual void ConfigureAll(Project.Configuration conf, Target target)
    {
        conf.Name = "[target.Optimization]_[target.OutputType]";
        conf.TargetPath = @"[project.Path_Build]/Bin/[project.Name]";
        conf.IntermediatePath = @"[project.Path_Build]/Intermediate/[project.Name]";
        
        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.Path_Workspace]/Solutions/349";

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);

        conf.Defines.Add("NOGDI");
    }

    private const string _Path_Rags = "[project.Path_Workspace]/Calamity/Rags";                                         
    public string Path_Rags
    {
        get { return _Path_Rags; }
    }

    private const string _Path_Workspace = "C:/Users/S-Ros/Documents/Ragamuffin";                                         
    public string Path_Workspace
    {
        get { return _Path_Workspace; }
    }

    private const string _Path_Build = "[project.Path_Workspace]/Build";                                         
    public string Path_Build
    {
        get { return _Path_Build; }
    }
}
