# name-sorter
A sorting application that sorts names by last name and then by given names. This project is not to show how to sort names, but to write code in a testable manner and adhering to SOLID principles.

People is a .NET Core (2.1) Console application.

Use the following set of commands:

build - dotnet build
restore - dotnet restore
run - dotnet run

Design & Architecture:
* Strong segregation of injectables and newables.
* Dependency injection.
* Separation of concerns following all the SOLID principles https://en.wikipedia.org/wiki/SOLID_(object-oriented_design)
