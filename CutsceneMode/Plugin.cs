using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;

namespace CutsceneMode;

[BepInPlugin(Guid, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    private const string Guid = "com.enchart.cutscenemode";
    
    internal new static ManualLogSource Log;

    public override void Load()
    {
        Log = base.Log;
        Log.LogInfo($"Plugin {Guid} is loaded!");
        Log.LogInfo($"Patching methods...");
        new Harmony(Guid).PatchAll(Assembly.GetExecutingAssembly());
    }
}

[HarmonyPatch(typeof(EditorManager))]
public static class EditorManagerPatch
{
    [HarmonyPatch(nameof(EditorManager.Awake))]
    [HarmonyPostfix]
    public static void AwakePostfix(EditorManager __instance)
    {
        Plugin.Log.LogInfo("Hiding players and player GUI...");
        GameObject.Find("Player GUI").SetActive(false);
        GameObject.Find("Game Systems/Players").transform.position = new Vector3(0.0f, 0.0f, -1000.0f);
    }
}