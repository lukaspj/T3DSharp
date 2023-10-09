cmake_minimum_required(VERSION 3.16)
project(T3DSharp LANGUAGES CSharp)

torqueAddSourceDirectories("${POSSIBLE_PROJECT_ABSOLUTEPATH}/source")

# Set global .NET version
SET(CMAKE_DOTNET_TARGET_FRAMEWORK "net7.0")

# Set the C# language version for all projects.
SET(CMAKE_CSharp_FLAGS "/langversion:10")

# Set SDK version
SET(CMAKE_DOTNET_SDK "Microsoft.NET.Sdk")

include(nethost.cmake)
include(t3dsharp.cmake)

set(TORQUE_LINK_LIBRARIES ${TORQUE_LINK_LIBRARIES} PARENT_SCOPE)
set(TORQUE_INCLUDE_DIRECTORIES ${TORQUE_INCLUDE_DIRECTORIES} PARENT_SCOPE)

# https://github.com/crud89/DotNetWithCMake
IF(NOT CMAKE_BUILD_TYPE OR CMAKE_BUILD_TYPE MATCHES "Debug|RelWithDebInfo")
   set(TORQUE_LINK_OPTIONS ${TORQUE_LINK_OPTIONS} /DEBUG /ASSEMBLYDEBUG PARENT_SCOPE)
   set(TORQUE_TARGET_PROPERTIES ${TORQUE_TARGET_PROPERTIES} VS_GLOBAL_EnableUnmanagedDebugging "true" PARENT_SCOPE)
ENDIF (NOT CMAKE_BUILD_TYPE OR CMAKE_BUILD_TYPE MATCHES "Debug|RelWithDebInfo")
