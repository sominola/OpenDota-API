# OpenDotaApi

This is a C# wrapper for the OpenDota api.

## Usage 
Import the namespace
````csharp
using OpenDotaApi;
````

Then use the class! 
````csharp
 int SteamId = 0;
 var openDota = new OpenDota();
 var data = await openDota.Player.GetPlayerAsync(SteamId);
 Console.WriteLine(data.Profile.Avatarfull);
````
