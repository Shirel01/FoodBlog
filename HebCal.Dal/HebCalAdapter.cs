using RestSharp;
using System;

namespace HebCal.DAL
{

    public class HebCalAdapter
    {

        public string GetComingWeek(string City)
        {
            var result = string.Empty;

            string Url = $"https://www.hebcal.com/hebcal?v=1&geo={City}&cfg=json&maj=on&min=on&mod=on&nx=on&year=now&month=x&ss=on&mf=on&c=on&M=on&s=on&end=2022-09-30&start=2022-09-17";

            var client = new RestClient(Url);

            var request = new RestRequest(new Uri(Url), Method.Get);

            RestResponse response = client.Execute(request);

            return response.Content;

        }



    }


}