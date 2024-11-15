#!/bin/pwsh

Set-Location -Path (Split-Path -Path $MyInvocation.MyCommand.Definition -Parent)

if($IsLinux) {
    Write-Host "Invoking skc5 on Linux currently not supported" -ForegroundColor Yello
} else {
    & C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe\MSBuild.exe Frameworks.sln -verbosity:minimal
}

