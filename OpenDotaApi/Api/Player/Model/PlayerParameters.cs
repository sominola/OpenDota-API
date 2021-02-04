using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace OpenDotaApi.Api.Player.Model
{
    public class PlayerParameters
    {
       public int? Limit { get; init; }
       public int? Offset { get; init; }
       public bool? Win { get; init; }
       public int? Patch { get; init; }
       public int? GameMode { get; init; }
       public int? LobbyType { get; init; }
       public int? Region { get; init; }
       public int? Date { get; init; }
       public int? LaneRole { get; init; }
       public int? HeroId { get; init; }
       public bool? IsRadiant { get; init; }
       public IEnumerable IncludedAccountId { get; init; }
       public IEnumerable ExcludedAccountId { get; init; }
       public IEnumerable WithHeroId { get; init; }
       public IEnumerable AgainstHeroId { get; init; }
       public int? Significant { get; init; }
       public int? Having { get; init; }
       public int? Sort { get; init; }
       public string GetParamaters()
       {
           var fields = typeof(PlayerParameters).GetProperties();
           var paramaters = "";
           foreach (var field in fields)
           {
               var value = field.GetValue(this, null );
               
               if (value != null)
               {
                   if (field.PropertyType == typeof(IEnumerable))
                   {
                       object list = GetType().GetProperty(field.Name)?.GetValue(this, null);
                       foreach (var val in (IEnumerable) list)
                       {
                           paramaters += $"&{field.Name}={Convert.ToInt64(val)}"; 
                       }
                   }
                   else
                       paramaters += $"&{field.Name}={Convert.ToInt64(value)}";
               }
           } 
           return Regex.Replace(paramaters, "([a-z])([A-Z])", "$1_$2").ToLower();
       } 
    }
}