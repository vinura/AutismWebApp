using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.Services
{
    public class Status
    {
        [JsonProperty("Scored Labels")]
        public string Label { get; set; }

        [JsonProperty("Scored Probabilities")]
        public float Probability { get; set; }
    }

    public class Results
    {
        [JsonProperty("Status")]
        public IList<Status> Status { get; set; }
    }

    public class AutismServiceResponse
    {
        [JsonProperty("Results")]
        public Results Results { get; set; }

        public Status GetStatus() => Results.Status.First();
    }
}
