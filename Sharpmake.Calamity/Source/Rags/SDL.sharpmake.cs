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

        conf.AddPublicDependency<Project_SDLMixer>(target);


        conf.SourceFilesBuildExclude.Add("[project.SourceRootPath]/audio/ps2/SDL_ps2audio.c");

        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\android", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\freebsd", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\gdk", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\linux", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\openbsd", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\os2", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\unix", @".*"));
        conf.SourceFilesBuildExcludeRegex.Add(Util.RegexPathCombine(@"core\\winrt", @".*"));

    }
}