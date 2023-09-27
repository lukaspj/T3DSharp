# T3DSharp - A C# scripting layer for Torque3D

This project consists of three parts:

* T3DSharpFramework
* T3DSharpGenerator
* T3DSharpGame

The _framework_ is a library of basic functionality and definitions necessary to interop with Torque3D nicely.

The _generator_ generates the class library by analysing the EngineAPI XML Export that Torque3D can produce.

The _game_ is a small C# application that initializes Torque3D and implements a C# version of `main.tscript`.

## Setup

Simply place this folder inside your `game/data` folder of your project, as if it was a module. Then run _cmake_
with the `TORQUE_DYNAMIC_LIBRARY` flag set to true.

CMake will generate necessary templates to inject the project name and relevant paths in, then it will
find all `*.csproj` files and add them to a solution that will be created in this folder.

See the [wiki](https://github.com/lukaspj/T3DSharp/wiki) for more information.
