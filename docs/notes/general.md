# API ASP.NET Core
## Processes
### How to...
#### Manage DB
__Install for DB__
1. `dotnet tool install --global dotnet-ef`
__Commands for DB__ 
Do these commands in the directory next to the project.
* __Add Migration__ `dotnet ef migrations add <name>`
  * __Remove Migration__ `dotnet ef migrations remove <name>`
* __Apply All Migrations__ `dotnet ef database update`

#### Build
#### Run
* in DatingApp.API: `dotnet watch run`
#### Debug
* In VS Code, you can use the built in debugger with `dotnet watch run` actively building, and then attach to `DatingApp.dll` when prompted to choose a process.

# Angular
## Processes
### How to...
#### Build
#### Run
