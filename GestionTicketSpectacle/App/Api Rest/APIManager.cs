using GestionTicketSpectacle.App.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GestionTicketSpectacle.App.Api_Rest
{
    public class APIManager
    {
        public async Task<List<Spectacle>> GetSpectacles()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://sheets.googleapis.com/v4/spreadsheets/{Constant.GoogleSheetID}/values/{Constant.GoogleSheetName}?alt=json&key={Constant.GoogleSheetApiKey}");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            var spectacles = new List<Spectacle>();

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(jsonString);

                var values = jsonObject["values"];

                if (values != null)
                {
                    foreach (var value in values.Skip(1)) // La première ligne du google sheet correspond aux headers donc on skip
                    {
                        spectacles.Add(new Spectacle
                        (
                            typeSpectable:TypeSpectable.Theatre,
                            iD : int.Parse(value[0]?.ToString()),
                            titre : value[1]?.ToString(),
                            date : DateTime.Parse(value[3]?.ToString()),
                            lieu : value[2]?.ToString(),
                            nbPlace : int.Parse(value[4]?.ToString())
                        ));
                    }
                }
            }

            return spectacles;
        }
    }
}
