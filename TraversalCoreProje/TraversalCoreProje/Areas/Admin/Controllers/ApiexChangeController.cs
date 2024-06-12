using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
    using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    public class ApiexChangeController : Controller
    {
        [Area("Admin")]
        public  async Task<IActionResult> Index()
        {
      //  List<BookingExchangeViewModel> list = new List<BookingExchangeViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?locale=tr&currency=TRY"),
                Headers =
    {
        { "X-RapidAPI-Key", "5296dfda64msh4dee631bc7509f7p12b1a8jsn3368c4d8bf98" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var list = JsonConvert.DeserializeObject<BookingExchangeViewModel>(body);
                return View(list.exchange_rates);

            }
        }
    }
}
