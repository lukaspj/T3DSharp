project(T3DSharpGame LANGUAGES CSharp)

file(GLOB_RECURSE tmp_files ${CMAKE_CURRENT_SOURCE_DIR} ${TORQUE_APP_GAME_DIRECTORY}/*.cs)

# Annoying assembly info in obj dirs
list(FILTER tmp_files EXCLUDE REGEX ".*AssemblyInfo.cs")
list(FILTER tmp_files EXCLUDE REGEX ".*AssemblyAttributes.cs")
foreach(entry ${tmp_files})
   get_filename_component( tmp_dir ${entry} DIRECTORY )
   list(APPEND tmp_dirs ${tmp_dir})
endforeach()

list(REMOVE_DUPLICATES tmp_files)
get_filename_component( tmp_dir ${CMAKE_CURRENT_SOURCE_DIR} DIRECTORY )
list(FILTER tmp_files EXCLUDE REGEX "${tmp_dir}/.*")

add_library(${PROJECT_NAME} SHARED
   "CMakeLists.txt"
   "Main.cs"
   ${tmp_files}
)

foreach(entry ${tmp_files})
   file(RELATIVE_PATH tmp_path ${TORQUE_APP_GAME_DIRECTORY} "${entry}")
   set_source_files_properties(${entry} PROPERTIES VS_CSHARP_Link "${tmp_path}")
endforeach()

target_link_libraries(${PROJECT_NAME} T3DSharpFramework)

# Set CLR assembly properties.
SET_TARGET_PROPERTIES(${PROJECT_NAME} PROPERTIES
    VS_DOTNET_REFERENCES "System;System.Core;System.Runtime.InteropServices"
    VS_GLOBAL_ROOTNAMESPACE ${PROJECT_NAME}
    VS_GLOBAL_GenerateRuntimeConfigurationFiles "true"
    VS_GLOBAL_PlatformTarget "x64"
)

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
