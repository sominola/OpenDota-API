using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace OpenDotaApi
{
    public class PlayerParameters
    {
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        public bool? Win { get; set; }
        public int? Patch { get; set; }
        public int? GameMode { get; set; }
        public int? LobbyType { get; set; }
        public int? Region { get; set; }
        public int? Date { get; set; }
        public int? LaneRole { get; set; }
        public int? HeroId { get; set; }
        public bool? IsRadiant { get; set; }
        public IEnumerable IncludedAccountId { get; set; }
        public IEnumerable ExcludedAccountId { get; set; }
        public IEnumerable WithHeroId { get; set; }
        public IEnumerable AgainstHeroId { get; set; }
        public int? Significant { get; set; }
        public int? Having { get; set; }
        public int? Sort { get; set; }
        public string Project { get; set; }

        public string GetParameters()
        {
            var fields = typeof(PlayerParameters).GetProperties();
            var parameters = "";
            foreach (var field in fields)
            {
                var value = field.GetValue(this, null);

                if (value == null) continue;
                if (field.PropertyType == typeof(IEnumerable))
                {
                    var list = GetType().GetProperty(field.Name)?.GetValue(this, null);
                    foreach (var val in list as IEnumerable)
                    {
                        parameters += $"&{field.Name}={Convert.ToInt64(val)}";
                    }
                }
                else
                    parameters += $"&{field.Name}={Convert.ToInt64(value)}";
            }

            return Regex.Replace(parameters, "([a-z])([A-Z])", "$1_$2").ToLower();
        }
    }
}