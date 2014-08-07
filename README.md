A blog site built using ASP.NET MVC4 and Entity framework

Requirements
------------
Visual Studio Express for Web 2012 (Express was used to develop other 2012 versions probably work)

Getting Started
------------
- Clone the repository
- Open the solution file in Visual Studio
- Ensure that Nuget package restore is enabled (http://docs.nuget.org/docs/workflows/using-nuget-without-committing-packages)
- Allow Nuget to restore packages in the package manager console window
- Build the solution
- To setup Code First database in the package manager console enter "update-database"
(If this fails then close and reopen the solution as visual studio appears to have some bug related to cmdlets of packages that nuget just installed)
- Run the project (F5)
