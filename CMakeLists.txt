cmake_minimum_required(VERSION 3.14)

torqueAddSourceDirectories("${POSSIBLE_PROJECT_ABSOLUTEPATH}/source")

set(CSHARP_SOURCE_DIR "${CMAKE_CURRENT_SOURCE_DIR}")
set(CSHARP_OUTPUT_DIR "${CMAKE_CURRENT_SOURCE_DIR}")
set(CSHARP_SOLUTION_NAME "T3DSharpSolution")
set(CSHARP_SOLUTION_PATH "${CSHARP_SOURCE_DIR}/${CSHARP_SOLUTION_NAME}.sln")

# --------------------
# -- Solution
# --------------------
FILE(REMOVE "${CSHARP_SOLUTION_PATH}")
execute_process(
   COMMAND dotnet new sln --name ${CSHARP_SOLUTION_NAME}
   WORKING_DIRECTORY ${CSHARP_SOURCE_DIR}
)
add_custom_target(__T3DSHARP_SOLUTION ALL
   COMMAND dotnet build ${CSHARP_SOLUTION_PATH} -o ${TORQUE_APP_GAME_DIRECTORY}
)

# --------------------
# -- Projects
# --------------------
macro(add_csproject name path)
   execute_process(
      COMMAND dotnet sln ${CSHARP_SOLUTION_PATH} add ${path}
   )
endmacro()

macro(set_relative_paths_for_csproj csproj_path)
   file(RELATIVE_PATH CSHARP_FRAMEWORK_REL_PATH ${csproj_path} "${CSHARP_FRAMEWORK_PATH}")
   file(RELATIVE_PATH TORQUE_APP_GAME_REL_DIRECTORY ${csproj_path} "${TORQUE_APP_GAME_DIRECTORY}")
endmacro()

macro(set_relative_csharp_framework_path src_path)
	file(RELATIVE_PATH CSHARP_FRAMEWORK_REL_PATH ${src_path} "${CSHARP_FRAMEWORK_PATH}")
endmacro()

macro(set_relative_app_game_directory src_path)
	file(RELATIVE_PATH TORQUE_APP_GAME_REL_DIRECTORY ${src_path} "${TORQUE_APP_GAME_DIRECTORY}")
endmacro()

macro(configure_file_if_not_exists src_path tgt_path)
	if(NOT EXISTS ${tgt_path})
		configure_file(${src_path} ${tgt_path})
	endif()
endmacro()

option(TORQUE_CSHARP_FRAMEWORK_GENERATED_DIR "Directory of the generated engine layer" "${CSHARP_OUTPUT_DIR}/T3DSharpFramework/Generated")
mark_as_advanced(TORQUE_CSHARP_FRAMEWORK_GENERATED_DIR)
set(CSHARP_FRAMEWORK_GENERATED_DIR "${CSHARP_SOURCE_DIR}/T3DSharpFramework/Generated")

if (EXISTS "${TORQUE_CSHARP_FRAMEWORK_GENERATED_DIR}" AND IS_DIRECTORY "${TORQUE_CSHARP_FRAMEWORK_GENERATED_DIR}")
	set(CSHARP_FRAMEWORK_GENERATED_DIR TORQUE_CSHARP_FRAMEWORK_GENERATED_DIR)
endif()

configure_file(
	"${CSHARP_SOURCE_DIR}/T3DSharpFramework/T3DSharpFramework.csproj.in"
	"${CSHARP_OUTPUT_DIR}/T3DSharpFramework/T3DSharpFramework.csproj"
)
add_csproject(T3DSharpFramework "${CSHARP_OUTPUT_DIR}/T3DSharpFramework/T3DSharpFramework.csproj")
set(CSHARP_FRAMEWORK_PATH "${CSHARP_OUTPUT_DIR}/T3DSharpFramework/T3DSharpFramework.csproj")

set_relative_paths_for_csproj("${CSHARP_SOURCE_DIR}/T3DSharpGenerator")

configure_file(
	"${CSHARP_SOURCE_DIR}/T3DSharpGenerator/T3DSharpGenerator.csproj.in"
	"${CSHARP_OUTPUT_DIR}/T3DSharpGenerator/T3DSharpGenerator.csproj"
)
add_csproject(T3DSharpGenerator "${CSHARP_OUTPUT_DIR}/T3DSharpGenerator/T3DSharpGenerator.csproj")

#####
# Configure .csproj templates
#####

set(tmp_files "")

