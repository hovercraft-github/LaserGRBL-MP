#!/usr/bin/bash

mkbundle -o LaserGRBL --simple --deps LaserGRBL.exe --machine-config /etc/mono/4.5/machine.config --config ../../../mkbundle.config \
--library libgdiplus.so.0,/usr/local/lib/libgdiplus.so.0.0.0 \
--library libMonoPosixHelper.so,/usr/lib/libMonoPosixHelper.so \
--library libmono-btls-shared.so,/usr/lib/libmono-btls-shared.so \
--library libmono-native.so,/usr/lib/libmono-native.so.0.0.0

