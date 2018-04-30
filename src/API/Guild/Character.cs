using Newtonsoft.Json;
using WarcraftDotNet.Enum;

namespace WarcraftDotNet.API.Guild
{
	public class Character
	{
		[JsonProperty("lastModified")]
		public long LastModified { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("realm")]
		public string Realm { get; set; }
		[JsonProperty("guildRealm")]
		public string GuildRealm { get; set; }
		[JsonProperty("class")]
		public ClassEnum CharacterClass { get; set; }
		[JsonProperty("race")]
		public RaceEnum Race { get; set; }
		[JsonProperty("gender")]
		public GenderEnum Gender { get; set; }
		[JsonProperty("level")]
		public int Level { get; set; }
		[JsonProperty("achievementPoints")]
		public int AchievementPoints { get; set; }
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }
		[JsonProperty("spec")]
		public CharacterSpec Specialization { get; set; }
	}
}