file(GLOB_RECURSE tmp_files ${TORQUE_APP_GAME_DIRECTORY}/*.csproj.in)

foreach(entry ${BLACKLIST})
	list(REMOVE_ITEM tmp_files ${dir}/${entry})
endforeach()

foreach(f ${tmp_files})
	string(REGEX REPLACE "(.*)/([^/]*)$" "\\1" tmp_folder ${f})
	string(REGEX REPLACE "(.*)/([^/]*)$" "\\2" tmp_file ${f})
	string(REGEX REPLACE "(.*)\.in$" "\\1" tmp_target ${tmp_file})
	string(REGEX REPLACE "(.*)\.csproj\.in$" "\\1" tmp_project_name ${tmp_file})

   set_relative_paths_for_csproj("${tmp_folder}r")
	configure_file_if_not_exists(
		"${tmp_folder}/${tmp_file}"
		"${tmp_folder}/${tmp_target}"
	)
	add_csproject("${tmp_project_name}" "${tmp_folder}/${tmp_target}")
	LIST(APPEND TEMPLATED_CSPROJ_FILES "${tmp_folder}/${tmp_target}")
	LIST(APPEND CSPROJ_FILES "${tmp_folder}/${tmp_target}")
endforeach()

#####
# Add .csproj
#####

set(tmp_files "")

file(GLOB_RECURSE tmp_files ${TORQUE_APP_GAME_DIRECTORY}/*.csproj)

foreach(entry ${BLACKLIST})
	list(REMOVE_ITEM tmp_files ${TORQUE_APP_GAME_DIRECTORY}/${entry})
endforeach()

foreach(entry ${TEMPLATED_CSPROJ_FILES})
	list(REMOVE_ITEM tmp_files ${entry})
endforeach()

foreach(f ${tmp_files})
	string(REGEX REPLACE "(.*)/([^/]*)$" "\\1" tmp_folder ${f})
	string(REGEX REPLACE "(.*)/([^/]*)$" "\\2" tmp_file ${f})
	string(REGEX REPLACE "(.*)\.csproj$" "\\1" tmp_project_name ${tmp_file})

    set_relative_paths_for_csproj("${tmp_folder}r")
	add_csproject("${tmp_project_name}" "${tmp_folder}/${tmp_file}")
	LIST(APPEND CSPROJ_FILES "${tmp_folder}/${tmp_file}")
endforeach()

#####
# Add game
#####

list(REMOVE_ITEM CSPROJ_FILES "${CSHARP_OUTPUT_DIR}/T3DSharpGame/T3DSharpGame.csproj")
list(REMOVE_ITEM CSPROJ_FILES "${CSHARP_OUTPUT_DIR}/T3DSharpGenerator/T3DSharpGenerator.csproj")
foreach(f ${CSPROJ_FILES})
	file(RELATIVE_PATH tmp_rel_path "${CSHARP_OUTPUT_DIR}/T3DSharpGame" "${f}")
	set(GAME_INCLUDES "${GAME_INCLUDES} \n\
		  <ProjectReference Include=\"${tmp_rel_path}\"> \n\
			<Private>true</Private> \n\
		  </ProjectReference> \n\
	")
endforeach()

foreach(c ${CMAKE_CONFIGURATION_TYPES})
string(TOUPPER ${c} tmp_c_upper)
set(CSHARP_DEFINE_CONSTANTS "${CSHARP_DEFINE_CONSTANTS} \n\
   <PropertyGroup Condition=\"\'\$(Configuration)'=='${c}'\">\n\
     <DefineConstants>${tmp_c_upper}</DefineConstants>\n\
   </PropertyGroup>\n\
")
endforeach()

configure_file_if_not_exists(
	"${CSHARP_SOURCE_DIR}/T3DSharpGame/Program.cs.in"
	"${CSHARP_SOURCE_DIR}/T3DSharpGame/Program.cs"

	# "${TORQUE_APP_GAME_DIRECTORY}/Program.cs"
)

set_relative_paths_for_csproj("${CSHARP_OUTPUT_DIR}/T3DSharpGame")

configure_file(
	"${CSHARP_SOURCE_DIR}/T3DSharpGame/T3DSharpGame.csproj.in"
	"${CSHARP_OUTPUT_DIR}/T3DSharpGame/T3DSharpGame.csproj"
)

add_csproject(T3DSharpGame "${CSHARP_OUTPUT_DIR}/T3DSharpGame/T3DSharpGame.csproj")
