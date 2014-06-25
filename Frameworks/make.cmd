@cd /D %~dp0
@call ../scripts/set-variables

%msbuild% Frameworks.sln
