Remove-Item -Recurse -Force .\Packages\*.nupkg
nuget pack .\src\Greeter.Contracts\Greeter.Contracts.nuspec -OutputDirectory .\Packages\ -BasePath .\src\Greeter.Contracts\