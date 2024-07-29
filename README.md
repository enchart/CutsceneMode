# Cutscene Mode
A small Project Arrhythmia mod that hides the players and the player GUI.

## Install
1. Install BepInEx 6 (TODO)
2. Open the [latest release](https://github.com/enchart/CutsceneMode/releases/latest) page and download `CutsceneMode.dll`
3. Put the downloaded file in the `Project Arrhythmia/BepInEx/plugins` folder

## Build
1. Clone the project
2. To automatically copy the mod DLL to the `plugins` folder after build:
   - Copy the file `Directory.Build.props.example` with the name `Directory.Build.props`
   - Change the `GamePath` property inside the file to your Project Arrhythmia folder (otherwise, leave it empty)
3. Copy the DLLs from the `Project Arrhythmia/BepInEx/interop` folder to the project's `lib` folder
4. Build like your usual .NET class library