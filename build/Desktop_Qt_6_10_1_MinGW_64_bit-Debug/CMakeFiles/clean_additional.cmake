# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "CMakeFiles\\zaripov166_autogen.dir\\AutogenUsed.txt"
  "CMakeFiles\\zaripov166_autogen.dir\\ParseCache.txt"
  "zaripov166_autogen"
  )
endif()
