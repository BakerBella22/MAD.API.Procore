using Newtonsoft.Json;
namespace MAD.API.Procore.Endpoints.Submittals.Models
{
    public class Statu
    {

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")] public long Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")] public string Name { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        [JsonProperty("status")] public string Status { get; set; }
    }
}
