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

## Setup

Simply place this folder inside your `game/data` folder of your project, as if it was a module. Then run
CMake configure with `TORQUE_ENTRY_FUNCTION` set to `CSharpEntryFunction`.

CMake will generate necessary templates to inject the project name and relevant paths in, then it will
find all `*.cs` files and add them to the VS Solution.

See the [wiki](https://github.com/lukaspj/T3DSharp/wiki) for more information.
