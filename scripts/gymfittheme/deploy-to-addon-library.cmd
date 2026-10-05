@echo off
setlocal

rem Uploads Gym Fit Theme to the Addon Collection Library on contensive.com.

powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0..\deploy-to-addon-library.ps1" ^
    -CollectionName "Gym Fit Theme" ^
    -CollectionPath "%~dp0..\..\Collections\Gym Fit Theme" ^
    -DeploymentPath "C:\Deployments\aoThemes-GymFitTheme" ^
    -UiPath "%~dp0..\..\ui\gymfittheme"

set exitCode=%errorlevel%
pause
exit /b %exitCode%
