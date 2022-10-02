using System;
using RestSharp;

namespace OpenWether
{
    public class OpenWetherAdaapter//התחברות לשרת מזג האוייר
    {
        public string GetComingWeek(string City)
        {
            var result = string.Empty;

            string Url = $"https://openweathermap.org/";

            var client = new RestClient(Url);

            var request = new RestRequest(new Uri(Url), Method.Get);

            RestResponse response = client.Execute(request);

            return response.Content;

        }

    }
}
