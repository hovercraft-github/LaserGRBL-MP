#!/bin/bash
#

function check_mono_version {
    MONO_VERSION=`mono --version |grep 'compiler version' |sed 's/^.*compiler version[ ]\+\([0-9.]\+\) .*/\1/'`
    if [ -z "$MONO_VERSION" ]; then
        return 1
    fi
    let MONO_VERSION_MAJOR=`echo $MONO_VERSION |cut -d '.' -f 1`
    let MONO_VERSION_MINOR=`echo $MONO_VERSION |cut -d '.' -f 2`
    if (($MONO_VERSION_MAJOR < 6)); then
        return 1
    fi
    if (($MONO_VERSION_MINOR < 12)); then
        return 1
    fi
    return 0
}

if ! check_mono_version ; then
    echo "You must install mono v6.12.0.200 or higher"
    echo "Follow instructions here: https://www.howtoforge.com/how-to-install-mono-net-framework-on-ubuntu-22-04/"
    exit 1
else
    echo "Found mono v$MONO_VERSION"
fi

if [ ! -f /opt/libgdiplus/lib/libgdiplus.so.0.0.0 ]; then
    echo "Building proper libgdiplus.so"
    sudo apt-get install -y libgif-dev autoconf libtool automake build-essential gettext libglib2.0-dev libcairo2-dev libtiff-dev libexif-dev libpng-dev libjpeg-dev
    git clone --recurse-submodules -j https://github.com/mono/libgdiplus.git
    cd libgdiplus/external/googletest
    patch -p1 < ../../../libgdiplus.patch
    cd ../../
    ./autogen.sh --prefix=/opt/libgdiplus
    # Configuration summary
    # 
    #    * Installation prefix = /opt/libgdiplus
    #    * Cairo = 1.16.0 (system)
    #    * Text = pango
    #    * EXIF tags = No. Get it from http://libexif.sourceforge.net/
    #    * X11 = yes
    #    * Codecs supported:
    # 
    #       - TIFF: yes
    #       - JPEG: yes
    #       - GIF: no (See http://sourceforge.net/projects/libgif)
    #       - PNG: yes
    # 
    #       NOTE: if any of the above say 'no' you may install the
    #             corresponding development packages for them, rerun
    #             autogen.sh to include them in the build.
    make -j
    sudo make install
    cd ../
else
    echo "Found /opt/libgdiplus/lib/libgdiplus.so.0.0.0"
    printf "In the case of some probles with image handling in the LaserGRBL,\n you should remove existing libgdiplus.so and we will rebuild it\n\n"
fi

msbuild -t:Rebuild -p:Configuration=Release .

bash -c "cd LaserGRBL/bin/Release && mkbundle -o LaserGRBL --simple LaserGRBL.exe --machine-config /etc/mono/4.5/machine.config --config ../../../mkbundle.config --library libgdiplus.so.0,/opt/libgdiplus/lib/libgdiplus.so.0.0.0 --library libMonoPosixHelper.so,/usr/lib/libMonoPosixHelper.so --library libmono-native.so,/usr/lib/libmono-native.so.0.0.0"
