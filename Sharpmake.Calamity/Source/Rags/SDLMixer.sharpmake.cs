using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../MuffinProject.sharpmake.cs")]

[Generate]
public class Project_SDLMixer : MuffinProject
{
    public Project_SDLMixer()
    {
        Name = "SDL_Mixer";
        SourceRootPath = "[project.Path_Rags]/SDL_mixer/src";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.Path_Rags]/SDL_mixer/include");
        conf.IncludePrivatePaths.Add("[project.Path_Rags]/SDL_mixer/src/codecs");
        conf.IncludePrivatePaths.Add("[project.Path_Rags]/SDL_mixer/src");

        conf.Defines.Add("MUSIC_WAV");

        conf.AddPublicDependency<Project_SDL>(target);

        conf.Options.Add(Options.Vc.Compiler.Optimization.FullOptimization);
        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);
    }
}