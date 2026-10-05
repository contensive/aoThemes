@echo off
setlocal

rem Uploads Theme Helpers to the Addon Collection Library on contensive.com.

powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0..\deploy-to-addon-library.ps1" ^
    -CollectionName "Theme Helpers" ^
    -CollectionPath "%~dp0..\..\Collections\Theme Helpers" ^
    -DeploymentPath "C:\Deployments\aoThemes-ThemeHelpers" ^
    -UiPath "%~dp0..\..\ui\themehelpers"

set exitCode=%errorlevel%
pause
exit /b %exitCode%
