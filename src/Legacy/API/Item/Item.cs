using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarcraftDotNet.Legacy.API.Item
{
    public class Item
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("disenchantingSkillRank ")]
        public int DisenchantingSkillRank { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("stackable")]
        public int Stackable { get; set; }
        [JsonProperty("itemBind")]
        public int ItemBind { get; set; }
        [JsonProperty("bonusStats")]
        public List<BonusStat> BonusStats { get; set; }
        [JsonProperty("itemSpells")]
        public List<object> ItemSpells { get; set; }
        [JsonProperty("buyPrice ")]
        public int BuyPrice { get; set; }
        [JsonProperty("itemClass")]
        public int ItemClass { get; set; }
        [JsonProperty("itemSubClass")]
        public int ItemSubClass { get; set; }
        [JsonProperty("containerSlots ")]
        public int ContainerSlots { get; set; }
        [JsonProperty("weaponInfo")]
        public WeaponInfo WeaponInfo { get; set; }
        [JsonProperty("inventoryType ")]
        public int InventoryType { get; set; }
        [JsonProperty("equippable")]
        public bool Equippable { get; set; }
        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }
        [JsonProperty("maxCount")]
        public int MaxCount { get; set; }
        [JsonProperty("maxDurability")]
        public int MaxDurability { get; set; }
        [JsonProperty("minFactionId")]
        public int MinFactionId { get; set; }
        [JsonProperty("minReputation")]
        public int MinReputation { get; set; }
        [JsonProperty("quality")]
        public int Quality { get; set; }
        [JsonProperty("sellPrice")]
        public int SellPrice { get; set; }
        [JsonProperty("requiredSkillLevel")]
        public int RequiredSkillLevel { get; set; }
        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; set; }
        [JsonProperty("requiredSkillRank")]
        public int RequiredSkillRank { get; set; }
        [JsonProperty("itemSource")]
        public ItemSource ItemSource { get; set; }
        [JsonProperty("baseArmor")]
        public int BaseArmor { get; set; }
        [JsonProperty("hasSockets")]
        public bool HasSockets { get; set; }
        [JsonProperty("isAuctionable")]
        public bool IsAuctionable { get; set; }
        [JsonProperty("armor")]
        public int Armor { get; set; }
        [JsonProperty("displayInfold")]
        public int DisplayInfold { get; set; }
        [JsonProperty("nameDescription ")]
        public string NameDescription { get; set; }
        [JsonProperty("nameDescriptionColor")]
        public string NameDescriptionColor { get; set; }
        [JsonProperty("upgradable")]
        public bool Upgradable { get; set; }
        [JsonProperty("heroicTooltip")]
        public bool HeroicTooltip { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("bonusLists")]
        public List<object> BonusLists { get; set; }
        [JsonProperty("availableContexts ")]
        public List<string> AvailableContexts { get; set; }
        [JsonProperty("bonusSummary")]
        public BonusSummary BonusSummary { get; set; }
        [JsonProperty("artifactId")]
        public int ArtifactId { get; set; }
    }
}