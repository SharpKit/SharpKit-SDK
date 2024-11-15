#!/bin/pwsh

Set-Location -Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)

cd Defs
& ./build.ps1
cd ..

cd Frameworks
& ./build.ps1
cd ..
