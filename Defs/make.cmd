@cd /D %~dp0
@call ../scripts/set-variables

dotnet build Defs.sln /verbosity:minimal
