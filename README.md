# ![Icon](https://www.opendota.com/assets/images/icons/icon-144x144.png) OpenDotaApi [![NuGet](https://img.shields.io/nuget/v/OpenDotaApi?style=plastic?maxAge=2592000)](https://www.nuget.org/packages/OpenDotaApi)

A .Net wrapper for the OpenDota API
The OpenDota API provides Dota 2 related data including advanced match data extracted from match replays.

**If you think something is broken, something is missing or have any questions, please open an [Issue](https://github.com/sominola/OpenDota-API/issues)**

# Installation
To get started with OpenDotaApi first you will need to get the library itself. The easiest way to do this is to install the package into your project using  [NuGet](https://www.nuget.org/packages/OpenDotaApi/). 
1. Download and Install the latest `OpenDotaApi` from NuGet or via CLI:

```
PM> Install-Package OpenDotaApi
```

2. After installing it's time to actually use it. To get started we have to add the OpenDotaApi namespace:  `using OpenDotaApi;`.

```csharp
using AutoWrapper;
```
## Getting Started
Then use the class! 
````csharp
 int SteamId = 0;
 var openDota = new OpenDota();
 var data = await openDota.Player.GetPlayerAsync(SteamId);
 Console.WriteLine(data.Profile.Avatarfull);
````
