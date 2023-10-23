# T3DSharp - A C# scripting layer for Torque3D

## _Note: Only tested on Windows_
_While nothing stops this from working on all platforms, the project, as well as the
Developer Experience around it, has only been tested on Windows._

This project consists of three parts:

* T3DSharpFramework
* T3DSharpGenerator
* T3DSharpGame

The _framework_ is a library of basic functionality and definitions necessary to interop with Torque3D nicely.

The _generator_ generates the class library by analysing the EngineAPI XML Export that Torque3D can produce.

The _game_ is a small C# application that initializes Torque3D and implements a C# version of `main.tscript`.

This is an **experimental package**, what that means is that it should work fine but it hasn't really been used
much and you might find edge-cases, odd behaviours and what-not.
Memory-leaks is especially a thing to look out for.

Furthermore, based on feedback, this project might be taken in different directions. Main things being
considered right now is:
* Right now T3DSharpGame is a mono-dll for all game-logic. Should we be able to support more DLLs, like
  one per module.
* We could consider using a C# Scripting (.csx) based approach instead, so that we can reload individual
  files and use whatever Torque3D implements for re-executing script files by implementing the `exec`
  functionality based on file extensions.

## Setup
Simply place this folder inside your `game/data` folder of your project, as if it was a module. Then run
CMake configure with `TORQUE_ENTRY_FUNCTION` set to `CSharpEntryFunction`.

CMake will generate necessary templates to inject the project name and relevant paths in, then it will
find all `*.cs` files and add them to the VS Solution.

## Current limitations
* Ground work needs to be done for this to work in Linux/Mac (mostly CMake configuration)
* Visual Studio supports debugging C++ and C# simultaneously, but other IDE's may not have that
  capability. ([For example Rider doesn't support hosted .NET Code](https://www.jetbrains.com/help/rider/Debugging_Code.html))
  * VS Code should be an option on Linux/Mac
* Building .NET applications produces a lot of clutter in the `game` folder that is yet to be cleaned up
* The project has not implemented "release" workflows yet, so for example building without hot-reload
  capability is not a priority right now

## Hot-Reloading
Currently, you can hot-reload code by running `ReloadT3DSharpGame()` in the console.

## Usage
See the [wiki](https://github.com/lukaspj/T3DSharp/wiki) for examples of how to write code using this setup.
