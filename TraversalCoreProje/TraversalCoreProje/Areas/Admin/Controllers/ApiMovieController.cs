using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
    using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;
using TraversalCoreProje.Areas.Admin.Models;
using Newtonsoft.Json;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {

            //05d2356c9dmsh0a112a542388d2ap106544jsn0fdf5f25c10f


        List<ApiMovie> movies = new List<ApiMovie>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "5296dfda64msh4dee631bc7509f7p12b1a8jsn3368c4d8bf98" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

               movies=JsonConvert.DeserializeObject<List<ApiMovie>>(body);
            return View(movies);
            }
        }
    }
}
