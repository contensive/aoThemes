@echo off
setlocal

rem Uploads Bootstrap Basic Theme to the Addon Collection Library on contensive.com.

powershell -NoProfile -ExecutionPolicy Bypass -File "%~dp0..\deploy-to-addon-library.ps1" ^
    -CollectionName "Bootstrap Basic Theme" ^
    -CollectionPath "%~dp0..\..\Collections\aoBootstrapBasicTheme" ^
    -DeploymentPath "C:\Deployments\aoThemes-BootstrapBasicTheme" ^
    -UiPath "%~dp0..\..\ui\aoBootstrapBasicTheme"

set exitCode=%errorlevel%
pause
exit /b %exitCode%
