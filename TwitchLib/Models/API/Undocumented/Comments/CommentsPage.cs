using Newtonsoft.Json;

namespace TwitchLib.Models.API.Undocumented.Comments
{
    public class CommentsPage
    {
        [JsonProperty(PropertyName = "comments")]
        public Comment[] Comments { get; set; }
        [JsonProperty(PropertyName = "_prev")]
        public string Prev { get; set; }
        [JsonProperty(PropertyName = "_next")]
        public string Next { get; set; }
    }
}
