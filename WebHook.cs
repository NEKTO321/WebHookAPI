using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json;
using ZLOY.API.Discord.EmbedApi;
namespace ZLOY.API.Discord.WebHook
{
    public class WebHook
    {
        private readonly HttpClient _httpClient;
        private readonly string _webhookUrl;
        [JsonProperty("content")]
        public string Content { get; set; }
        [JsonProperty("username")]
        public string NameWebHook { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("embeds")]
        public List<Embed> RequestEmbeds { get; set; } = new List<Embed>();
        private List<Embed> Embeds {  get; set; } = new List<Embed>();
        public WebHook(string webhookUrl)
        {
            _httpClient = new HttpClient();
            _webhookUrl = webhookUrl;
        }
        public void Send(string content,string uname,string avatar)
        {
            Content = content;
            NameWebHook = uname;
            AvatarUrl = avatar;
            if (RequestEmbeds != null)
            {
                Embeds.AddRange(RequestEmbeds);
            }
            var contentdata = new StringContent(JsonConvert.SerializeObject(this), Encoding.UTF8, "application/json");
            _httpClient.PostAsync(_webhookUrl, contentdata);
        }
    }
}
