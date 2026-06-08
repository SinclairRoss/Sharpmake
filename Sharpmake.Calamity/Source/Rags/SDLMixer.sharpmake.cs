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
    }
}