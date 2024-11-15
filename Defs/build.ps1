#!/bin/pwsh

Set-Location -Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)

if($IsLinux) {

    msbuild Defs.sln /verbosity:minimal

} else {

    dotnet msbuild Defs.sln /verbosity:minimal

}

