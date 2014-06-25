@echo off
cd /D %~dp0
call scripts/set-variables

cd Defs
call make
cd ..

cd Frameworks
call make
cd ..
