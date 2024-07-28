using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace CutsceneMode;

[BepInPlugin(Guid, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public const string Guid = "com.enchart.cutscenemode";
    
    internal new static ManualLogSource Log;

    public override void Load()
    {
        Log = base.Log;
        Log.LogInfo($"Plugin {Guid} is loaded!");

        var harmony = new Harmony(Guid);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
    }
}


