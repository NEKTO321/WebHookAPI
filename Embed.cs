using Newtonsoft.Json;

namespace ZLOY.API.Discord.EmbedApi
{
    [JsonObject]
    public class Embed : IEmbedUrl
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; } = "rich";
        [JsonProperty("description")]
        public string Description { get; set; }
        public string Url { get; set; }
        [JsonProperty("color")]
        public int Color { get; set; }
        [JsonProperty("footer")]
        public EmbedFooter Footer { get; set; }
        [JsonProperty("author")]
        public EmbedAuthor Author { get; set; }
    }

    [JsonObject]
    public class EmbedFooter : IEmbedIconUrl, IEmbedIconProxyUrl
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
    [JsonObject]
    public class EmbedAuthor : EmbedUrl, IEmbedIconUrl, IEmbedIconProxyUrl
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        public string IconUrl { get; set; }
        public string ProxyIconUrl { get; set; }
    }
    [JsonObject]
    public abstract class EmbedUrl : IEmbedUrl
    {
        public string Url { get; set; }
    }
    [JsonObject]
    public interface IEmbedUrl
    {
        [JsonProperty("url")]
        string Url { get; set; }
    }
    [JsonObject]
    public interface IEmbedIconUrl
    {
        [JsonProperty("icon_url")]
        string IconUrl { get; set; }
    }
    [JsonObject]
    public interface IEmbedIconProxyUrl
    {
        [JsonProperty("proxy_icon_url")]
        string ProxyIconUrl { get; set; }
    }
    public enum  Color : int {
        Red = 0xFF0000,
        Green = 0x00FF00,
        Blue = 0x0000FF,
        Grey = 0xFF0000,
        Yellow = 0xFFFF00,
        Purple = 0x800080,
        Orange = 0xFFA500,
        Black = 0x000000,
        White = 0xFFFFFF,
        Pink = 0xFFC0CB,
        LightPink = 0xFFB6C1,
        DarkPink = 0xFF1493,
        Cyan = 0x00FFFF,
        LightCyan = 0xE0FFFF,
        DarkCyan = 0x008B8B,
        Lime = 0x00FF00,
        LighLime = 0x32CD32,
        DarkLime = 0x00FF7F,
        Silver = 0xC0C0C0,
        LightSilver = 0xD3D3D3,
        DarkSilver = 0xA9A9A9,
        Olive = 0x808000,
        LightPlive = 0x6B8E23,
        DarkOlive = 0x556B2F,
        Pumpkin = 0xFF7518,
        Tangerine = 0xFFCC00,
        Coral = 0xFF7F50,
        Carrot = 0xED9121,
        Lavender = 0xE6E6FA,
        Plum = 0xDDA0DD,
        SkyBlue = 0x87CEEB,
        Mint = 0x98FF98,
        Ruby = 0xE0115F,
        Sapphire = 0x082567,
        Emerald = 0x50C878,
        BrightYellow = 0xFFFF00,
        Brown = 0x964B00,
        Raspberry = 0xE30B5D,
        Gold = 0xFFD700,
        Turquoise = 0x40E0D0,
        Fuchsia = 0xFF00FF,
        Sunshine = 0xFFD700,
        Mauve = 0xE0B0FF,
        TealBlue = 0x008080,

    }
}
