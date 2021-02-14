using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace OpenDotaApi.Api.Match.Model
{
    public class MatchPlayer
    {
        [JsonPropertyName("match_id")]
        public long? MatchId { get; set; }

        [JsonPropertyName("player_slot")]
        public int? PlayerSlot { get; set; }

        [JsonPropertyName("ability_targets")]
        public Dictionary<string, Dictionary<string, int>> AbilityTargets { get; set; }

        [JsonPropertyName("ability_upgrades_arr")]
        public List<int> AbilityUpgradesArr { get; set; }

        [JsonPropertyName("ability_uses")]
        public Dictionary<string, int> AbilityUses { get; set; }

        [JsonPropertyName("account_id")]
        public long? AccountId { get; set; }

        [JsonPropertyName("actions")]
        public Dictionary<string, long> Actions { get; set; }

        [JsonPropertyName("additional_units")]
        public List<AdditionalUnit> AdditionalUnits { get; set; }

        [JsonPropertyName("assists")]
        public long? Assists { get; set; }

        [JsonPropertyName("backpack_0")]
        public long? Backpack0 { get; set; }

        [JsonPropertyName("backpack_1")]
        public long? Backpack1 { get; set; }

        [JsonPropertyName("backpack_2")]
        public long? Backpack2 { get; set; }

        [JsonPropertyName("buyback_log")]
        public List<BuybackLog> BuybackLogs { get; set; }

        [JsonPropertyName("camps_stacked")]
        public int? CampsStacked { get; set; }

        [JsonPropertyName("connection_log")]
        public List<ConnectionLog> ConnectionLog { get; set; }

        [JsonPropertyName("creeps_stacked")]
        public int? CreepsStacked { get; set; }

        [JsonPropertyName("damage")]
        public Dictionary<string, long> Damage { get; set; }

        [JsonPropertyName("damage_inflictor")]
        public Dictionary<string, int> DamageInflictor { get; set; }

        [JsonPropertyName("damage_inflictor_received")]
        public Dictionary<string, int> DamageInflictorReceived { get; set; }

        [JsonPropertyName("damage_taken")]
        public Dictionary<string, int> DamageTaken { get; set; }

        [JsonPropertyName("damage_targets")]
        public Dictionary<string, Dictionary<string, int>> DamageTargets { get; set; }

        [JsonPropertyName("deaths")]
        public int? Deaths { get; set; }

        [JsonPropertyName("denies")]
        public int? Denies { get; set; }

        [JsonPropertyName("dn_t")]
        public List<int> DeniesAtDifferentTimes { get; set; }

        [JsonPropertyName("firstblood_claimed")]
        public int? FirstBloodClaimed { get; set; }

        [JsonPropertyName("gold")]
        public int? Gold { get; set; }

        [JsonPropertyName("gold_per_min")]
        public int? GoldPerMin { get; set; }

        [JsonPropertyName("gold_reasons")]
        public Dictionary<string, int> GoldReasons { get; set; }

        [JsonPropertyName("gold_spent")]
        public int? GoldSpent { get; set; }

        [JsonPropertyName("gold_t")]
        public List<long> GoldEachMinute { get; set; }

        [JsonPropertyName("hero_damage")]
        public long? HeroDamage { get; set; }

        [JsonPropertyName("hero_healing")]
        public long? HeroHealing { get; set; }

        [JsonPropertyName("hero_hits")]
        public Dictionary<string, int> HeroHits { get; set; }

        [JsonPropertyName("hero_id")]
        public int? HeroId { get; set; }
        
        [JsonPropertyName("item_0")]
        public long? Item0 { get; set; }

        [JsonPropertyName("item_1")]
        public long? Item1 { get; set; }

        [JsonPropertyName("item_2")]
        public long? Item2 { get; set; }

        [JsonPropertyName("item_3")]
        public long? Item3 { get; set; }

        [JsonPropertyName("item_4")]
        public long? Item4 { get; set; }

        [JsonPropertyName("item_5")]
        public long? Item5 { get; set; }

        [JsonPropertyName("item_uses")]
        public Dictionary<string, int> ItemUses { get; set; }

        [JsonPropertyName("kill_streaks")]
        public Dictionary<string, int> KillStreaks { get; set; }

        [JsonPropertyName("killed")]
        public Dictionary<string, int> UnitsKilled { get; set; }

        [JsonPropertyName("killed_by")]
        public Dictionary<string, int> KilledBy { get; set; }

        [JsonPropertyName("kills")]
        public long? Kills { get; set; }

        [JsonPropertyName("kills_log")]
        public List<KillLog> KillsLog { get; set; }

        [JsonPropertyName("lane_pos")]
        public Dictionary<string, Dictionary<string, int>> LanePos { get; set; }

        [JsonPropertyName("last_hits")]
        public int? LastHits { get; set; }

        [JsonPropertyName("leaver_status")]
        public int? LeaverStatus { get; set; }

        [JsonPropertyName("level")]
        public int? Level { get; set; }

        [JsonPropertyName("lh_t")]
        public List<int> LastHitsEachMinute { get; set; }

        [JsonPropertyName("life_state")]
        public Dictionary<string, long> LifeState { get; set; }

        [JsonPropertyName("max_hero_hit")]
        public MaxHeroHit MaxHeroHit { get; set; }

        [JsonPropertyName("multi_kills")]
        public Dictionary<string, int> MultiKills { get; set; }

        [JsonPropertyName("obs")]
        public Dictionary<string, Dictionary<string, int>> Obs { get; set; }

        [JsonPropertyName("obs_left_log")]
        public List<WardLog> ObsLeftLog { get; set; }

        [JsonPropertyName("obs_log")]
        public List<WardLog> ObsLog { get; set; }

        [JsonPropertyName("obs_placed")]
        public int? ObsPlaced { get; set; }

        [JsonPropertyName("party_id")]
        public int? PartyId { get; set; }

        [JsonPropertyName("party_size")]
        public int? PartySize { get; set; }

        [JsonPropertyName("permanent_buffs")]
        public List<PermanentBuff> PermanentBuffs { get; set; }

        [JsonPropertyName("pings")]
        public int? Pings { get; set; }

        [JsonPropertyName("pred_vict")]
        public bool? PredVict { get; set; }

        [JsonPropertyName("purchase")]
        public Dictionary<string, long?> Purchase { get; set; }

        [JsonPropertyName("purchase_log")]
        public List<PurchaseLog> PurchaseLog { get; set; }

        [JsonPropertyName("randomed")]
        public bool? Randomed { get; set; }

        [JsonPropertyName("repicked")]
        public bool? Repicked { get; set; }

        [JsonPropertyName("roshans_killed")]
        public int? RoshansKilled { get; set; }

        [JsonPropertyName("rune_pickups")]
        public int? RunePickups { get; set; }

        [JsonPropertyName("runes")]
        public Dictionary<string, int> Runes { get; set; }

        [JsonPropertyName("runes_log")]
        public List<RuneLog> RuneLogs { get; set; }

        [JsonPropertyName("sen")]
        public Dictionary<string, Dictionary<string, int>> Sen { get; set; }

        [JsonPropertyName("sen_left_log")]
        public List<WardLog> SenLeftLog { get; set; }

        [JsonPropertyName("sen_log")]
        public List<WardLog> SenLog { get; set; }

        [JsonPropertyName("sen_placed")]
        public int? SenPlaced { get; set; }

        [JsonPropertyName("stuns")]
        public double? Stuns { get; set; }

        [JsonPropertyName("teamfight_participation")]
        public double? TeamfightParticipation { get; set; }

        [JsonPropertyName("times")]
        public List<int> Times { get; set; }

        [JsonPropertyName("tower_damage")]
        public int? TowerDamage { get; set; }

        [JsonPropertyName("towers_killed")]
        public int? TowersKilled { get; set; }

        [JsonPropertyName("xp_per_min")]
        public int? XpPerMin { get; set; }

        [JsonPropertyName("xp_reasons")]
        public Dictionary<string, int> XpReasons { get; set; }

        [JsonPropertyName("xp_t")]
        public List<long> XpEachMinute { get; set; }

        [JsonPropertyName("personaname")]
        public string Personaname { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("last_login")]
        public DateTimeOffset? LastLogin { get; set; }

        [JsonPropertyName("radiant_win")]
        public bool? RadiantWin { get; set; }

        [JsonPropertyName("start_time")]
        public DateTime? StartTime { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("cluster")]
        public long? Cluster { get; set; }

        [JsonPropertyName("lobby_type")]
        public int? LobbyType { get; set; }

        [JsonPropertyName("game_mode")]
        public int? GameMode { get; set; }

        [JsonPropertyName("is_contributor")]
        public bool? IsContributor { get; set; }

        [JsonPropertyName("patch")]
        public long? Patch { get; set; }

        [JsonPropertyName("isRadiant")]
        public bool? IsRadiant { get; set; }

        [JsonPropertyName("win")]
        public int? Win { get; set; }

        [JsonPropertyName("lose")]
        public int? Lose { get; set; }

        [JsonPropertyName("total_gold")]
        public long? TotalGold { get; set; }

        [JsonPropertyName("total_xp")]
        public long? TotalXp { get; set; }

        [JsonPropertyName("kills_per_min")]
        public double KillsPerMin { get; set; }

        [JsonPropertyName("kda")]
        public long? Kda { get; set; }

        [JsonPropertyName("abandons")]
        public int? Abandons { get; set; }

        [JsonPropertyName("neutral_kills")]
        public int? NeutralKills { get; set; }

        [JsonPropertyName("tower_kills")]
        public int? TowerKills { get; set; }

        [JsonPropertyName("courier_kills")]
        public int? CourierKills { get; set; }

        [JsonPropertyName("lane_kills")]
        public int? LaneKills { get; set; }

        [JsonPropertyName("hero_kills")]
        public int? HeroKills { get; set; }

        [JsonPropertyName("observer_kills")]
        public int? ObserverKills { get; set; }

        [JsonPropertyName("sentry_kills")]
        public int? SentryKills { get; set; }

        [JsonPropertyName("roshan_kills")]
        public int? RoshanKills { get; set; }

        [JsonPropertyName("necronomicon_kills")]
        public int? NecronomiconKills { get; set; }

        [JsonPropertyName("ancient_kills")]
        public int? AncientKills { get; set; }

        [JsonPropertyName("buyback_count")]
        public int? BuybackCount { get; set; }

        [JsonPropertyName("observer_uses")]
        public int? ObserverUses { get; set; }

        [JsonPropertyName("sentry_uses")]
        public int? SentryUses { get; set; }

        [JsonPropertyName("lane_efficiency")]
        public double LaneEfficiency { get; set; }

        [JsonPropertyName("lane_efficiency_pct")]
        public int? LaneEfficiencyPct { get; set; }

        [JsonPropertyName("lane")]
        public int? Lane { get; set; }

        [JsonPropertyName("lane_role")]
        public int? LaneRole { get; set; }

        [JsonPropertyName("is_roaming")]
        public bool? IsRoaming { get; set; }

        [JsonPropertyName("purchase_time")]
        public Dictionary<string, int?> PurchaseTime { get; set; }

        [JsonPropertyName("first_purchase_time")]
        public Dictionary<string, int?> FirstPurchaseTime { get; set; }

        [JsonPropertyName("item_win")]
        public Dictionary<string, int?> ItemWin { get; set; }

        [JsonPropertyName("item_usage")]
        public Dictionary<string, int?> ItemUsage { get; set; }

        [JsonPropertyName("purchase_tpscroll")]
        public int? PurchaseTpscroll { get; set; }

        [JsonPropertyName("actions_per_min")]
        public int? ActionsPerMin { get; set; }

        [JsonPropertyName("life_state_dead")]
        public int? LifeStateDead { get; set; }

        [JsonPropertyName("rank_tier")]
        public int? RankTier { get; set; }

        [JsonPropertyName("cosmetics")]
        public List<Cosmetic> Cosmetics { get; set; }

        [JsonPropertyName("benchmarks")]
        public MatchPlayerBenchmarks Benchmarks { get; set; }

        [JsonPropertyName("purchase_ward_observer")]
        public long? PurchaseWardObserver { get; set; }

        [JsonPropertyName("purchase_ward_sentry")]
        public long? PurchaseWardSentry { get; set; }

        [JsonPropertyName("purchase_gem")]
        public long? PurchaseGem { get; set; }
    }
}