#!/usr/bin/bash

TARGET=$1
if [[ x"$TARGET" == x"" ]]; then
    TARGET=`hostnamectl |grep 'System' |sed 's/^.*: \(.*\)/\1/' |sed 's/[ \/]/-/g' |sed 's/[()]//g'`-`uname -p`
fi
SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )
DLLS_DIR="${SCRIPT_DIR}/dll/${TARGET}"
echo $DLLS_DIR
if [ ! -d "$DLLS_DIR" ]; then
    echo "$DLLS_DIR does not exist."
    exit 1
fi

function resolveSoPath {
    local find_args=( "${DLLS_DIR}" -iname "${1}*" )
    find "${find_args[@]}"
}

mkbundle -o LaserGRBL --simple --deps LaserGRBL.exe --machine-config /etc/mono/4.5/machine.config --config ../../../mkbundle.config \
--library libgdiplus.so.0,$(resolveSoPath libgdiplus.so) \
--library libMonoPosixHelper.so,$(resolveSoPath libMonoPosixHelper.so) \
--library libmono-btls-shared.so,$(resolveSoPath libmono-btls-shared.so) \
--library libmono-native.so,$(resolveSoPath libmono-native.so)

