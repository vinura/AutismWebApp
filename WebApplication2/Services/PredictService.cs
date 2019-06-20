using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public class PredictService
    {

        //public async Task<Status> PredAutism(ProfileData autismProfileData, string apiKey)
        public async Task<Status> PredAutism(ProfileData autismProfileData)

        {
            using (var client = new HttpClient())
            {

                


                const string apiKey = "BO8h87Fuy3L9nPVA5ITQGz1sUkXdBCiq37YNBclQa3nIqoBLvYzyFTj0rx4JAjzT6RnNtXXuXrXSILijnpyHZQ=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/119366af52834f89a9a142bf053184c3/services/3a3bb3e8995449c6974cb84598a3f52d/execute?api-version=2.0&format=swagger");

                string msg = JsonConvert.SerializeObject(autismProfileData);

                HttpResponseMessage response = await client
                    .PostAsync("", new StringContent(msg, Encoding.UTF8, "application/json"))
                    .ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    AutismServiceResponse csr = JsonConvert.DeserializeObject<AutismServiceResponse>(result);
                    return csr.GetStatus();
                }
                else
                {
                    throw new HttpRequestException(string.Format("The request failed with status code: {0}", response.StatusCode));

                

            }

            }
        }
    }
}

