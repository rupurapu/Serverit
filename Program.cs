using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Assignment1
{
    public interface ICityBikeDataFetcher
    {
        Task<int> GetBikeCountInStation(string stationName);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
        }
    }
    class Data
    {
        public string station {get;set;}
        public string noOfBikes {get;set;}
    }
    class RealTimeCityBikeDataFetcher : ICityBikeDataFetcher
    {
        public async Task<int> GetBikeCountInStation(string stationName)
        {
            var client = new System.Net.Http.HttpClient();
            HttpResponseMessage response = await client.GetAsync("http://api.digitransit.fi/routing/v1/routers/hsl/bike_rental");
            var msg = await response.Content.ReadAsStringAsync();
            var dSerial = JsonConvert.DeserializeObject<Data>(msg);
            Console.WriteLine(value: dSerial);
            return 0b0;
        }
    }
}
