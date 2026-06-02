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
            DevEnv.vs2022,
            Optimization.Debug | Optimization.Release, 
            OutputType.Lib));
    }

    [Configure]
    public virtual void ConfigureAll(Project.Configuration conf, Target target)
    {
        conf.Name = "[target.Optimization]_[target.OutputType]";
        conf.TargetPath = @"[project.Path_WorkSpace]/Bin/";
        //        conf.TargetPath = @"[project.SharpmakeCsPath]/../../Library/[target.Platform]/[conf.Name]";

        conf.Output = Configuration.OutputType.Lib;
        conf.ProjectPath = "[project.Path_WorkSpace]/Solutions";

        conf.Options.Add(Options.Vc.Librarian.TreatLibWarningAsErrors.Enable);
        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP20);
    }

    private string _Path_Workspace = "C:/Users/S-Ros/Documents/Ragamuffin";                                         
    public string Path_Workspace
    {
        get { return _Path_Workspace; }
    }
}