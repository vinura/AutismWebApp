using Newtonsoft.Json;

namespace WebApplication2.Services
{
    public class AutismProfile
    {
        [JsonProperty("A1")]
        public int A1 { get; set; }

        [JsonProperty("A2")]
        public int A2 { get; set; }

        [JsonProperty("A3")]
        public int A3 { get; set; }

        [JsonProperty("A4")]
        public int A4 { get; set; }

        [JsonProperty("A5")]
        public int A5 { get; set; }

        [JsonProperty("A6")]
        public int A6 { get; set; }

        [JsonProperty("A7")]
        public int A7 { get; set; }

        [JsonProperty("A8")]
        public int A8 { get; set; }

        [JsonProperty("A9")]
        public int A9 { get; set; }

        [JsonProperty("A10")]
        public int A10 { get; set; }

        [JsonProperty("Age")]
        public float Age { get; set; }

        [JsonProperty("Sex")]
        public string Sex { get; set; }

        [JsonProperty("Ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("Jaundice")]
        public string Jaundice { get; set; }

        [JsonProperty("Family_ASD")]
        public string Family_ASD { get; set; }

        [JsonProperty("Language")]
        public string Language { get; set; }

        [JsonProperty("User")]
        public string User { get; set; }

        [JsonProperty("Class")]
        public string Class{ get; set; }
    }

}