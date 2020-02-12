#!/bin/bash

echo "first run"

gmcs third.cs
./third.exe < inputfile
rm third.exe
echo "first run done"




