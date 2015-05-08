@cd /D %~dp0
@call ../scripts/set-variables

%msbuild% Defs.sln /verbosity:minimal
