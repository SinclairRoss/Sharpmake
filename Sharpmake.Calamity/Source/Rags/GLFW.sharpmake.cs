using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_GLFW : MuffinProject
{
    public Project_GLFW()
    {
        Name = "GLFW";
        SourceRootPath = @"[project.Path_Rags]/GLFW/";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/GLFW/include/");
        conf.IncludePaths.Add("[project.Path_Rags]/GLFW/deps");

        if(target.Platform != Platform.linux)
        {
            conf.SourceFilesBuildExcludeRegex.Add("src/linux_*");
        }
        
        if(target.Platform != Platform.win32 && target.Platform != Platform.win64)
        {
            conf.SourceFilesBuildExcludeRegex.Add("src/win32_*");
        }

        if(target.Platform != Platform.mac)
        {
            conf.SourceFilesBuildExcludeRegex.Add("src/macos_*");
        }

        conf.SourceFilesBuildExcludeRegex.Add("src/posix_*");
        conf.SourceFilesBuildExcludeRegex.Add("src/cocoa_*");
        conf.SourceFilesBuildExcludeRegex.Add("src/wl_*");
        conf.SourceFilesBuildExcludeRegex.Add("src/x11*");
        conf.SourceFilesBuildExcludeRegex.Add("src/xkb*");
        
        conf.SourceFilesBuildExcludeRegex.Add("./examples/*");
        conf.SourceFilesBuildExcludeRegex.Add("./tests/*");
        
        conf.Defines.Add("_GLFW_WIN32");

        conf.Options.Add(Options.Vc.Compiler.CppLanguageStandard.CPP98);
        conf.Options.Add(Options.Vc.Compiler.CLanguageStandard.Legacy);
    }
}
