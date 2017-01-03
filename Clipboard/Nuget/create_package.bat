@echo off
del *.nupkg
nuget pack Package.nuspec
pause