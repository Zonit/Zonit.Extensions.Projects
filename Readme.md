## Zonit.Extensions.Projects

An abstraction for organizational management for Blazor.

**Nuget Package Abstraction**
```
Install-Package Zonit.Extensions.Projects.Abstractions 
```
![NuGet Version](https://img.shields.io/nuget/v/Zonit.Extensions.Projects.Abstractions.svg)
![NuGet](https://img.shields.io/nuget/dt/Zonit.Extensions.Projects.Abstractions.svg)


**Nuget Package Extensions**
```
Install-Package Zonit.Extensions.Projects
```
![NuGet Version](https://img.shields.io/nuget/v/Zonit.Extensions.Projects.svg)
![NuGet](https://img.shields.io/nuget/dt/Zonit.Extensions.Projects.svg)

**Install**
Add this in ``Routes.razor``
```razor
@using Zonit.Extensions

<ZonitProjectsExtension />
```

Services in ``Program.cs``
```cs
builder.Services.AddProjectsExtension();
```