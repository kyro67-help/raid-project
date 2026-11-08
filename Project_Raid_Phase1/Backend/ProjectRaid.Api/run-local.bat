@echo off
setlocal
cd /d "%~dp0"
dotnet --version
if errorlevel 1 (
  echo .NET SDK was not found. Install from https://dotnet.microsoft.com/download/dotnet/10.0
  pause
  exit /b 1
)
echo Starting Project Raid API at http://localhost:5080 ...
dotnet run --urls http://localhost:5080
pause
