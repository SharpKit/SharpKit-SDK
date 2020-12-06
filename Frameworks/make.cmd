@cd /D %~dp0
@call ../scripts/set-variables

dotnet build Frameworks.sln -verbosity:minimal
