namespace WarcraftDotNet
{
    public class Locales
    {
        // ReSharper disable once InconsistentNaming
        public static Locale EN_US = new Locale()
        {
            UrlPrefix = "us",
            Language = "en_us"
        };
    }

    public class Locale
    {
        public string UrlPrefix { get; set; }
        public string Language { get; set; }
    }
}
