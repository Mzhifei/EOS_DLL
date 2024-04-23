#!/bin/bash

 Build Linux64
BUILD_TYPE=Release
OUT=build/linux64/${BUILD_TYPE}

cmake_out_dir="$(pwd)/$OUT/cmake_libs"
CMAKE="cmake -G Ninja -Wno-dev -DCMAKE_PREFIX_PATH:PATH=${cmake_out_dir}"

$CMAKE -DX64=ON -DCMAKE_BUILD_TYPE=${BUILD_TYPE} -S . -B "${OUT}"
cmake --build "${OUT}"
cmake --install "${OUT}"
