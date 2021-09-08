<img align="right" width="144" height="144" src="https://www.opendota.com/assets/images/icons/icon-144x144.png">

# OpenDotaApi [![NuGet](https://img.shields.io/nuget/v/OpenDotaApi?style=flat-square)](https://www.nuget.org/packages/OpenDotaApi) [![NuGet](https://img.shields.io/github/workflow/status/sominola/opendota-api/.NET?style=flat-square)](https://github.com/sominola/OpenDota-API/actions)

##### An unofficial .NET API Wrapper for the OpenDota API.

The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.

**If you think something is broken, something is missing or have any questions, please open an [Issue](https://github.com/sominola/OpenDota-API/issues)**

# Installation
To get started with OpenDotaApi first you will need to get the library itself. The easiest way to do this is to install the package into your project using  [NuGet](https://www.nuget.org/packages/OpenDotaApi/). 
1. Download and Install the latest `OpenDotaApi` from NuGet or via CLI:

```
PM> Install-Package OpenDotaApi
```

2. After installing it's time to actually use it. To get started we have to add the OpenDotaApi namespace:

```csharp
using OpenDotaApi;
```
## Getting Started
Then use the class! 
````csharp
 long SteamId = 0;
 var openDota = new OpenDota();
 var data = await openDota.Player.GetPlayerAsync(SteamId);
 Console.WriteLine(data.Profile.Avatarfull);
````
