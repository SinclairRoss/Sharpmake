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


        conf.SourceFilesBuildExcludeRegex.Add("video/arm/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/cocoa/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/directfb/*");
        //conf.SourceFilesBuildExcludeRegex.Add("video/dummy/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/emscripten/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/haiku/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/khronos/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/kmsdrm/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/n3ds/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/nacl/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/ngage/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/offscreen/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/os2/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/pandora/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/ps2/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/psp/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/qnx/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/raspberry/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/riscos/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/uikit/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/vita/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/vivante/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/wayland/*");
        conf.SourceFilesBuildExcludeRegex.Add("video/x11/*");
        
        conf.SourceFilesBuildExcludeRegex.Add("./freebsd/*");
        conf.SourceFilesBuildExcludeRegex.Add("./gdk/*");
        conf.SourceFilesBuildExcludeRegex.Add("./openbsd/*");
        conf.SourceFilesBuildExcludeRegex.Add("./os2/*");
        conf.SourceFilesBuildExcludeRegex.Add("./ps2/*");
        conf.SourceFilesBuildExcludeRegex.Add("./unix/*");
        conf.SourceFilesBuildExcludeRegex.Add("./winrt/*");
        conf.SourceFilesBuildExcludeRegex.Add("./vita/*");
        conf.SourceFilesBuildExcludeRegex.Add("./psp/*");
        conf.SourceFilesBuildExcludeRegex.Add("./n3ds/*");
        conf.SourceFilesBuildExcludeRegex.Add("./macosx/*");
        conf.SourceFilesBuildExcludeRegex.Add("./haiku/*");
        conf.SourceFilesBuildExcludeRegex.Add("./qnx/*");
        conf.SourceFilesBuildExcludeRegex.Add("./mac/*");
        conf.SourceFilesBuildExcludeRegex.Add("./ngage/*");
        conf.SourceFilesBuildExcludeRegex.Add("./darwin/*");
        conf.SourceFilesBuildExcludeRegex.Add("./vivante/*");
        conf.SourceFilesBuildExcludeRegex.Add("./wayland/*");
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
        conf.SourceFilesBuildExcludeRegex.Add("./pthread/*");
        conf.SourceFilesBuildExcludeRegex.Add("./dlopen/*");
        conf.SourceFilesBuildExcludeRegex.Add("./stdcpp/*"); 
        conf.SourceFilesBuildExcludeRegex.Add("libusb/*");

        conf.SourceFilesBuildExcludeRegex.Add("./test/*");

        conf.SourceFilesBuildExcludeRegex.Add("hidtest/*");

        conf.SourceFilesBuildExclude.Add("hidapi/windows/hid.c");

        //conf.SourceFilesBuildExclude.Add("thread/generic/SDL_syscond.c");
        conf.SourceFilesBuildExclude.Add("thread/generic/SDL_sysmutex.c");
        conf.SourceFilesBuildExclude.Add("thread/generic/SDL_syssem.c");
        conf.SourceFilesBuildExclude.Add("thread/generic/SDL_systhread.c");
        conf.SourceFilesBuildExclude.Add("thread/generic/SDL_systls.c");

        conf.SourceFilesBuildExcludeRegex.Add("main/*");

        const bool dummy = false;
        if(!dummy)
        {   
            conf.SourceFilesBuildExclude.Add("filesystem/dummy/SDL_sysfilesystem.c");
            conf.SourceFilesBuildExclude.Add("loadso/dummy/SDL_sysloadso.c");
            conf.SourceFilesBuildExclude.Add("locale/dummy/SDL_syslocale.c"); 
            conf.SourceFilesBuildExclude.Add("misc/dummy/SDL_sysurl.c");     
            conf.SourceFilesBuildExclude.Add("timer/dummy/SDL_systimer.c");     
        }

        if(conf.Platform != Platform.linux)
        {
            conf.SourceFilesBuildExcludeRegex.Add("core/linux/*");
            conf.SourceFilesBuildExcludeRegex.Add("haptic/linux/*");
            conf.SourceFilesBuildExcludeRegex.Add("hidapi/linux/*");
            conf.SourceFilesBuildExcludeRegex.Add("joystick/linux/*");
            conf.SourceFilesBuildExcludeRegex.Add("power/linux/*");
        }
        
        const bool winrt = false;
        if (!winrt)
        {
            conf.SourceFilesBuildExcludeRegex.Add("core/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("filesystem/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("locale/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("main/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("misc/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("power/winrt/*");
            conf.SourceFilesBuildExcludeRegex.Add("video/winrt/*");

            conf.SourceFilesBuildExclude.Add("audio/wasapi/SDL_wasapi_winrt.cpp");
            conf.SourceFilesBuildExclude.Add("render/direct3d11/SDL_render_winrt.cpp");
        }

        const bool android = false;
        if (!android)
        {
            conf.SourceFilesBuildExcludeRegex.Add("audio/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("core/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("filesystem/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("haptic/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("hidapi/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("joystick/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("locale/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("main/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("misc/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("power/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("sensor/android/*");
            conf.SourceFilesBuildExcludeRegex.Add("video/android/*");

            conf.SourceFilesBuildExclude.Add("audio/wasapi/SDL_wasapi_winrt.cpp");
            conf.SourceFilesBuildExclude.Add("render/direct3d11/SDL_render_winrt.cpp");
        }

        const bool emscripten = false;
        if (!emscripten)
        {
            conf.SourceFilesBuildExcludeRegex.Add("audio/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("filesystem/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("joystick/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("locale/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("misc/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("power/emscripten/*");
            conf.SourceFilesBuildExcludeRegex.Add("video/emscripten/*");

            conf.SourceFilesBuildExclude.Add("audio/wasapi/SDL_wasapi_winrt.cpp");
            conf.SourceFilesBuildExclude.Add("render/direct3d11/SDL_render_winrt.cpp");
        }
        
        conf.Options.Add(Options.Vc.General.WarningLevel.Level0);

        conf.LibraryFiles.Add("Cfgmgr32.lib");
        conf.LibraryFiles.Add("Version.lib");
        conf.LibraryFiles.Add("SetupAPI.lib");        
    }
}