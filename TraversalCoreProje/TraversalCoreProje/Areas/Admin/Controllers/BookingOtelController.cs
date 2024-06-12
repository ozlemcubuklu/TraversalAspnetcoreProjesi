using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
 using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TraversalCoreProje.Areas.Admin.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookingOtelController : Controller
    {
        public async Task<IActionResult> Index()
        {
           
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?locale=en-gb&filter_by_currency=AED&checkin_date=2024-09-14&dest_type=city&dest_id=-1446262&adults_number=2&checkout_date=2024-09-15&order_by=popularity&room_number=1&units=metric&children_number=2&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&include_adjacency=true&page_number=0"),
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
            var bodyreplace = body.Replace(".","");
                var list = JsonConvert.DeserializeObject<BookingOtelSearchViewModel>(bodyreplace);
                return View(list.results);

               
            }
           
        }



        public IActionResult GetCityDestId()
        {
            return View();
        }



        [HttpPost]

        public async Task<IActionResult> GetCityDestId(string p)
        {
        
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={p}&locale=en-gb"),
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
                return View();
            }
        }
    
    }
}
