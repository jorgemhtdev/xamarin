using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CurrencyConverterJSON.Models;
using Newtonsoft.Json;

namespace CurrencyConverterJSON.Services
{
    public class ApiServices
    {
        private string appId = "HERE YOUR ID";
		private string url = "/api/latest.json?app_id=";

        public ApiServices()
        {
        }

		public async Task<ExchangeRates> GetAllOrders()
		{
			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri("https://openexchangerates.org");

                var result = await client.GetAsync(this.url+this.appId);

				string data = await result.Content.ReadAsStringAsync();

				if (result.IsSuccessStatusCode)
				{
					return JsonConvert.DeserializeObject<ExchangeRates>(data);
				}
				else
				{
					return new List<ExchangeRates>();
				}
			}
		}
    }
}
