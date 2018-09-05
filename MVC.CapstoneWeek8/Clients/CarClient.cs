using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using CapstoneWeek8.Domain.Models;

namespace MVC.CapstoneWeek8.Clients
{
    public class CarClient
    {
        private readonly IRestClient _client;
        public CarClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["CarApiBaseUrl"]);
        }
        public async Task<Car> GetCar()
        {
            var request = new RestRequest ("API/Cars", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<Car>(response.Content);
        }
    }
}