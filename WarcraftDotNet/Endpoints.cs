namespace WarcraftDotNet
{
    public class Endpoints
    {
        public static class Base
        {
            public static string Protocol = "https://";
            public static string Url = "api.battle.net";
            public static string Wow = "/wow";
        }

        public static string Achievement = "/achievement";
        public static string Auction = "/auction/data";
        public static string Boss = "/boss";
        public static string Challenge = "/challenge";
        public static string Character = "/character";
        public static string Guild = "/guild";
        public static string Item = "/item";
        public static string Set = "/set";
        public static string Mount = "/mount";
        public static string Pet = "/pet";
        public static string Ability = "/ability";
        public static string Species = "/species";
        public static string Stats = "/stats";
        // ReSharper disable once InconsistentNaming
        public static string PVP = "/leaderboard";
        public static string Quest = "/quest";
        public static string Realm = "/realm";
        public static string Status = "/status";
        public static string Recipe = "/recipe";
        public static string Spell = "/spell";
        public static string Zone = "/zone";
    }
}
