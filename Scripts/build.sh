#!/usr/bin/env bash

# go to project root.
if [[ $(pwd) == *Scripts ]]; then
    cd ..
fi

echo Exporting package...

UNITY_PATH="/Applications/Unity/Unity.app/Contents/MacOS/Unity"
$UNITY_PATH -batchmode -nographics -projectPath $(pwd) -executeMethod DeviceUtilsConsoleEndpoint.ExportPackage -quit \
    || die "Failed to export package. Make sure the Device Utils project is not open in Unity"

echo Done!
