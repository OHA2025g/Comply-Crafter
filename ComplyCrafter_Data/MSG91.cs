using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplyCrafter_Data
{

    public class MSG91_Message
    {
        [JsonProperty("template_id")]
        public string? template_id { get; set; }

        [JsonProperty("short_url")]
        public string? short_url { get; set; }

        [JsonProperty("short_url_expiry")]
        public string? short_url_expiry { get; set; }

        [JsonProperty("realTimeResponse")]
        public string? realTimeResponse { get; set; }
        public List<MSG91_MessageRecipient> recipients { get; set; } = new List<MSG91_MessageRecipient>();
    }

    public class MSG91_MessageRecipient
    {
        [JsonProperty("mobiles")]
        public string? mobiles { get; set; }

        [JsonProperty("VAR1")]
        public string? VAR1 { get; set; }
    }

}
