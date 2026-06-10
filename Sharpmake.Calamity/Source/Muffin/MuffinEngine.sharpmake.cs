using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../Rags/Imgui.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/Lua.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/RakNet.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/GLM.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/GLFW.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/Box2D.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/RapidJSON.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/RapidXML.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/SDL.sharpmake.cs")]

[Generate]
public class Project_Muffin : MuffinProject
{
    public Project_Muffin()
    {
        Name = "MuffinEngine";
        SourceRootPath = @"[project.Path_Workspace]/Calamity/Muffin/Source";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {    
        base.ConfigureAll(conf, target);

        conf.IncludePaths.Add("[project.SourceRootPath]");
        
        conf.AddPublicDependency<Project_Imgui>(target);
        conf.AddPublicDependency<Project_Lua>(target);
        conf.AddPublicDependency<Project_RakNet>(target);
        conf.AddPublicDependency<Project_GLM>(target);
        conf.AddPublicDependency<Project_GLFW>(target);
        conf.AddPublicDependency<Project_Box2D>(target);
        conf.AddPublicDependency<Project_RapidJSON>(target);
        conf.AddPublicDependency<Project_RapidXML>(target);
        conf.AddPublicDependency<Project_SDL>(target);
    }
}