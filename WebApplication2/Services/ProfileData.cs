using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApplication2.Services
{
    public class Inputs
    {
        [JsonProperty("input1")]
        public IList<AutismProfile> AutismProfile { get; }

        public Inputs(AutismProfile autismProfile)
        {
            AutismProfile = new List<AutismProfile>() { autismProfile };
        }
    }
    public class ProfileData
    {
        public ProfileData(AutismProfile autismProfile)
        {
            Inputs = new Inputs(autismProfile);
        }

        public Inputs Inputs { get; }

        public Dictionary<string, string> GlobalParameters => new Dictionary<string, string>() { };
    }

}