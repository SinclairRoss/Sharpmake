using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/SDLMixer.sharpmake.cs")]

[Generate]
public class Project_SDL : MuffinProject
{
    public Project_SDL()
    {
        Name = "SDL";
        SourceRootPath = "[project.Path_Rags]/SDL/src";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/SDL/include");

        conf.SourceFilesBuildExclude.Add("[project.SourceRootPath]/audio/ps2/SDL_ps2audio.c");

        conf.SourceFilesBuildExcludeRegex.Add("./android/*");
        conf.SourceFilesBuildExcludeRegex.Add("./freebsd/*");
        conf.SourceFilesBuildExcludeRegex.Add("./gdk/*");
        conf.SourceFilesBuildExcludeRegex.Add("./linux/*");
        conf.SourceFilesBuildExcludeRegex.Add("./openbsd/*");
        conf.SourceFilesBuildExcludeRegex.Add("./os2/*");
        conf.SourceFilesBuildExcludeRegex.Add("./ps2/*");
        conf.SourceFilesBuildExcludeRegex.Add("./unix/*");
        conf.SourceFilesBuildExcludeRegex.Add("./winrt/*");
        conf.SourceFilesBuildExcludeRegex.Add("./vita/*");
        conf.SourceFilesBuildExcludeRegex.Add("./psp/*");
        conf.SourceFilesBuildExcludeRegex.Add("./n3ds/*");
        conf.SourceFilesBuildExcludeRegex.Add("./macosx/*");
        conf.SourceFilesBuildExcludeRegex.Add("./emscripten/*");
        conf.SourceFilesBuildExcludeRegex.Add("./haiku/*");
        conf.SourceFilesBuildExcludeRegex.Add("./dummy/*");
        conf.SourceFilesBuildExcludeRegex.Add("./qnx/*");
        conf.SourceFilesBuildExcludeRegex.Add("./mac/*");
        conf.SourceFilesBuildExcludeRegex.Add("./ngage/*");
        conf.SourceFilesBuildExcludeRegex.Add("./darwin/*");
        conf.SourceFilesBuildExcludeRegex.Add("./vivante/*");
        conf.SourceFilesBuildExcludeRegex.Add("./wayland/*");
        conf.SourceFilesBuildExcludeRegex.Add("./yuv2rgb/*");
        conf.SourceFilesBuildExcludeRegex.Add("./offscreen/*");
        conf.SourceFilesBuildExcludeRegex.Add("./nacl/*");
        conf.SourceFilesBuildExcludeRegex.Add("./arm/*");
        conf.SourceFilesBuildExcludeRegex.Add("./cocoa/*");
        conf.SourceFilesBuildExcludeRegex.Add("./directfb/*");
        conf.SourceFilesBuildExcludeRegex.Add("./khronos/*");
        conf.SourceFilesBuildExcludeRegex.Add("./kmsdrm/*");
        conf.SourceFilesBuildExcludeRegex.Add("./pandora/*");
        conf.SourceFilesBuildExcludeRegex.Add("./raspberry/*");
        conf.SourceFilesBuildExcludeRegex.Add("./riscos/*");
        conf.SourceFilesBuildExcludeRegex.Add("./uikit/*");
        conf.SourceFilesBuildExcludeRegex.Add("./nacl/*");
        conf.SourceFilesBuildExcludeRegex.Add("./x11/*");
        conf.SourceFilesBuildExcludeRegex.Add("./direct3d11/*");
        conf.SourceFilesBuildExcludeRegex.Add("./pthread/*");
        conf.SourceFilesBuildExcludeRegex.Add("./generic/*");    

        conf.SourceFilesBuildExcludeRegex.Add("./stdcpp/*"); 
       // conf.SourceFilesBuildExcludeRegex.Add("./thread/windows/*");    

        conf.SourceFilesBuildExcludeRegex.Add("hidapi/*");

        conf.SourceFilesBuildExcludeRegex.Add("./test/*");
        
        conf.Options.add(Options.Vc.General.WarningLevel.Level0);
    }
}