using System.IO; 
using Sharpmake; 

[module: Sharpmake.Include("../Rags/Imgui.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/Lua.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/RakNet.sharpmake.cs")]
[module: Sharpmake.Include("../Rags/GLM.sharpmake.cs")]

[Generate]
public class Project_Muffin : MuffinProject
{
    public Project_Muffin()
    {
        Name = "MuffinEngine";
        SourceRootPath = @"[project.SharpmakeCsPath]";
    }

    public override void ConfigureAll(Project.Configuration conf, Target target)
    {    
        base.ConfigureAll(conf, target);

        conf.AddPublicDependency<Project_Imgui>(target);
        conf.AddPublicDependency<Project_Lua>(target);
        conf.AddPublicDependency<Project_RakNet>(target);
        conf.AddPublicDependency<Project_GLM>(target);
    }
}