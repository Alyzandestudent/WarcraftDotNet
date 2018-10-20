using System.Runtime.Serialization;

namespace WarcraftDotNet.Legacy.API.Guild
{
    [DataContract]
    public class Member
    {
        [DataMember(Name="character")]
        public Character Character { get; set; }

        [DataMember(Name = "rank")]
        public int Rank { get; set; }
    }
}