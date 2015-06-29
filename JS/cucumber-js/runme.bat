set root=%~dp0

@ECHO OFF

echo "Cucumber project run"
call %root%\node_modules\.bin\cucumber.js.cmd %root%\src\features\login.feature

