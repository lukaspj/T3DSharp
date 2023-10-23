project(T3DSharpFramework LANGUAGES CSharp)

SET(T3DSharpGameSlnPath "${T3DSharp_BINARY_DIR}/T3DSharpGame/T3DSharpGame.sln")
configure_file(CMakeSettings.cs.in ${CMAKE_CURRENT_BINARY_DIR}/CMakeSettings.cs)

FILE(GLOB_RECURSE GENERATED_SRCS Generated/*.cs)

SET(CMAKE_CSharp_FLAGS "${CMAKE_CSharp_FLAGS} /unsafe")

add_library(${PROJECT_NAME} SHARED
  CMakeLists.txt
  Directory.Build.targets
  "${CMAKE_CURRENT_BINARY_DIR}/CMakeSettings.cs"

  # EditAndContinue
  Reloading/MsBuildReloader.cs
  Reloading/ReloadContext.cs
  Reloading/AssemblyReloadedEventArgs.cs

  # Engine
  Engine/ConsoleObjectBase.cs
  Engine/IDataBlock.cs
  Engine/IEngineStruct.cs
  Engine/ISimObject.cs
  Engine/ISimPersistId.cs
  Engine/Sim.cs
  Engine/SimDictionary.cs
  Engine/UnknownSimObject.cs

  # Structs
  Engine/Structs/AngAxisF.cs
  Engine/Structs/ColorF.cs
  Engine/Structs/ColorI.cs
  Engine/Structs/MatrixF.cs
  Engine/Structs/Point2F.cs
  Engine/Structs/Point2I.cs
  Engine/Structs/Point3F.cs
  Engine/Structs/RectF.cs
  Engine/Structs/RectSpacingI.cs
  Engine/Structs/TransformF.cs

  # Util
  Engine/Util/DynamicFieldVector.cs
  Engine/Util/EngineExtensions.cs
  Engine/Util/Text.cs

  # Interop
  Interop/Attributes.cs
  Interop/CustomMarshalling.cs
  Interop/DLLLoadUtils.cs
  Interop/EngineCallbacks.cs
  Interop/Exceptions.cs
  Interop/Initializer.cs
  Interop/Torque3D.cs

  # Generated
  ${GENERATED_SRCS}
)



# Set CLR assembly properties.
SET_TARGET_PROPERTIES(${PROJECT_NAME} PROPERTIES
    VS_DOTNET_REFERENCES "System;System.Core;System.Runtime.InteropServices"
    VS_GLOBAL_ROOTNAMESPACE ${PROJECT_NAME}
    VS_GLOBAL_GenerateAssemblyInfo false
    VS_GLOBAL_PlatformTarget "x64"
    VS_GLOBAL_EnableDynamicLoading true
)

configure_file("${CMAKE_CURRENT_SOURCE_DIR}/Directory.Build.targets" "${CMAKE_INSTALL_LIBRARY_DIR}" COPYONLY)

# Setup installer.
INSTALL(TARGETS ${PROJECT_NAME} EXPORT ${PROJECT_NAME}Config
    ARCHIVE DESTINATION ${CMAKE_INSTALL_LIBRARY_DIR}
    LIBRARY DESTINATION ${CMAKE_INSTALL_LIBRARY_DIR}
    RUNTIME DESTINATION ${CMAKE_INSTALL_BINARY_DIR}
    INCLUDES DESTINATION ${CMAKE_INSTALL_INCLUDE_DIR}
)

# Export config.
INSTALL(EXPORT ${PROJECT_NAME}Config DESTINATION ${CMAKE_CURRENT_SOURCE_DIR})
EXPORT(TARGETS ${PROJECT_NAME} FILE ${PROJECT_NAME}Config.cmake)

set(TORQUE_LINK_LIBRARIES ${TORQUE_LINK_LIBRARIES} "${PROJECT_NAME}")
set(TORQUE_LINK_LIBRARIES ${TORQUE_LINK_LIBRARIES} PARENT_SCOPE)

IF(NOT CMAKE_BUILD_TYPE OR CMAKE_BUILD_TYPE MATCHES "Debug|RelWithDebInfo")
   SET_PROPERTY(TARGET ${PROJECT_NAME} PROPERTY VS_GLOBAL_EnableUnmanagedDebugging "true")
ENDIF (NOT CMAKE_BUILD_TYPE OR CMAKE_BUILD_TYPE MATCHES "Debug|RelWithDebInfo")
